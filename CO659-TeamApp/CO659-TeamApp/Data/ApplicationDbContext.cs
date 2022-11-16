using CO659_TeamApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CO659_TeamApp.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Symptom> Symptoms { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Practitioner> Practitioners { get; set; }
        public DbSet<Medicine> Medicines { get; set; }

    }
}