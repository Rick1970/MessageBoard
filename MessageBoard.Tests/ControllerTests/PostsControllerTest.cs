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
    }
}
