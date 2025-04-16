using Domain.UseCases.FilmUseCase;
using Domain.UseCases.UserUseCases;
using Entity.Repositories;
using Entity.Storages;

namespace FilmoSearch.Extentions
{
    public static class ServiceExtentions
    {
        public static void ConfigureSql(this IServiceCollection services, IConfiguration configuration) =>
            services.AddSqlServer<MsDatabaseContext>(configuration.GetConnectionString("default"), b => b.MigrationsAssembly("FilmoSearch"));


        public static void ConfigureFilmUseCase(this IServiceCollection service) =>
            service.AddScoped<IFilmUseCase, FilmUseCase>();

        public static void ConfigureFilmStorage(this IServiceCollection services) =>
            services.AddScoped<IFilmStorage, FilmStorage>();

        public static void ConfigureUserUseCase(this IServiceCollection services) =>
            services.AddScoped<IUserUseCase, UserUseCase>();

        public static void ConfigureUserStorage(this IServiceCollection services) =>
            services.AddScoped<IUserStorage, UserStorage>();


    }
}
