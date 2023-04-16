namespace MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Models
{
    public interface IWaypoint
    {
        void AddToRoute<T>(T route)
            where T : IRoute;
    }
}