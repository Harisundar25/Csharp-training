using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decision_Making
{
    internal class Enhanced_If
    {
        // condition ? first_expression : second expression;
        // condition has to be either true or false
        // The conditional operator is right - associative.
        // The expression a ? b : c? d : e
        // is evaluated as a ? b : (c ? d: e)
        // not as (a? b : c) ? d: e
        // The conditional operator cannot be overloaded.

        int temperature = -5;
        string stateOfMatter;

        /* if (temperature < 0)
                   stateOfMatter = "solid";
            else
                   stateOfMatter = "liquid";
        */
        // in short
        stateOfMatter = temperature < 0 ? "solid" : "liquid";
        Console.WriteLine("State of matter is " + stateOfMatter);
        
      
    }
}
