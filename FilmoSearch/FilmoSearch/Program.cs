using FilmoSearch.Extentions;
using FilmoSearch.Repository.Contexts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
//builder.Services.AddSingleton<ILoggerManager, LoggerManager>();
string? connection = builder.Configuration.GetConnectionString("MsSqlConnection");

builder.Services.AddDbContext<RepositoryMsSqlContext>(options => options.UseSqlServer(connection));
builder.Services.ConfigureLogger();
builder.Services.ConfigureRepositoryManager();
builder.Services.ConfigureServiceManager();
builder.Services.AddPresentationLayer();

var app = builder.Build();

app.MapControllers();

app.Run();