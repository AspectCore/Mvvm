using System;

namespace AspectCore.Extensions.Mvvm.DependencyInjection
{
    public sealed class InstanceRegistryEntry : RegistryEntry
    {
        public object ImplementationInstance { get; }

        public InstanceRegistryEntry(Type serviceType, object implementationInstance) : base(serviceType, LifeCycle.Singleton)
        {
            if (implementationInstance == null) { throw new ArgumentNullException(nameof(implementationInstance)); }
            ImplementationInstance = implementationInstance;
        }
    }
}
