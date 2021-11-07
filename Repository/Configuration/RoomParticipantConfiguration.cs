using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class RoomParticipantConfiguration : IEntityTypeConfiguration<RoomParticipant>
    {
        public void Configure(EntityTypeBuilder<RoomParticipant> builder)
        {
            builder.Property(s => s.Id)
                .UseIdentityColumn();
            builder.Property(s => s.IsAdmin)
                .HasDefaultValue(false);
            builder.HasOne(s => s.User)
                .WithMany()
                .HasForeignKey(s => s.UserId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
