using DontWasteFood.Domain.Enums;
using DontWasteFood.DomainServices;
using DontWasteFood.DomainServices.IRepository;
using DontWasteFood.DomainServices.IService;
using DontWasteFood.Infrastructure.Data;
using DontWasteFood.Infrastructure.Repository;
using DontWasteFood.Infrastructure.Service;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Text.Json.Serialization;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IStudentRepository, StudentRepository>();
builder.Services.AddScoped<ICanteenWorkerRepository, CanteenWorkerRepository>();
builder.Services.AddScoped<IPackageRepository, PackageRepository>();
builder.Services.AddScoped<IProductRepository, ProductRepository>();
builder.Services.AddScoped<ICanteenRepository, CanteenRepository>();
builder.Services.AddScoped<IReservationService, ReservationService>();
builder.Services.AddScoped<IPackageService, PackageService>();


var connectionString = string.Empty;

if (builder.Environment.IsDevelopment())
{
    connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
}
else
{
    connectionString = Environment.GetEnvironmentVariable("DONT_WASTE_FOOD_API_CONNSTR");
}

builder.Services.AddDbContext<DontWasteFoodDbContext>(options =>
{
    options.UseSqlServer(connectionString);
});

builder.Services.AddDbContext<AuthDbContext>(options =>
{
    options.UseSqlServer(connectionString);
});

builder.Services.AddAuthorization(policyBuilder =>
{
    policyBuilder.AddPolicy(UserRole.CanteenWorker.ToString(), policy => policy.RequireRole(UserRole.CanteenWorker.ToString()));
    policyBuilder.AddPolicy(UserRole.Student.ToString(), policy => policy.RequireRole(UserRole.Student.ToString()));
});

builder.Services.AddIdentityApiEndpoints<IdentityUser>(options =>
{
    options.User.RequireUniqueEmail = true;
    options.SignIn.RequireConfirmedPhoneNumber = false;

    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = true;
    options.Password.RequireUppercase = true;
    options.Password.RequireNonAlphanumeric = true;
    options.Password.RequiredLength = 8;

})
    .AddEntityFrameworkStores<AuthDbContext>();

builder.Services.AddControllers()
    .AddJsonOptions(options =>
    {
        options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
    });

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapGroup("/account").MapIdentityApi<IdentityUser>();

app.MapControllers();

app.Run();
