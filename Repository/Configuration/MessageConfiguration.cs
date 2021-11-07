using Domain;
using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    class MessageConfiguration : IEntityTypeConfiguration<Message>
    {
        public void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.Property(s => s.Id)
                .UseIdentityColumn();
            builder.Property(s => s.Content)
                .IsRequired()
                .HasMaxLength(Constants.MessageContentMaxLength)
                .IsUnicode();
            builder.Property(s => s.SendTimestamp)
                .ValueGeneratedOnAdd()
                .HasDefaultValueSql("getDate()");
            builder.HasOne(s => s.Sender)
                .WithMany()
                .HasForeignKey(s => s.SenderId)
                .OnDelete(DeleteBehavior.NoAction);
        }
    }
}
