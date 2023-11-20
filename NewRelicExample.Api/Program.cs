using Microsoft.EntityFrameworkCore;
using NewRelicExample.Repository;

IConfiguration configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", false, true)
    .Build();



var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<NewRelicExampleDbContext>(options =>
    options.UseNpgsql(configuration.GetConnectionString("NewRelicExamplePostgreSQL")));

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