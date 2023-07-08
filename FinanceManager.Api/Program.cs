// Project Usings
using FinanceManager.Database.Context;
using FinanceManager.Database.Services;
using FinanceManager.Database.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// CORS Settings
string corsPolicy = "AllowSpecificOrigin";

builder.Services.AddCors(options => {
  options.AddPolicy(corsPolicy, builder => {
    builder.WithOrigins("http://localhost:4200");
  });
});

// Dependency Injection
builder.Services.AddControllers();
builder.Services.AddDbContext<FinanceManagerContext>();
builder.Services.AddScoped<IOperationsService, OperationsService>();
builder.Services.AddScoped<ICategoriesService, CategoriesService>();


var app = builder.Build();

app.UseHttpsRedirection();

app.UseCors(corsPolicy);

app.UseAuthorization();

app.MapControllers();

app.Run();
