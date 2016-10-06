using Microsoft.AspNetCore.Mvc;
using MessageBoard.ViewModels;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MessageBoard.Models;
using Microsoft.AspNetCore.Authorization;
using System;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MessageBoard.Controllers
{
    public class DeedsController : Controller
    {
        private MessageBoardDbContext db = new MessageBoardDbContext();
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult RandomDeedSelector(int count)
        {
            var randomDeed = db.Deeds.OrderBy(r => Guid.NewGuid()).Take(count);
            return Json(randomDeed);
        }
    }
}
