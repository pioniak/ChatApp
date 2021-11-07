using Domain;
using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            builder.Property(s => s.Id)
                .UseIdentityColumn();
            builder.Property(s => s.Name)
                .HasMaxLength(Constants.RoomNameMaxLength)
                .IsRequired();
            builder.HasMany(s => s.Participants)
                .WithOne(s => s.Room)
                .HasForeignKey(s => s.RoomId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(s => s.Creator)
                .WithMany()
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
