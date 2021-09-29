using Microsoft.EntityFrameworkCore;

namespace EF_Database.models
{
    public class MyBlogContext : DbContext
    {
        public MyBlogContext(DbContextOptions<MyBlogContext> options) : base(options)
        {
        }
        protected override void OnConfiguring (DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuiler)
        {
            base.OnModelCreating(modelBuiler);
        }

        public DbSet<Article> articles {get; set;}
    }
}