using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using MangementSystemStudium.Models;

namespace MangementSystemStudium.Data
{
    // Upgraded from DbContext to IdentityDbContext to support users, passwords, and roles
    public class ApplicationDbContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationDbContext() : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        // Your existing stadium events table
        public DbSet<Event> Events { get; set; }
        public DbSet<TicketBooking> Bookings { get; set; }
    }
}