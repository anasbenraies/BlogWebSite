


using Blog.Controllers.Data;
using BlogWebSite.Models;
using Microsoft.AspNetCore.Mvc;
namespace Blog.Controllers
{
    public class PostsController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public PostsController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            var Result = dbContext.Posts.ToList();
            return View(Result);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Post model)
        {
            if(ModelState.IsValid)
            {
                dbContext.Posts.Add(model);
                dbContext.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();
        }


    }
}
