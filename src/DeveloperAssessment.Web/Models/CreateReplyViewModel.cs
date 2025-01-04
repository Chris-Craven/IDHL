namespace DeveloperAssessment.Web.Models;

public class CreateReplyViewModel
{
    public int BlogId { get; set; }
    public Guid CommentId { get; set; }
    public string Name { get; set; }
    public string EmailAddress { get; set; }
    public string Message { get; set; }
}