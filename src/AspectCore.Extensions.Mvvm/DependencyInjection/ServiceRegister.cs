using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspectCore.Extensions.Mvvm.DependencyInjection
{
    internal sealed class ServiceRegister : IServiceRegister
    {
        private readonly ICollection<RegistryEntry> collection = new List<RegistryEntry>();

        public void Add(RegistryEntry entry)
        {
            if (entry == null)
            {
                throw new ArgumentNullException(nameof(entry));
            }
            collection.Add(entry);
        }

        public IEnumerator<RegistryEntry> GetEnumerator()
        {
            return collection.ToList().GetEnumerator();
        }

        public void Replace(RegistryEntry entry)
        {
            if (entry == null)
            {
                throw new ArgumentNullException(nameof(entry));
            }
            var existingEntry = collection.FirstOrDefault(x => x.ServiceType == entry.ServiceType);
            collection.Remove(existingEntry);
            collection.Add(entry);
        }
    }
}
