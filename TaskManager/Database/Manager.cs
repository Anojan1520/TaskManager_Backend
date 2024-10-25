using Microsoft.EntityFrameworkCore;
using TaskManager.Models;

namespace TaskManager.Database
{
    public class Manager : DbContext
    {
        public Manager(DbContextOptions<Manager> Options) : base(Options) 
        {
            
        }
        public DbSet<TaskItem> Tasks { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
