using ExemploEntityFrameworkOracle.Application.DependencyInjections;
using ExemploEntityFrameworkOracle.Infra.Contexties;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddSwaggerGen();

builder.Services.AddClientDIServices();
builder.Services.AddClientDIRepositories();

builder.Services.AddDbContext<ExemploEntityFrameworkOracleContext>();

var app = builder.Build();

app.UseSwaggerUI();
app.UseSwagger();

app.MapControllers();

app.Run();