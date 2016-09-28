using System.Collections.Generic;
using MessageBoard.Models;


namespace MessageBoard.ViewModels
{
    public class PostsViewModel
    {
        public Post Posts { get; set; }
        public IEnumerable<Comment> Comments { get; set; }

      

       
    }
}