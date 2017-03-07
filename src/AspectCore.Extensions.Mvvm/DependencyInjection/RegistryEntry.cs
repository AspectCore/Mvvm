using System;

namespace AspectCore.Extensions.Mvvm.DependencyInjection
{
    public abstract class RegistryEntry
    {
        public Type ServiceType { get; }

        public LifeCycle LifeCycle { get; }

        protected RegistryEntry(Type serviceType,LifeCycle lifeCycle)
        {
            if (serviceType == null) { throw new ArgumentNullException(nameof(serviceType)); }

            ServiceType = serviceType;
            LifeCycle = lifeCycle;
        }
    }
}