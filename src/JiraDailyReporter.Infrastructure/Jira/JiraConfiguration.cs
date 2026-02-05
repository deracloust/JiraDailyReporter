using System.ComponentModel.DataAnnotations;

namespace JiraDailyReporter.Infrastructure.Jira;

public class JiraConfiguration
{
    [Required(ErrorMessage = "Jira BaseUrl is required")]
    [Url(ErrorMessage = "Jira BaseUrl must be a valid URL")]
    public string BaseUrl { get; set; } = Environment.GetEnvironmentVariable("JIRA_BASE_URL") ?? string.Empty;

    [Required(ErrorMessage = "Jira Email is required")]
    [EmailAddress(ErrorMessage = "Jira Email must be a valid email address")]
    public string Email { get; set; } = Environment.GetEnvironmentVariable("JIRA_EMAIL") ?? string.Empty;

    [Required(ErrorMessage = "Jira API Token is required")]
    [MinLength(1, ErrorMessage = "Jira API Token cannot be empty")]
    public string ApiToken { get; set; } = Environment.GetEnvironmentVariable("JIRA_API_TOKEN") ?? string.Empty;

    [Required(ErrorMessage = "Jira Project Key is required")]
    [MinLength(1, ErrorMessage = "Jira Project Key cannot be empty")]
    public string ProjectKey { get; set; } = Environment.GetEnvironmentVariable("JIRA_PROJECT_KEY") ?? string.Empty;
}
