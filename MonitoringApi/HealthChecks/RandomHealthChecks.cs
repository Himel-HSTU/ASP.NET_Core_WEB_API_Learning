using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace MonitoringApi.HealthChecks
{
    public class RandomHealthChecks : IHealthCheck
    {
        public Task<HealthCheckResult> CheckHealthAsync(HealthCheckContext context, CancellationToken cancellationToken = default)
        {
            int responseTimeInMs = Random.Shared.Next(300);
            // Simulate a health check by generating a random response time between 0 and 300 milliseconds
            // In a real-world scenario, we would perform actual checks here, such as checking database connectivity, external service availability, etc.
            if (responseTimeInMs<100)
            {
                return Task.FromResult(HealthCheckResult.Healthy($"Response time is {responseTimeInMs} ms."));
            }
            else
            {
                return Task.FromResult(HealthCheckResult.Unhealthy($"Response time is {responseTimeInMs} ms."));
            }
        }
    }
}
