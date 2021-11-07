using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Repository;
using System.Configuration;

namespace ChatApi.Helpers
{
    public static class Extensions
    {
        public static void AddChatContext(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ChatContext>(options=> options.UseSqlServer(connectionString));
        }
    }
}
