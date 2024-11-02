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
        public DbSet<CheckList> CheckLists { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .HasOne(a => a.Address)
                .WithOne(u => u.User)
                .HasForeignKey<Address>(u => u.UserId);
            modelBuilder.Entity<User>()
                .HasMany(a => a.Task)
                .WithOne(u => u.Assignee)
                .HasForeignKey(u => u.AssigneeId);

            modelBuilder.Entity<TaskItem>()
                .HasMany(c => c.CheckList)
                .WithOne(t => t.TaskItem)
                .HasForeignKey(t => t.TaskId);

            base.OnModelCreating(modelBuilder);
        }
    }
}
