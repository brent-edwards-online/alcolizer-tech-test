using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Convertor.Parser
{
    public class AlcolizerInputParser : IInputParser
    {
        readonly Regex INPUTFORMAT = new Regex(@"^([1-9][0-9\.]*) (g/L|mg/L|g/210L|g/230L|g/dL|ug/L|ug/100mL)$");

        public Tuple<double, string> Parse(string inputString)
        {
            if (INPUTFORMAT.IsMatch(inputString))
            {
                var matches = INPUTFORMAT.Matches(inputString);
                var valueString = matches[0].Groups[1].Value;
                var units = matches[0].Groups[2].Value;

                var value = Double.Parse(valueString);

                return new Tuple<double, string>(value, units);
            }
            else
            {
                throw new Exception("Invalid arguments, format was incorrect: " + inputString);
            }
        }
    }
}
