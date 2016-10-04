using Microsoft.AspNetCore.Mvc;
using MessageBoard.ViewModels;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using MessageBoard.Models;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MessageBoard.Controllers
{
    public class DeedsController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
    }
}
