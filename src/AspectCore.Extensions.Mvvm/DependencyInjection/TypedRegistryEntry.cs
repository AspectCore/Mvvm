using System;

namespace AspectCore.Extensions.Mvvm.DependencyInjection
{
    public sealed class TypedRegistryEntry : RegistryEntry
    {
        public Type ImplementationType { get; }

        public TypedRegistryEntry(Type serviceType, Type implementationType, LifeCycle lifeCycle) : base(serviceType, lifeCycle)
        {
            if (implementationType == null) { throw new ArgumentNullException(nameof(implementationType)); }

            ImplementationType = implementationType;
        }
    }
}