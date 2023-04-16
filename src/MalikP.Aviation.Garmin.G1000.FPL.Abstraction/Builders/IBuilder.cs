namespace MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Builders
{
    public interface IBuilder<TBuilder, TBuildee>
        where TBuilder : class
    {
        TBuildee Build();
    }
}