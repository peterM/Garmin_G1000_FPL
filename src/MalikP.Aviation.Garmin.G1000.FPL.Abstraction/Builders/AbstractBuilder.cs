using System;

namespace MalikP.Aviation.Garmin.G1000.FPL.Abstraction.Builders
{
    public abstract class AbstractBuilder<TBuilder, TBuildee> : IBuilder<TBuilder, TBuildee>
        where TBuilder : AbstractBuilder<TBuilder, TBuildee>
    {
        protected AbstractBuilder()
        {
        }

        public abstract TBuildee Build();

        protected TBuilder WithData<TData>(Action<TData> action, TData data)
        {
            action?.Invoke(data);
            return this as TBuilder;
        }
    }
}