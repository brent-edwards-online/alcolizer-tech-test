using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertor.Parser
{
    public interface IArgumentParser
    {
        string Parse(string[] args);
    }
}
