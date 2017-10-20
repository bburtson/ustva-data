using Microsoft.EntityFrameworkCore;

namespace USTVA.Data
{
    public partial class IncidentDbContext : DbContext
    {
        public virtual DbSet<Driver> Drivers { get; set; }
        public virtual DbSet<Incident> Incidents { get; set; }
        public virtual DbSet<Vehicle> Vehicles { get; set; }
        public virtual DbSet<Violation> Violations { get; set; }

        public IncidentDbContext(DbContextOptions options) : base(options) { }

        public IncidentDbContext(string connectionString) : base(BuildDefaultOptions(connectionString)) { }

        private static DbContextOptions BuildDefaultOptions(string connectionString)
        {
            return new DbContextOptionsBuilder().UseSqlServer(connectionString).Options;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Incident>(entity =>
            {
                entity.HasKey(e => e.IncidentId);

                entity.HasIndex(e => e.DriverId);

                entity.HasIndex(e => e.VehicleId);

                entity.HasIndex(e => e.ViolationId);

                entity.Property(e => e.Latitude).HasColumnType("decimal(15, 13)");

                entity.Property(e => e.Longitude).HasColumnType("decimal(15, 13)");

                entity.HasOne(d => d.Driver).WithOne(p => p.Incident);

                entity.HasOne(d => d.Vehicle).WithOne(p => p.Incident);

                entity.HasOne(d => d.Violation).WithOne(p => p.Incident);
            });

            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.Property(p => p.VehicleType).HasColumnName("Type");

                entity.ToTable("Vehicle");
            });

            modelBuilder.Entity<Driver>().ToTable("Driver");

            modelBuilder.Entity<Violation>().ToTable("Violation");
        }
    }
}
