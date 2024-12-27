using DontWasteFood.DomainServices.IRepository;
using Microsoft.EntityFrameworkCore;
using DontWasteFood.Infrastructure.Repository;
using DontWasteFood.GraphQL.Queries;
using DontWasteFood.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IPackageRepository, PackageRepository>();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<DontWasteFoodDbContext>(options => options.UseSqlServer(connectionString));

builder.Services
    .AddGraphQLServer()
    .AddQueryType<PackageQueries>();

var app = builder.Build();

app.MapGraphQL("/graphql");

app.Run();
