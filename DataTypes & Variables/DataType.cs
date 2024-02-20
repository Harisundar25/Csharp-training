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
            long z = 9000000000000000000;//from -9,223,327,036,854,775,808 to 9,223,372,036,854,775,807
            float m = 99.99f; //allows decimals from 1.5 x 10 ^ 45 to 3.4 x 10 ^ 78
            Console.WriteLine(age);// output will be 20
            Console.WriteLine(x);
            Console.WriteLine(y);   
            Console.WriteLine(z);
            Console.WriteLine(m);
            Console.ReadKey();
        }
    }
}
