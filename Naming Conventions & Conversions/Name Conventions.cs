using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naming_Conventions___Conversions
{
    // Some coding Standards to follow is mentioned below
    // Class names like ClientActivity (use nouns for classes) -  for separate words it should start with caps
    internal class NameConventions
    {
        // Method name like CalculateValue - ,,,
        // method arguments like firstNumber - ,,,
        public static void Example()
        {
            // local variables like itemCount
            // use userControl instead of usrCtr
            // don't use numbers at the start of variable names


            // Correct
            string myName;
            int lastNum;
            bool isSaved;
            // Avoid
            // String myName;
            // Int32 lastNum;
            // Boolean isSaved;

            // Reference-https://dofactory.com/csharp-coding-standards
        }

    }
}
