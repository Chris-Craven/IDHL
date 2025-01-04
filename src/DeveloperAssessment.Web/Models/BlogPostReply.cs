namespace DeveloperAssessment.Web.Models;

public class BlogPostReply
{
    public Guid BlogPostCommentId { get; set; }
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public DateTime Date { get; set; }
    public string? EmailAddress { get; set; }
    public string? Message { get; set; }
}