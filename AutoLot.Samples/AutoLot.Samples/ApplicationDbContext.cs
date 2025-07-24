namespace AutoLot.Samples;

public class ApplicationDbContext : DbContext
{
    public DbSet<Radio> Radios { get; set; }
    public DbSet<Car> Cars { get; set; }
    public DbSet<Make> Makes { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
: base(options)
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

    protected override void OnModelCreating(ModelBuilder mb)
    {
        // Fluient API goes here
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