using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Xaero.DataLayer.Entities;

namespace Xaero.DataLayer.Mappers
{
    public class StudentMapper : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.ToTable("tbl_Students");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Address)
                   .HasMaxLength(250);
            builder.Property(x => x.Age)
                   .IsRequired();
            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasMaxLength(25);
        }
    }
}
