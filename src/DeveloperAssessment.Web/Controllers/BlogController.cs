using DeveloperAssessment.Web.Infrastructure.Services;
using DeveloperAssessment.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace DeveloperAssessment.Web.Controllers;

public class BlogController : Controller
{
    private readonly IBlogService _blogService;

    public BlogController(IBlogService blogService)
    {
        _blogService = blogService;
    }

    public ActionResult BlogDetails(int id)
    {
        var blogPost = _blogService.GetBlogPostById(id);
        return View("BlogDetails", blogPost);
    }

    public ActionResult GetAllBlogs()
    {
        var blogPosts = _blogService.GetAllBlogPosts();
        return View(blogPosts);
    }

    [HttpPost]
    public ActionResult AddComment(CreateCommentViewModel commentViewModel )
    {
        if(ModelState.IsValid)
        {
            _blogService.AddComment(commentViewModel);
        }
        
        var blogPost = _blogService.GetBlogPostById(commentViewModel.BlogId);
        
        return View("BlogDetails", blogPost);
    }
    
    public ActionResult AddReply(CreateReplyViewModel replyViewModel)
    {
        if(ModelState.IsValid)
        {
            _blogService.AddReply(replyViewModel);
        }
        
        var blogPost = _blogService.GetBlogPostById(replyViewModel.BlogId);
        
        return View("BlogDetails", blogPost);
    }
}