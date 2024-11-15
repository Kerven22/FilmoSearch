using FilmoSearch.Contracts;
using FilmoSearch.Logging;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddSingleton<ILoggerManager, LoggerManager>();

var app = builder.Build();





app.MapControllers(); 

app.Run();
