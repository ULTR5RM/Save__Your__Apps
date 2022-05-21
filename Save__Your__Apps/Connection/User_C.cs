using Microsoft.EntityFrameworkCore;
using Save__Your__Apps.Models;

namespace Save__Your__Apps.Connection
{
    public class User_C : DbContext
    {
        public DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(DBconnect.Configuration.GetConnectionString("UsersDBConnection").ToString());
        }
    }
}
