using DairyApp.Models;
using Microsoft.EntityFrameworkCore;

namespace DairyApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        { 
            
        }

        public DbSet<DiaryEntry> DiaryEntries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry { 
                    Id = 1, 
                    Title = "Went Hiking", 
                    Content = "Went Hiking With Jao", 
                    CreatedAt = DateTime.Now 
                },
                new DiaryEntry { 
                    Id = 2, 
                    Title = "Went Shopping", 
                    Content = "Went Shopping With Jao", 
                    CreatedAt = DateTime.Now 
                },
                new DiaryEntry 
                { 
                    Id = 3, Title = "Went Drivind", 
                    Content = "Went Driving With Jao", 
                    CreatedAt = DateTime.Now 
                }
                );
        }
    }
}
