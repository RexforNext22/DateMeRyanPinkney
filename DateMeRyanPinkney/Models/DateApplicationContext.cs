using System;
using Microsoft.EntityFrameworkCore;
namespace DateMeRyanPinkney.Models
{
    public class DateApplicationContext : DbContext
    {

        // Constructor
        public DateApplicationContext (DbContextOptions<DateApplicationContext> options) : base (options)
        {
            // Leave blank for now
        }

        public DbSet<Application> responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Application>().HasData(

                new Application
                {
                    Application_id = 1,
                    sFirstName = "Sarah",
                    sLastName = "Fox",
                    iAge = 24,
                    sMajor = "Civil Engineering",
                    bIsStocker = false
                },
                new Application
                {
                    Application_id = 2,
                    sFirstName = "Maddie",
                    sLastName = "Rosenberg",
                    iAge = 23,
                    sMajor = "Humanities",
                    bIsStocker = false
                }

                ); 
        }

    }
}
