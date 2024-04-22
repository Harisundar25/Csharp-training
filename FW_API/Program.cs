// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        // Prompt the user to enter the APIs separated by a space
        Console.WriteLine("Enter the two APIs separated by a space:");
        string apiInput = Console.ReadLine();

        // Prompt the user to enter the delay between the APIs
        Console.WriteLine("Enter the delay between the APIs in milliseconds:");
        int delay = int.Parse(Console.ReadLine());

        // Split the API input by space
        string[] apis = apiInput.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        if (apis.Length != 2)
        {
            Console.WriteLine("Please enter exactly two APIs separated by a space.");
            return;
        }

        // Convert APIs from hexadecimal string to byte arrays
        byte[][] apiData = new byte[2][];
        for (int i = 0; i < 2; i++)
        {
            apiData[i] = ConvertHexStringToBytes(apis[i]);
        }

        // Send the first API request
        await SendApiRequest(apiData[0]);

        // Delay for the specified time
        await Task.Delay(delay);

        // Send the second API request
        await SendApiRequest(apiData[1]);
    }

    static async Task SendApiRequest(byte[] data)
    {
        // Simulate sending API request
        Console.WriteLine("Sending API request: " + BitConverter.ToString(data));
        // Code to send API request goes here
        await Task.Delay(100); // Simulating API request delay
        Console.WriteLine("API request sent successfully.");
    }

    static byte[] ConvertHexStringToBytes(string hexString)
    {
        hexString = hexString.Replace("0x", "");
        byte[] bytes = new byte[hexString.Length / 2];
        for (int i = 0; i < bytes.Length; i++)
        {
            bytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
        }
        return bytes;
    }
}
