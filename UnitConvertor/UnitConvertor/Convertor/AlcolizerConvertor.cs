using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertor.UnitConvertor
{
    public class AlcolizerConvertor : IUnitConvertor
    {
        readonly Dictionary<string, double> CONVERSIONFACTORS_FROM_1G = new Dictionary<string, double>
        {
            { "ug/100mL", 100000.0 },
            { "mg/L", 1000.0 },
            { "g/210L", 210.0 },
            { "g/230L", 230.0 },
            { "g/dL", 0.1 },
            { "ug/L", 1000000.0 },
            { "g/L", 1.0 }
        };

        readonly Dictionary<string, double> CONVERSIONFACTORS_TO_1G = new Dictionary<string, double>
        {
            { "ug/100mL", 1.0/100000.0 },
            { "mg/L", 1.0/1000.0 },
            { "g/210L", 1.0/210.0 },
            { "g/230L", 1.0/230.0 },
            { "g/dL", 1.0/0.1 },
            { "ug/L", 1.0/1000000.0 },
            { "g/L", 1.0/1.0 }
        };

        public string Convert(double inputValue, string inputUnits, string outputUnits)
        {
            double inputConversionFactor = CONVERSIONFACTORS_TO_1G[inputUnits];
            double outputConversionFactor = CONVERSIONFACTORS_FROM_1G[outputUnits];
            var outputValue = inputValue * inputConversionFactor * outputConversionFactor;
            return String.Format("{0:f6} {1}", outputValue, outputUnits);   
        }
    }
}
