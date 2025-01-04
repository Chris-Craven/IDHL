using DeveloperAssessment.Web.Models;

namespace DeveloperAssessment.Web.Infrastructure.Services;

public interface IBlogService
{
    public BlogPost GetBlogPostById(int id);
    public List<BlogPost> GetAllBlogPosts();
    public void AddComment(CreateCommentViewModel commentViewModel);
    public void AddReply(CreateReplyViewModel replyViewModel);
}