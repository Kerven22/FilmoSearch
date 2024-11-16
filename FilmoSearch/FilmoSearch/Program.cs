using FilmoSearch.Contracts;
using FilmoSearch.Logging;
using FilmoSearch.Repository.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
//builder.Services.AddSingleton<ILoggerManager, LoggerManager>();
string? connection = builder.Configuration.GetConnectionString("MsSqlConnection");

builder.Services.AddDbContext<RepositoryMsSqlContext>(options => options.UseSqlServer(connection));                               

var app = builder.Build();

app.MapControllers(); 

app.Run();