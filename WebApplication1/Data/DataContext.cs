using Microsoft.EntityFrameworkCore;
using WebApplication1.Entity;


namespace WebApplication1.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions option):base(option)
        {
            
        }
        public DbSet<AppUser> Users {  get; set; }
    }
}