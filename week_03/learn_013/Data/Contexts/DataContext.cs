using Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Data.Contexts;

// Converted into primary constructor on 'public DataContext' (ctrl + .) 
public class DataContext(DbContextOptions<DataContext> options) : DbContext(options)
{
    // The Dependency starts here, it demands an injection of data through 'options'.

    public DbSet<UserEntity> Users { get; set; } = null!;
    public DbSet<ProductEntity> Products { get; set; } = null!;
    public DbSet<OrderEntity> Orders { get; set; } = null!;
}

// public class DataContext : DbContext
// {
//     // The Dependency starts here, it demands an injection of data through 'options'.
//     public DataContext(DbContextOptions<DataContext> options) : base(options)
//     {
//         
//     }
//
//     public DbSet<UserEntity> Users { get; set; } = null!;
//     public DbSet<ProductEntity> Products { get; set; } = null!;
//     public DbSet<OrderEntity> Orders { get; set; } = null!;
//
// }