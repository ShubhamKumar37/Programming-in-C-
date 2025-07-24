Console.WriteLine("Fun with ef core practice");

static void SampleChanges()
{
    var context = new ApplicationDbContextFactory().CreateDbContext(null);
    context.SaveChanges();
}

static void TransactedSaveChanges()
{
    var context = new ApplicationDbContextFactory().CreateDbContext(null);
    using var transaction = context.Database.BeginTransaction();

    try
    {
        // We can create save points where we can go back to if needed
        transaction.CreateSavepoint("Check point1");
        context.SaveChanges();
        transaction.Commit();
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
        //transaction.Rollback();
        transaction.RollbackToSavepoint("Check point1");
    }
}

static void TransactionWithExecutionStrategies()
{
    var context = new ApplicationDbContextFactory().CreateDbContext(null);
    var strategy = context.Database.CreateExecutionStrategy();
    strategy.Execute(() =>
    {
        using var trans = context.Database.BeginTransaction();
        try
        {
            // Action to execute
            trans.Commit();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            trans.Rollback();
        }
    });
}
