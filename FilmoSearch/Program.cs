using FilmoSearch.Extentions;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.ConfigureSql(builder.Configuration);

builder.Services.ConfigureUserUseCase();
builder.Services.ConfigureUserStorage();

builder.Services.ConfigureFilmUseCase();
builder.Services.ConfigureFilmStorage(); 



var app = builder.Build();
app.MapControllers(); 
app.Run();
