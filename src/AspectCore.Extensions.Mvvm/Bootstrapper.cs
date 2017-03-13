using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspectCore.Extensions.Mvvm.DependencyInjection;

namespace AspectCore.Extensions.Mvvm
{
    public class Bootstrapper
    {
        //public 
        public void Startup<TStartup>(params object[] args)
            where TStartup : IApplicationStartup
        {
            var startup = (TStartup)Activator.CreateInstance(typeof(TStartup), args);
            var register = new ServiceRegister();
            var resolver = startup.ConfigureServices(register);
        }
    }
}
