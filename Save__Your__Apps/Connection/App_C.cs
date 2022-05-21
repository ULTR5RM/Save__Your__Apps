using Microsoft.EntityFrameworkCore;
using Save__Your__Apps.Models;

namespace Save__Your__Apps.Connection
{
    public class App_C : DbContext
    {
        public DbSet<App> Apps { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(DBconnect.Configuration.GetConnectionString("AppsDBConnection"));
        }
    }
}
