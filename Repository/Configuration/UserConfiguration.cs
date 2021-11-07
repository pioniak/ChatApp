using Domain;
using Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(s => s.Id)
                .UseIdentityColumn();
            builder.Property(s => s.Login)
                .IsRequired()
                .HasMaxLength(Constants.UserLoginMaxLength);
            builder.Property(s => s.FullName)
                .IsRequired()
                .HasMaxLength(Constants.UserFullNameMaxLength);
            builder.HasIndex(s => s.Login).IsUnique();
        }
    }
}
