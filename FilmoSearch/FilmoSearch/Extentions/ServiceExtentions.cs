using FilmoSearch.Contracts;
using FilmoSearch.Repository;
using FilmoSearch.Serivce.Contracts;
using FilmoSearch.Service;

namespace FilmoSearch.Extentions
{
    public static class ServiceExtentions
    {
        public static void ConfigureRepositoryManager(this IServiceCollection services)=>
            services.AddScoped<IRepositoryManager, RepositoryManager>();
        public static void ConfigureServiceManager(this IServiceCollection services) =>
            services.AddScoped<IServiceManager, ServiceManager>(); 
    }
}
