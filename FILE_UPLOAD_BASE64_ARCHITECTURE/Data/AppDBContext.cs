using FILE_UPLOAD_BASE64_ARCHITECTURE.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace FILE_UPLOAD_BASE64_ARCHITECTURE.Data
{
    public class AppDBContext: DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options) { }

        public DbSet<Blog> Blogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            //modelBuilder.Entity<Slider>().HasQueryFilter(m => !m.SoftDeleted);


             base.OnModelCreating(modelBuilder);
        }
    }
}
