using Convertor.Parser;
using Convertor.UnitConvertor;
using System;

namespace Convertor
{
    class Program
    {
        static int Main(string[] args)
        {
            byte result = 0;
            IArgumentParser validator = new AlcolizerArgumentParser();
            IInputParser parser = new AlcolizerInputParser();
            IUnitConvertor convertor = new AlcolizerConvertor();

            try
            {
                var argument = validator.Parse(args);
                var input = parser.Parse(Console.ReadLine());
                var outputString = convertor.Convert(input.Item1, input.Item2, argument);
                Console.WriteLine(outputString);
            }
            catch (Exception ex)
            {
                result = 1;
                Console.Error.WriteLine("An error occurred: " + ex.Message);
            }

            return result;
        }
    }
}
