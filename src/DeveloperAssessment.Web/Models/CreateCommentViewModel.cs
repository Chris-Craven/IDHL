namespace DeveloperAssessment.Web.Models;

public class CreateCommentViewModel
{
    public int BlogId { get; set; }
    public string Name { get; set; }
    public string EmailAddress { get; set; }
    public string Message { get; set; }
    public IFormFile File { get; set; }
}