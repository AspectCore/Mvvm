using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspectCore.Extensions.Mvvm.DependencyInjection;

namespace AspectCore.Extensions.Mvvm
{
    public interface IApplicationStartup
    {
        IServiceResolver ConfigureServices(IServiceRegister register);

        IApplication ConfigureApplication(IApplicationBuilder app);
    }
}