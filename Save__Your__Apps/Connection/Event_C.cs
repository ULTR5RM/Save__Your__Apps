using Microsoft.EntityFrameworkCore;
using Save__Your__Apps.Models;

namespace Save__Your__Apps.Connection
{
    public class Event_C : DbContext
    {
        public DbSet<Event> Events { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(DBconnect.Configuration.GetConnectionString("EventsDBConnection"));
        }
    }
}
