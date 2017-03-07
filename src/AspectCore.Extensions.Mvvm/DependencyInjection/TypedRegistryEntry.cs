using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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