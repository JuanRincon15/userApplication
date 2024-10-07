using userApplication.Application.ports.input;
using userApplication.Application.ports.output;
using userApplication.Application.service;
using userApplication.Infrastructure.adapters.output.persistance;
using userApplication.Infrastructure.adapters.output.persistance.postgreSQL.repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddAutoMapper(typeof(Program));

builder.Services.AddScoped<IUserRepository,UserRepository>();
builder.Services.AddScoped<ICountryRepository,CountryRepository>();
builder.Services.AddScoped<IDepartmentRepository, DepartmentRepository>();
builder.Services.AddScoped<IMunicipalityRepository,MunicipalityRepository>();
builder.Services.AddScoped<UserPersistencePort, userPersistanceAdapter>();
builder.Services.AddScoped<CountryPersistencePort, CountryPersistanceAdapter>();
builder.Services.AddScoped<DepartmentPersistencePort, DepartmentPersistanceAdapter>();
builder.Services.AddScoped<MunicipalityPersistencePort, MunicipalityPersistanceAdapter>();
builder.Services.AddScoped<UserServicePort, userService>();
builder.Services.AddScoped<CountyServicePort, countryService>();
builder.Services.AddScoped<DepartmentServicePort,DepartmentService>();
builder.Services.AddScoped<MunicipalityServicePort, MunicipalityService>();

builder.Services.AddControllers();
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

app.MapControllers();

app.Run();
