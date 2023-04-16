using MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Models;

namespace MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Generators
{
    public interface IRouteGenerator
    {
        IRoute GetRoute(IRouteDescriptor routeDescriptor);
    }
}
