using Microsoft.EntityFrameworkCore;
using OnPaceRaceAdmin.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace OnPaceRaceAdmin.Data
{
    public class AdminContext :DbContext
    {
        public DbSet<Runner> Runners { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<State> States { get; set; }


        public AdminContext(DbContextOptions<AdminContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Runner>().ToTable("Runner");
            modelBuilder.Entity<Gender>().ToTable("Gender");
            modelBuilder.Entity<State>().ToTable("States");

        }
    }
}
