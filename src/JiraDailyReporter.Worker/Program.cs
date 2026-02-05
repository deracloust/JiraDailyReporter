using JiraDailyReporter.Worker;
using JiraDailyReporter.Infrastructure.Jira;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddOptions<JiraConfiguration>()
    .Bind(builder.Configuration)
    .ValidateDataAnnotations()
    .ValidateOnStart();

builder.Services.AddHostedService<Worker>();

var host = builder.Build();
host.Run();
