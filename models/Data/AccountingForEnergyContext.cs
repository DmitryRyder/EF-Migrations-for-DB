using Microsoft.EntityFrameworkCore;


namespace models.Data
{
    public class AccountingForEnergyContext : DbContext
    {
        public AccountingForEnergyContext(DbContextOptions<AccountingForEnergyContext> options) : base(options) { }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Type_of_room> Type_of_rooms { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Organization> Organizations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Room>()
                .HasOne(p => p.Building)
                .WithMany(t => t.rooms)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Room>()
                .HasOne(p => p.TypeOfRoom)
                .WithMany(t => t.rooms)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Room_rental>()
                .HasOne(p => p.Room)
                .WithMany(t => t.Room_rentals)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Room_rental>()
                .HasOne(p => p.Organization)
                .WithMany(t => t.Room_rentals)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Room_rental>()
                .HasKey(t => new { t.Id });

            modelBuilder.Entity<ElectricsByOrganization>()
                .HasOne(p => p.Electric)
                .WithMany(t => t.ElectricsByOrganization)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<ElectricsByOrganization>()
                .HasOne(p => p.Organization)
                .WithMany(t => t.ElectricsByOrganization)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Lighting>()
                .HasOne(p => p.Electric)
                .WithMany(t => t.Lightings)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Invoice>()
                .HasOne(p => p.Room_Rental)
                .WithMany(t => t.Invoices)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
