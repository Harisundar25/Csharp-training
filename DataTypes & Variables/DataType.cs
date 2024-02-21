using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes___Variables
{
    public class DataType
    {
        int age = 15;
        public static void Example()
        {
            int age = 20;// new value assigned
            sbyte x = 120;// primitive data type with whole numbers from -128 to 128
            short y = -32767; // from -32767 to 32767
            long z = 9000000000000000000; //from -9,223,327,036,854,775,808 to 9,223,372,036,854,775,807
            float f = 99.99f; //allows decimals from 1.5 x 10 ^ 45 to 3.4 x 10 ^ 78
            double d1 = 3.1415; 
            double d2 = 5.2;
            double dDiv = d1 / d2; //  retains its precision up to approximately 15-16 digits
            float f1 = 3.1415f;
            float f2 = 5.2f;
            float fDiv = f1 / f2; // rounded to approximately 7 digits after the decimal point

            Console.WriteLine(age);// output will be 20
            //Console.WriteLine(x);
            //Console.WriteLine(y);   
            //Console.WriteLine(z);
            //Console.WriteLine(f);
            Console.WriteLine(dDiv); // high precision and more memory
            Console.WriteLine(fDiv);  // less precision and less memory
            Console.ReadKey();
            // each datatye size in byte
        }
    }
}
