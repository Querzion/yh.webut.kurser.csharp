using Microsoft.EntityFrameworkCore;

namespace learn_012_2_databaseintegration.Contexts;

// DbContext is part of the Microsoft.EntityFrameworkCore nuget Package!!! 
// This is an example for when base is actually in use, in real situations.
public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
        
    }
}