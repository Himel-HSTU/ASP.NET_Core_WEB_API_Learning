using MonitoringApi.HealthChecks;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using HealthChecks.UI.Client;
var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

//builder.Services.AddOpenApi();
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHealthChecks()
    .AddCheck<RandomHealthChecks>("Overall Health Check")
    .AddCheck<DBHealthChecks>("Database Health Check");

// In this way when we have multiple health checks, we can add them with different names to identify which one is failing or degraded.
// Otherwise this will take the worst case and show only that.
// Example : If we have 3 health checks and 2 of them are healthy and 1 is degraded, then the overall health check will be degraded. But if we add them with different names, then we can see which one is degraded and which one is healthy.

builder.Services.AddHealthChecksUI(opt =>
{
    opt.AddHealthCheckEndpoint("Overall Health Check", "/health");
    opt.AddHealthCheckEndpoint("Database Health Check", "/health");
    opt.SetEvaluationTimeInSeconds(5); //time in seconds between check
    // normally industry standard is 1 minute but for demo purpose to see changes instant we will keep it 5 seconds
    opt.SetMinimumSecondsBetweenFailureNotifications(10); //time in seconds between failure notifications
    // Whenever a health check fails or Unhealthy, it will send a notification after 10 seconds. Industry standard is 5-10 minutes,cz we need time to debug and react,otherwise databse will be flooded with notifications... But for demo purpose to see changes instant we will keep it 10 seconds
}).AddInMemoryStorage(); // we can use any storage provider like SQL Server, PostgreSQL, MySQL, etc. but for demo purpose we will use InMemoryStorage, On every restart of the application, the health check history will be lost.

var app = builder.Build();


if (!app.Environment.IsDevelopment())
{ 
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}
else
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapHealthChecks("/health", new HealthCheckOptions
{
    ResponseWriter = UIResponseWriter.WriteHealthCheckUIResponse
});
app.MapHealthChecksUI();
app.Run();


// Xabaril HealthChecks: A collection of ready-made health checks for databases, Redis, external APIs, etc.
// Useful for monitoring application dependencies, dashboards, notifications, and production health monitoring.
// https://github.com/Xabaril/AspNetCore.Diagnostics.HealthChecks