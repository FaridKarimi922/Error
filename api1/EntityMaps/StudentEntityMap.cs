using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TaavSchool.Entitis.Entitis;

namespace api1.EntityMaps
{
    public class StudentEntityMap : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.Property(_ => _.FirstName).HasMaxLength(50).IsRequired();
            builder.Property(_ => _.LastName).HasMaxLength(50).IsRequired();
            builder.Property(_ => _.Latitude).HasColumnName("Lat");
            builder.Property(_ => _.Longitude).HasColumnName("Long");






        }
    }
}
