using Microsoft.AspNetCore.Mvc;
using MessageBoard.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MessageBoard.Controllers
{
    public class CommentsController : Controller
    {
        private MessageBoardDbContext db = new MessageBoardDbContext();
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(db.Comments.Include(comments => comments.Post).ToList());
        }
        public IActionResult Details(int id)
        {
            var thisComment = db.Comments.FirstOrDefault(comments => comments.CommentId == id);
            return View(thisComment);

        }
        public IActionResult Create()
        {
            ViewBag.PostsId = new SelectList(db.Posts, "PostId", "Response");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Comment comment)
        {
            db.Comments.Add(comment);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var thisComment = db.Comments.FirstOrDefault(comments => comments.CommentId == id);
            ViewBag.PostId = new SelectList(db.Posts, "PostId", "Response");
            return View(thisComment);
        }

        [HttpPost]
        public IActionResult Edit(Comment comment)
        {
            db.Entry(comment).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var thisComment = db.Comments.FirstOrDefault(comments => comments.CommentId == id);
            return View(thisComment);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var thisComment = db.Comments.FirstOrDefault(comments => comments.CommentId == id);
            db.Comments.Remove(thisComment);
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
