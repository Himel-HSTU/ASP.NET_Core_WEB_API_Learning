
using Microsoft.OpenApi;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddOpenApi();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    var title = "Our Versioned API";
    var description = "This is a sample API for demonstrating API versioning in ASP.NET Core.";
    var termsOfService = new Uri("https://localhost:7219/terms");
    var license = new OpenApiLicense(){
    Name = "pcBhai @License",
    Url = new Uri("https://opensource.org/licenses/MIT")
};
    var contact = new OpenApiContact()
    {
        Name = "pcBhai",
        Email = "mdhabiburrahmanhimel27@gmail.com"
    };
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = $"{title} v1.0",
        Description = description,
        TermsOfService = termsOfService,
        License = license,
        Contact = contact
    });
    options.SwaggerDoc("v2", new OpenApiInfo
    {
        Version = "v2",
        Title = $"{title} v2.0",
        Description = description,
        TermsOfService = termsOfService,
        License = license,
        Contact = contact
    });
    options.SwaggerDoc("v3", new OpenApiInfo
    {
        Version = "v3",
        Title = $"{title} v3.0",
        Description = description,
        TermsOfService = termsOfService,
        License = license,
        Contact = contact
    });
} );



builder.Services.AddApiVersioning(options =>
{
    options.AssumeDefaultVersionWhenUnspecified = true;
    options.DefaultApiVersion = new ApiVersion(1, 0);
    options.ReportApiVersions = true;
});
//.AddMvc()
//.AddApiExplorer(options =>
//{
//    options.GroupNameFormat = "'v'VVV";
//    options.SubstituteApiVersionInUrl = true;
//}); 

builder.Services.AddVersionedApiExplorer(options =>
{
    options.GroupNameFormat = "'v'VVV";
    options.SubstituteApiVersionInUrl = true;       
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(options =>
    {
        options.SwaggerEndpoint("/swagger/v3/swagger.json", "Version 3.0");
        options.SwaggerEndpoint("/swagger/v2/swagger.json", "Version 2.0");
        options.SwaggerEndpoint("/swagger/v1/swagger.json", "Version 1.0");
        
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
