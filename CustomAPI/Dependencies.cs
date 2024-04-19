using System;
using System.Collections.Generic;

namespace CustomAPI
{
    public class Dependencies
    {
        public class ExerFwAPIWrite
        {
            public List<string> apiRawData = new List<string>();

            public bool hexFlag = false;

            public string fwResponse = "Success";

            public string fwResTooltip = "No Error";

            public int CurrIndex = 0;

            public bool IsSend = false;

        }
    }
}
