namespace Convertor.UnitConvertor
{
    public interface IUnitConvertor
    {
        string Convert(double inputValue, string inputUnits, string outputUnits);
    }
}
