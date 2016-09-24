using Microsoft.AspNetCore.Mvc;
using MessageBoard.Models;
using System.Linq;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MessageBoard.Controllers
{
    public class PostsController : Controller
    {
        private MessageBoardDbContext db = new MessageBoardDbContext();
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(db.Posts.ToList());
        }
        public IActionResult Details(int id)
        {
            var thisPost = db.Posts.FirstOrDefault(posts => posts.PostId == id);
            return View(thisPost);

        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Post post)
        {
            db.Posts.Add(post);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
