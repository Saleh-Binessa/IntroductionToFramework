using Microsoft.EntityFrameworkCore;

namespace IntroductionToFramework.Models
{
    public class BlogContext : DbContext
    {
        public DbSet<Blog> blogs { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Blog>().HasData(
                new Blog
                {
                    Id = 1,
                    Name = "w3School",
                    Url = "https://www.w3schools.com/"
                },
                new Blog 
                { 
                    Id = 2, 
                    Name = "Tech Trends", 
                    Url = "https://techtrends.com" 
                },
            new Blog 
                { 
                    Id = 3, 
                    Name = "Health News", 
                    Url = "https://healthnews.com" },
            new Blog
            {
                Id = 4,
                Name = "Travel Chronicles",
                Url = "https://travelchronicles.com"
            });
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=asb.db");
        }
    }
}
