using JiraDailyReporter.Infrastructure.Jira;
using Microsoft.Extensions.Options;

namespace JiraDailyReporter.Worker
{
    public class Worker : BackgroundService
    {
        private readonly ILogger<Worker> _logger;
        private readonly JiraConfiguration _jiraConfig;

        public Worker(ILogger<Worker> logger, IOptions<JiraConfiguration> options)
        {
            _logger = logger;
            _jiraConfig = options.Value;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                if (_logger.IsEnabled(LogLevel.Information))
                {
                    _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now);
                }
                await Task.Delay(5000, stoppingToken);
            }
        }
    }
}
