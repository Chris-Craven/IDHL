using System.Diagnostics;
using DeveloperAssessment.Web.Infrastructure.Services;
using Microsoft.AspNetCore.Mvc;
using DeveloperAssessment.Web.Models;

namespace DeveloperAssessment.Web.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IBlogService _blogService;

    public HomeController(ILogger<HomeController> logger, IBlogService blogService)
    {
        _logger = logger;
        _blogService = blogService;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }
    
    public IActionResult Blogs()
    {
        var blogPosts = _blogService.GetAllBlogPosts();

        foreach (var post in blogPosts)
        {
            switch (post.Id)
            {
                case 1:
                    post.Image = "https://images.freeimages.com/image/previews/a1a/study-kit-flat-png-design-5690859.png";
                    break;
                case 2:
                    post.Image = "data:image/png;base64,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";
                    break;
                case 3:
                    post.Image = "https://growcreate.co.uk/media/mhhj4g3t/kentico-partner-logo.svg?rmode=min&width=1280&quality=90&v=1d8fb4081d617c0";
                    break;
                default:
                    post.Image = "https://www.freeimages.com/clipart/study-kit-flat-png-design-5690859";
                    break;
            }
        }
        
        return View(blogPosts);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
