using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CO659_TeamApp.Models;

namespace CO659_TeamApp.Data
{
    public class PatientContext : DbContext
    {
        public PatientContext (DbContextOptions<PatientContext> options)
            : base(options)
        {
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Practitioner> Practitioners { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>().ToTable("Account");
            modelBuilder.Entity<Practitioner>().ToTable("Practitioner");
        }

        public DbSet<CO659_TeamApp.Models.Patient> Patient { get; set; } = default!;
    }
}
