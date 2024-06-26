using FILE_UPLOAD_BASE64_ARCHITECTURE.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FILE_UPLOAD_BASE64_ARCHITECTURE.Helpers.EntityConfiguration
{
    public class BlogCofiguration : IEntityTypeConfiguration<Blog>
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.Property(m => m.Title).IsRequired().HasMaxLength(50);
            builder.Property(m => m.Desc).IsRequired().HasMaxLength(50);
            builder.Property(m => m.Image).IsRequired();
        }
    }
}
