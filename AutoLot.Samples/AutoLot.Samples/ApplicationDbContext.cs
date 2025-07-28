namespace AutoLot.Samples;

public class ApplicationDbContext : DbContext
{
    public DbSet<Radio> Radios { get; set; }
    public DbSet<Car> Cars { get; set; }
    public DbSet<Make> Makes { get; set; }
    public DbSet<Driver> Drivers { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
    {
        SavingChanges += (sender, args) =>
        {
            Console.WriteLine($"Saving changes for {((DbContext)sender).Database.
            GetConnectionString()}");
        };
        SavedChanges += (sender, args) =>
        {
            Console.WriteLine($"Saved {args.EntitiesSavedCount} entities");
        };
        SaveChangesFailed += (sender, args) =>
        {
            Console.WriteLine($"An exception occurred! {args.Exception.Message} entities");
        };

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Car>(e =>
        {
            e.HasKey(c => c.Id);
            e.Property(e => e.IsDrivable).HasDefaultValue(true); // Setting a default value for IsDrivable

            e.HasOne(c => c.MakeNavigation)
             .WithMany(ca => ca.Cars)
             .HasForeignKey(c => c.MakeId)
             .OnDelete(DeleteBehavior.Cascade); // Configuring the foreign key relationship with cascade delete
        });

        modelBuilder.Entity<Make>(e =>
        {
            e.HasMany(m => m.Cars)
             .WithOne(c => c.MakeNavigation)
             .HasForeignKey(c => c.MakeId)
             .OnDelete(DeleteBehavior.ClientSetNull); 
        });
            
    }
    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        configurationBuilder.Properties<string>().HaveMaxLength(50); // This can help to setup a default max length for all string properties
    }

}

public class ApplicationDbContextFactory: IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {

        var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
        var connectionString = @"server=.,5433;Database=AutoLotSamples;User Id=sa;Password=1223;Encrypt=False;";
        optionsBuilder.UseSqlServer(connectionString);
        Console.WriteLine(connectionString);
        return new ApplicationDbContext(optionsBuilder.Options);
    }
}