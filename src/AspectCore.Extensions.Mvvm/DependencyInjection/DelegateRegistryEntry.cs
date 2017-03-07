using System;

namespace AspectCore.Extensions.Mvvm.DependencyInjection
{
    public sealed class DelegateRegistryEntry : RegistryEntry
    {
        public Func<IServiceResolver, object> ImplementationFactory { get; set; }
        public DelegateRegistryEntry(Type serviceType, Func<IServiceResolver, object> implementationFactory, LifeCycle lifeCycle) : base(serviceType, lifeCycle)
        {
            if (implementationFactory == null) throw new ArgumentNullException(nameof(implementationFactory));
            ImplementationFactory = implementationFactory;
        }
    }
}
