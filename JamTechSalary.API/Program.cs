using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("amTechSalaryDb");
builder.Services.AddDbContext<JamTechSalaryDbContext>(options => options.UseSqlServer(connectionString));

builder.Services.AddControllers();

builder.Services.AddSwaggerGen(options => {
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "JamTechSalary.API",
        Description = "An ASP.NET Core Web API for managing salary information for the Jamaican Tech Market"
    });

} );

builder.Services.AddCors(options => options.AddPolicy("AllowAll", policy => {
    policy.AllowAnyOrigin()
          .AllowAnyMethod()
          .AllowAnyHeader();
}));

var app = builder.Build();

if (app.Environment.IsDevelopment()){}

app.UseHttpsRedirection();

app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();
