using Microsoft.EntityFrameworkCore;

namespace Databasefirst;

public class TestDatabase1 : DbContext
{
    /// <inheritdoc />
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        string connection = "Data Source=.;" +
                            "Initial Catalog=TestDatabase1;" +
                            "Integrated Security=true;" +
                            "MultipleActiveResultSets=true";

        ConsoleColor previousColor = Console.ForegroundColor;
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine($"Connection: {connection}");
        Console.ForegroundColor = previousColor;

        optionsBuilder.UseSqlServer(connection);
    }
}