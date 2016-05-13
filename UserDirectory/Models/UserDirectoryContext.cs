using System.Data.Entity;

namespace UserDirectory.Models
{
    public class UserDirectoryContext : DbContext
    {  
        public UserDirectoryContext() : base("name=UserDirectoryContext")
        {
        }

        public DbSet<User> Users { get; set; }
    }
}
