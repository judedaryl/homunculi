using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Homunculi
{
    public static class HomunculiServiceCollectionExtensions
    {
        public static IServiceCollection AddDatabase<TDatabaseContext>(this IServiceCollection services) where TDatabaseContext : DatabaseContext
        {

        }
    }
}
