using Microsoft.AspNetCore.Mvc;
using MessageBoard.ViewModels;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MessageBoard.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MessageBoard.Controllers
{
    public class PostsController : Controller
    {
        private MessageBoardDbContext db = new MessageBoardDbContext();
        // GET: /<controller>/
        public IActionResult Index(int id)
        {
           
            return View(db.Posts.Include(posts => posts.Comments).ToList());

        }


        public IActionResult Details(int id)
        {
            var model = new PostsViewModel();
            model.Posts = db.Posts.FirstOrDefault(post => post.PostId == id);
            model.Comments = db.Comments.Include(comments => comments.Post).Where(posts => posts.PostId == id).ToList();
            return View(model);
         }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Post post)
        {
            if (ModelState.IsValid) {
                db.Posts.Add(post);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Edit(int id)
        {
            var thisPost = db.Posts.FirstOrDefault(items => items.PostId == id);
            return View(thisPost);
        }

        [HttpPost]
        public IActionResult Edit(Post post)
        {
            db.Entry(post).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var thisPost = db.Posts.FirstOrDefault(posts => posts.PostId == id);
            return View(thisPost);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisPost = db.Posts.FirstOrDefault(posts => posts.PostId == id);
            db.Posts.Remove(thisPost);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
