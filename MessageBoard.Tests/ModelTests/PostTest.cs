using MessageBoard.Models;
using Xunit;

namespace MessageBoard.Tests.ModelTests
{
    public class PostTest
    {

        [Fact]
        public void PostTitleTest()
        {
            //arrange
            var post = new Post()
            { Title = "Test" };

            //act
            var result = post.Title;

            //assert
            Assert.Equal("Test", result);
        }
    }
}
