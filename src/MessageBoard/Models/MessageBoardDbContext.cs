using BasicAuthentication.Models;
using MessageBoard.ViewModels;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MessageBoard.Models
{
    public class MessageBoardDbContext : IdentityDbContext<User>
    {

        public MessageBoardDbContext(DbContextOptions<MessageBoardDbContext> options)
           : base(options)
        {
        }

        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }

       

        public MessageBoardDbContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=MessageBoard;integrated security=True");
        }
    }
}
