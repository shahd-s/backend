using System;
using Microsoft.Extensions.DependencyInjection;

namespace backend 
{
    public static class IoC
    {
        public static AppDBContext AppDbContext => IoCContainer.Provider.GetService<AppDBContext>();
    }

    public static class IoCContainer
    {
        public static IServiceProvider Provider { get; set; }
    }
}
