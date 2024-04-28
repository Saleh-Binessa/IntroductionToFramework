using IntroductionToFramework.Models;
using Microsoft.AspNetCore.Mvc;

namespace IntroductionToFramework.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            var db = new BlogContext();
            return View(db.blogs.ToList());
        }
    }
}
