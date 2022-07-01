using CompanyName.ProjectName.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CompanyName.ProjectName.Configurations
{
    public class Entity1Configuration : BaseEntityConfiguration<Entity1>
    {
        public override void Configure(EntityTypeBuilder<Entity1> builder)
        {
            base.Configure(builder);

            builder.Property(x => x.Name);
        }
    }
}
