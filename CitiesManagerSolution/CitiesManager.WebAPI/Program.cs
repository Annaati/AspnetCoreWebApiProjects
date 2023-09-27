using CitiesManager.WebAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddApiVersioning();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "CitiesManager.WebAPI", Version = "v1" });
});

builder.Services.AddDbContext<MsSqlDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetValue<string>("ConnectionStrings:MsSqlConnStr") ?? throw new ApplicationException("Couldn't find specified db Sever details"));
});

var app = builder.Build();

// Configure the HTTP request pipeline.

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "CitiesManager.WebAPI v1"));
}

app.UseHttpsRedirection();
app.UseRouting();



app.MapControllers();

app.Run();
