using Microsoft.EntityFrameworkCore;

namespace RazorPage.Models
{
    public class UserContext : DbContext
    {

        public UserContext(DbContextOptions opt) : base(opt)
        {
            
        }
        
        public DbSet<User> Users { get; set; }
        
    }
}