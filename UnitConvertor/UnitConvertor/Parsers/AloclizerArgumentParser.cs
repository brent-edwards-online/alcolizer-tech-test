using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Convertor.Parser
{
    public class AlcolizerArgumentParser : IArgumentParser
    {
        readonly List<string> VALIDUNITS = new List<string>{
            "ug/100mL",
            "mg/L",
            "g/210L",
            "g/230L",
            "g/dL",
            "ug/L",
            "g/L"
        };

        public string Parse(string[] args)
        {
            if(args.Length == 1)
            {
                var inputstring = args[0];

                if (VALIDUNITS.FindIndex(u => u == inputstring) >= 0)
                {
                    return inputstring;
                }
                throw new Exception("Invalid input: " + inputstring);
            }
            else
            {
                throw new Exception("Invalid input");
            }
            
        }
    }
}
