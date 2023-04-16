namespace MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Serialization
{
    public interface IFlightPlanSerializer
    {
        string SerializeToXml<T>(T data);
    }
}