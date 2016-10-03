using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using MessageBoard.Models;
using MessageBoard.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace MessageBoard.Tests.ControllerTests
{
    public class PostsControllerTest
    {
        [Fact]
        public void Get_ViewResult_Post_Test()
        {
            //Arrange
            PostsController controller = new PostsController()
            {
            };

            //Act
            var result = controller.Index(1);

            //Assert
            Assert.IsType<ViewResult>(result);
        }


        [Fact]
        public void Get_ModelList_Index_Test()
        {
            //Arrange
            PostsController controller = new PostsController();
            IActionResult actionResult = controller.Index(1);
            ViewResult indexView = controller.Index(1) as ViewResult;

            //Act
            var result = indexView.ViewData.Model;

            //Assert
            Assert.IsType<List<Post>>(result);
        }
    }
}
