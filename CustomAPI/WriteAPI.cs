using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Threading;
using static CustomAPI.Dependencies;

namespace CustomAPI
{
    public class WriteAPI
    {
        static int Delay = 100;//Default delay
        public static void WriteFwAPIRawData(ExerFwAPIWrite apiRawData)
        {
            try
            {
                ExerFwAPIWrite manualApiRawData = new ExerFwAPIWrite();
                manualApiRawData.apiRawData.Add("0x00,0x01,0x02");
                manualApiRawData.CurrIndex = 0;

                if (manualApiRawData.CurrIndex == 0)
                    Delay = 100;//Reset the delay

                //apiRawData.CurrIndex: Send button to initiate one API at a time from a group of APIs
                int StopIndex = apiRawData.apiRawData.Count;
                if (apiRawData.IsSend)
                {
                    StopIndex = apiRawData.CurrIndex + 1;
                }
                for (int i = apiRawData.CurrIndex; i < StopIndex; i++)
                {
                    string apiString = manualApiRawData.apiRawData[i];//Taking the input string value
                    bool hexFlag = apiRawData.hexFlag;//Taking the input bool value
                    bool error = false;//initially no errors

                    //Check for ";" in apiString and update the delay value
                    string[] APIandDelay = apiString.Split(';');
                    if (APIandDelay.Length > 1)
                    {
                        Delay = int.Parse(APIandDelay[1].Trim());
                    }

                    //if (hexFlag)//for hex formats (if the hex checkbox was checked then condition will execute)
                    //{
                    List<byte> inputBytes = new List<byte>();
                    string byteArr = "";
                    string[] HexValues = APIandDelay[0].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);//Separating string by commas and empty space 
                    foreach (string hexValue in HexValues)
                    {
                        try
                        {
                            //Use cases
                            //1. ,,,, = [,,,,]
                            //2. ,1,1,2,0 = [1,1,2,0] 
                            //3. 0x01,0x0,0x1 

                            string lhexValue = hexValue.Trim();
                            if (lhexValue.Length > 0)
                            {
                                lhexValue = lhexValue.Replace("0x", "");
                                lhexValue = lhexValue.Replace("0X", "");
                                if (byte.TryParse(lhexValue, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out byte res))
                                {
                                    inputBytes.Add(res);
                                }
                            }
                            else
                                continue;
                            //Trim 0x and 0X
                            //Trim 
                            // string data = hexValue.Substring(2);//Can cause exception if length is less than 3
                            //if (byte.TryParse(data.Trim('x', 'X'), NumberStyles.HexNumber, CultureInfo.InvariantCulture, out byte value))//converting each input hex value to byte
                            //{
                            //    inputBytes.Add(value);
                            //}
                            {
                                error = true;//if error occurs setting to true
                                string errorMessage = "Hexadecimal value is in improper format or input value is higher range for byte "; // this message will print in UI(there is one icon in UI while hover it)
                                Console.WriteLine(errorMessage);
                                // FWAppObj.FWHost.WriteToDebugLogger(DebugModeType.DEBUG, errorMessage);//Also prints in debug logger
                                apiRawData.fwResTooltip = errorMessage; // Adds the Error content to the icon
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(MethodBase.GetCurrentMethod().Name, ex);
                        }
                    }
                    foreach (byte byteValue in inputBytes)
                    {
                        byteArr += (byteValue.ToString() + " ");// all the bytes are comverted to string 
                    }
                    //FWAppObj.FWHost.WriteToDebugLogger(DebugModeType.DEBUG, "WriteFwAPIRawData " + byteArr);//the final byte is printed in Debug logger
                    // objHelperComm.m_CommonAPIcontroller.WriteReg(inputBytes.ToArray(), $"Index: {apiRawData.CurrIndex}");
                    Console.WriteLine(BitConverter.ToString(inputBytes.ToArray()), $"Index: {apiRawData.CurrIndex}");
                    apiRawData.CurrIndex += 1;
                    Thread.Sleep(Delay);//Wait for given delay
                    string status = "Write Success";
                    string resultStatus = error ? "Contains Error" : status;
                    apiRawData.fwResponse = resultStatus; // the status whether it contains error or succcess will print in UI
                    //}
                    //else
                    //{
                    //    //CheckValidInputAndSendToBE(apiString, apiRawData);//if the hex checkbox was not checked this method will execute
                    //}
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(MethodBase.GetCurrentMethod().Name, ex);
            }

        }
      /*  private static void CheckValidInputAndSendToBE(string eachInputCmds, ExerFwAPIWrite apiRawData)
        {
            bool error = false; //initially no errors
            string Input = eachInputCmds;
            string eachInputCmd = Input.Trim();
            int ExecutionCount = 1;
            if (eachInputCmd.Contains(';'))//Separating input string by ";"
            {
                int.TryParse(eachInputCmd.Split(';')[1], out ExecutionCount);
                eachInputCmd = eachInputCmd.Split(';')[0];
            }
            string[] decimalStrings = null;//created an array to store the 
            if (eachInputCmd.Contains(", "))//Separating input string by ", "
            {
                decimalStrings = eachInputCmd.Split(',');
                for (int i = 0; i < decimalStrings.Length; i++)
                {
                    decimalStrings[i] = decimalStrings[i].Trim();
                }
            }
            else if (eachInputCmd.Contains(" "))  //Separating input string by " "

            {
                decimalStrings = eachInputCmd.Split(' ');
            }
            else if (eachInputCmd.Contains(","))    //Separating input string by ","
            {
                decimalStrings = eachInputCmd.Split(',');
            }
            else
            {
                decimalStrings = new string[] { eachInputCmd };//converted the final separated inputs as array
            }

            List<byte> inputBytes = new List<byte>();
            string byteArr = "";

            foreach (string decimalString in decimalStrings)
            {
                try
                {
                    if (byte.TryParse(decimalString, out byte byteValue)) //converting each input hex value to byte
                    {
                        inputBytes.Add(byteValue);
                    }
                    else
                    {
                        error = true;//if error occurs setting to true
                        string errorMessage = "Decimal value is in improper format or input value is higher range for byte ";// this message will print in UI(there is one icon in UI while hover it)
                        Console.WriteLine(errorMessage);//Also prints in debug logger
                        apiRawData.fwResTooltip = errorMessage; // Adds the Error content to the icon
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(MethodBase.GetCurrentMethod().Name, ex);
                }
            }

            foreach (byte byteValue in inputBytes)
            {
                byteArr += (byteValue.ToString() + " ");
            }
            // FWAppObj.FWHost.WriteToDebugLogger(DebugModeType.DEBUG, "WriteFwAPIRawData " + byteArr);//the final byte is printed in Debug logger
            Console.WriteLine(BitConverter.ToString(inputBytes.ToArray()), $"Index: {apiRawData.CurrIndex}");
            string status = "Write Success";
            string resultStatus = error ? "Contains Error" : status;
            apiRawData.fwResponse = resultStatus; // the status whether it contains error or succcess will print in UI
        }*/
    }
}
