using SupesScrapbook.API.Server;
using SupesScrapbook.Application;
using SupesScrapbook.Infrastructure;
var builder = WebApplication.CreateBuilder(args);
var configuration = builder.Configuration;

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddApplication();
builder.Services.AddInfrastructure(configuration);

var app = builder.Build();
var group = app.MapGroup("/");
group.MapSuperHeroRoutes();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();

