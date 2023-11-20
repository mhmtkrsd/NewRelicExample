using Microsoft.EntityFrameworkCore;
using NewRelicExample.Repository.Entities;

namespace NewRelicExample.Repository;

public class NewRelicExampleDbContext : DbContext
{
    public NewRelicExampleDbContext(DbContextOptions<NewRelicExampleDbContext> options) : base(options)
    {
    }

    public DbSet<Product> Products { get; set; }
}