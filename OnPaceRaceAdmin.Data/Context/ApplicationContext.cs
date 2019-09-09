using Microsoft.EntityFrameworkCore;

namespace OnPaceRaceAdmin.Data
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Runner> Runners { get; set; }
        public DbSet<Gender> Genders { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<RunnerNote> RunnerNotes { get; set; }
        public DbSet<ClothingSize> ClothingSizes { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<RacePace> RacePaces { get; set; }
        public DbSet<RaceType> RaceTypes { get; set; }


        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Runner>().ToTable("Runner");
            modelBuilder.Entity<Gender>().ToTable("Gender");
            modelBuilder.Entity<State>().ToTable("States");
            modelBuilder.Entity<RunnerNote>().ToTable("RunnerNote");
            modelBuilder.Entity<ClothingSize>().ToTable("ClothingSize");
            modelBuilder.Entity<Race>().ToTable("Race");
            modelBuilder.Entity<RacePace>().ToTable("RacePace");
            modelBuilder.Entity<RaceType>().ToTable("RaceType");
        }
    }
}
