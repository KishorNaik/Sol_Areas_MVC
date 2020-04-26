using Microsoft.Extensions.DependencyInjection;
using Sol_Demo.Areas.Admin.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Sol_Demo.Areas.Admin.StartUp.Services
{
    public static class AdminStartUpService
    {
        public static void AddAdminService(this IServiceCollection services)
        {
            services.AddTransient<IMessage, Message>();
        }
    }
}
