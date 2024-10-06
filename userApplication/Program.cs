using userApplication.Application.ports.input;
using userApplication.Application.ports.output;
using userApplication.Application.service;
using userApplication.Infrastructure.adapters.output.persistance;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.


builder.Services.AddAutoMapper(typeof(Program));
builder.Services.AddScoped<UserServicePort, userService>();
builder.Services.AddScoped<UserPersistencePort, userPersistanceAdapter>();
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
