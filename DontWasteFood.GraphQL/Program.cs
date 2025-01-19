using DontWasteFood.DomainServices.IRepository;
using Microsoft.EntityFrameworkCore;
using DontWasteFood.Infrastructure.Repository;
using DontWasteFood.GraphQL.Queries;
using DontWasteFood.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IPackageRepository, PackageRepository>();

var connectionString = string.Empty;

if (builder.Environment.IsDevelopment())
{
    connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
}
else
{
    connectionString = Environment.GetEnvironmentVariable("DONT_WASTE_FOOD_API_CONNSTR");
}
builder.Services
    .AddGraphQLServer()
    .AddQueryType<PackageQueries>();

var app = builder.Build();

app.MapGraphQL("/graphql");

app.Run();
