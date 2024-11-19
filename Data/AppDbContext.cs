using EmployeeManagement_system.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagement_system.Data
{
    public class AppDbContext: DbContext
    {
        //Constructor
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        //DbSet properties
        public DbSet<Employee> Employees { get; set; }
        public DbSet<PublicHoliday> PublicHolidays { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Seed data for PublicHolidays in Sri Lanka (2024)
            modelBuilder.Entity<PublicHoliday>().HasData(
                // Fixed Holidays
                new PublicHoliday { Id = 1, Date = new DateTime(2024, 01, 01), Description = "New Year's Day" },
                new PublicHoliday { Id = 2, Date = new DateTime(2024, 05, 01), Description = "Labour Day" },
                new PublicHoliday { Id = 3, Date = new DateTime(2024, 07, 09), Description = "Esala Full Moon (Poya Day)" },
                new PublicHoliday { Id = 4, Date = new DateTime(2024, 08, 22), Description = "Nikini Full Moon (Poya Day)" },
                new PublicHoliday { Id = 5, Date = new DateTime(2024, 09, 17), Description = "Binara Full Moon (Poya Day)" },
                new PublicHoliday { Id = 6, Date = new DateTime(2024, 10, 05), Description = "Duruthu Full Moon (Poya Day)" },
                new PublicHoliday { Id = 7, Date = new DateTime(2024, 12, 25), Description = "Christmas Day" },
                new PublicHoliday { Id = 8, Date = new DateTime(2024, 12, 26), Description = "Boxing Day" },

                // Movable Holidays
                new PublicHoliday { Id = 9, Date = new DateTime(2024, 03, 10), Description = "Mawlid al-Nabi (Prophet Muhammad's Birthday)" },
                new PublicHoliday { Id = 10, Date = new DateTime(2024, 04, 21), Description = "Eid ul-Fitr" },
                new PublicHoliday { Id = 11, Date = new DateTime(2024, 06, 28), Description = "Eid ul-Azha" },

                // Poya Days (Full Moon Days)
                new PublicHoliday { Id = 12, Date = new DateTime(2024, 01, 25), Description = "Duruthu Poya" },
                new PublicHoliday { Id = 13, Date = new DateTime(2024, 02, 24), Description = "Navam Poya" },
                new PublicHoliday { Id = 14, Date = new DateTime(2024, 03, 25), Description = "Madin Poya" },
                new PublicHoliday { Id = 15, Date = new DateTime(2024, 04, 24), Description = "Bak Full Moon Poya" },
                new PublicHoliday { Id = 16, Date = new DateTime(2024, 05, 23), Description = "Vesak Poya" },
                new PublicHoliday { Id = 17, Date = new DateTime(2024, 06, 22), Description = "Poson Poya" },
                new PublicHoliday { Id = 18, Date = new DateTime(2024, 07, 22), Description = "Esala Poya" },
                new PublicHoliday { Id = 19, Date = new DateTime(2024, 08, 19), Description = "Nikini Poya" },
                new PublicHoliday { Id = 20, Date = new DateTime(2024, 09, 17), Description = "Binara Poya" },
                new PublicHoliday { Id = 21, Date = new DateTime(2024, 10, 05), Description = "Duruthu Poya" },
                new PublicHoliday { Id = 22, Date = new DateTime(2024, 11, 15), Description = "Ill Full Moon Poya" },
                new PublicHoliday { Id = 23, Date = new DateTime(2024, 12, 12), Description = "Unduvap Poya" }
            );
        }
    }
}
