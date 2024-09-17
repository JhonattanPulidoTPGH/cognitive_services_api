using Microsoft.Extensions.Options;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("grammar_checker", new OpenApiInfo
    {
        Title = "StoryfAI | Grammar Checker",
        Version = "v2",
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
        Contact = new OpenApiContact
        {
            Name = "Jhonattan Pulido - Backend Developer",
            Url = new Uri("mailto:pulidoarenas.7@nlsa.teleperformance.com?Subject=Grammar%20Checker%20API%20-%20v2")
        }
    });
    c.SwaggerDoc("personally_identifiable_information", new OpenApiInfo
    {
        Title = "StoryfAI | Personally Identifiable Information",
        Version = "v2",
        Description = "Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.",
        Contact = new OpenApiContact
        {
            Name = "Jhonattan Pulido - Backend Developer",
            Url = new Uri("mailto:pulidoarenas.7@nlsa.teleperformance.com?Subject=Personally%20Identifiable%20Information%20API%20-%20v2")
        }
    });
    
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    c.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/grammar_checker/swagger.json", "Grammar Checker");
        c.SwaggerEndpoint("/swagger/personally_identifiable_information/swagger.json", "Personally Identifiable Information");
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
