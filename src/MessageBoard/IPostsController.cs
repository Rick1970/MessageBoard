using MessageBoard.Models;
using Microsoft.AspNetCore.Mvc;

namespace MessageBoard.Controllers
{
    public interface IPostsController
    {
        IActionResult Create();
        IActionResult CreateComment();
        IActionResult Create(Post post);
        IActionResult CreateComment(Models.Comment comment);
        IActionResult Delete(int id);
        IActionResult DeleteComment(int id);
        IActionResult DeleteConfirmed(int id);
        IActionResult DeleteCommentConfirmed(int id);
        IActionResult Details(int id);
        IActionResult DetailsComment(int id);
        IActionResult Edit(Post post);
        IActionResult EditComment(Post post);
        IActionResult Edit(int id);
        IActionResult EditComment(int id);
        IActionResult Index();
        IActionResult Index2();
    }
}