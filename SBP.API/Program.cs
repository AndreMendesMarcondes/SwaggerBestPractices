using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen(options =>
{
    options.EnableAnnotations();
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Student API",
        Description = "A sample of a Student API and best practices for swagger",
        TermsOfService = new Uri("https://www.betalearning.com.br"),
        Contact = new OpenApiContact
        {
            Name = "Student API Contact",
            Url = new Uri("https://www.betalearning.com.br/")
        },
        License = new OpenApiLicense
        {
            Name = "Student API License",
            Url = new Uri("https://www.betalearning.com.br/")
        }
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
