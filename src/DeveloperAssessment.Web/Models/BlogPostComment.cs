using System.ComponentModel.DataAnnotations;

namespace DeveloperAssessment.Web.Models;

public class BlogPostComment
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public DateTime Date { get; set; }
    public string? EmailAddress { get; set; }
    public string? Message { get; set; }
    
    public string? ImageUrl { get; set; }
    public List<BlogPostReply>? BlogPostReplies { get; set; }
}