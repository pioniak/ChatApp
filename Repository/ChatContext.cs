using Domain.Model;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Repository
{
    public class ChatContext: DbContext
    {
        public ChatContext(DbContextOptions<ChatContext> options): base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Message> Messages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

    }
}
