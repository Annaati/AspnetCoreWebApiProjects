using dotNETPosgresAPI.Services.Heplers;
using dotNETPosgresAPI.Services.Interfaces;
using dotNETPosgresAPI.Services;
using dotNETPosgresAPI.Filters;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddHttpContextAccessor();
builder.Services.AddSingleton<FileUploadHelper>();


builder.Services.AddScoped<IAccountService, AccountService>();

builder.Services.AddMvc(options =>
{
    options.Filters.Add<JsonExceptionFilter>();
    //options.Filters.Add<RequireHttpsOrCloseAttribute>();
});

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(c =>
{
    c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHsts();
//app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseCors(options => options.AllowAnyOrigin().AllowAnyMethod().AllowAnyHeader());

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
