using CompanyName.ProjectName.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CompanyName.ProjectName.Configurations
{
    public class BaseEntityCreatedConfiguration<T> : BaseEntityConfiguration<T>
        where T : BaseEntityCreated
    {
        public override void Configure(EntityTypeBuilder<T> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.CreatedOn);
            builder.Property(x => x.CreatedById).HasColumnName("CreatedBy");
        }
    }
}
