using CompanyName.ProjectName.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CompanyName.ProjectName.Configurations
{
    public class BaseEntityUpdatedConfiguration<T> : BaseEntityCreatedConfiguration<T>
        where T : BaseEntityUpdated
    {
        public override void Configure(EntityTypeBuilder<T> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.UpdatedOn);
            builder.Property(x => x.UpdatedById).HasColumnName("UpdatedBy");
        }
    }
}
