using FilmoSearch.Contracts;
using FilmoSearch.Logging;
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

        public static void ConfigureLogger(this IServiceCollection services) =>
            services.AddSingleton<ILoggerManager, LoggerManager>();

        public static void AddPresentationLayer(this IServiceCollection services) =>
            services.AddControllers().AddApplicationPart(typeof(Presentation.AssemblyReference).Assembly); 
    }
}
