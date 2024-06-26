using Domain1.Common;
using Domain1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Domain1.Configuration
{
    public class BaseConfiguration : IEntityTypeConfiguration<BaseEntity>
    {
        public void Configure(EntityTypeBuilder<BaseEntity> builder)
        {
            builder.Property(m => m.SoftDelete).HasDefaultValue(false);
            builder.Property(m => m.CreateDate).HasDefaultValue(DateTime.Now);

        }
    }
}
