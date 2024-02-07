using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaavSchool.Entitis.Entitis;

namespace api1.EntityMaps
{
    public class GroupManagerEntityMap : IEntityTypeConfiguration<GroupManager>
    {
        public void Configure(EntityTypeBuilder<GroupManager> builder)
        {
            builder.HasOne(_ => _.Group)
                .WithOne(_ => _.GroupManager)
                .HasForeignKey<GroupManager>(_ => _.Id)
                .IsRequired();
        }
    }
}
