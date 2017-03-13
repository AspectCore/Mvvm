using System.Collections.Generic;

namespace AspectCore.Extensions.Mvvm.DependencyInjection
{
    public interface IServiceRegister
    {
        void Add(RegistryEntry entry);

        void Replace(RegistryEntry entry);

        IEnumerator<RegistryEntry> GetEnumerator();
    }
}
