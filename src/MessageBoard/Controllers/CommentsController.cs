﻿using Microsoft.AspNetCore.Mvc;
using MessageBoard.ViewModels;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using MessageBoard.Models;
using Microsoft.AspNetCore.Authorization;

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

            return View(db.Comments.Include(comments => comments.Post).ToList());


        }
        [Authorize]
        public ActionResult Create(int id)
        {
            ViewBag.PostId = new SelectList(db.Posts, "PostId", "Title");
            return View();
        }
        [HttpPost]
        public ActionResult Create(Comment comment)
        {
            if (ModelState.IsValid)
            {
                db.Comments.Add(comment);
                db.SaveChanges();
                return RedirectToAction("../posts");
            }
            return View();
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
