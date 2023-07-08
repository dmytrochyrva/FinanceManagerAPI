using FinanceManager.Database.Context;
using FinanceManager.Database.Services;
using FinanceManager.Database.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<FinanceManagerContext>();
builder.Services.AddScoped<IOperationsService, OperationsService>();


var app = builder.Build();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
