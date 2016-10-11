using Microsoft.AspNetCore.Mvc;
using System.Linq;
using MessageBoard.Models;
using System;
using Hangfire;

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
        public IActionResult RandomDeedSelector()
        {
            var randomDeed = db.Deeds.OrderBy(r => Guid.NewGuid()).Take(1);
            return Json(randomDeed);
        }
    }

}

