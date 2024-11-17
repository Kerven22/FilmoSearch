using FilmoSearch.Contracts;
using FilmoSearch.Repository;
using System.Runtime.CompilerServices;

namespace FilmoSearch.Extentions
{
    public static class ServiceExtentions
    {
        public static void ConfigureRepositoryManager(this IServiceCollection services)=>
            services.AddScoped<IRepositoryManager, RepositoryManager>(); 
    }
}
