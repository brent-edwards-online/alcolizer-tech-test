using System;

namespace Convertor.Parser
{
    public interface IInputParser
    {
        Tuple<double, string> Parse(string input);
    }
}
