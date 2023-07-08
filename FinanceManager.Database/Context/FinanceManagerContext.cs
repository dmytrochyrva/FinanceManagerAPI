namespace FinanceManager.Database.Context;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

using FinanceManager.Database.Models;

public class FinanceManagerContext : DbContext {
  private readonly IConfiguration _config;
  
  public FinanceManagerContext(IConfiguration config)
  {
    _config = config;
  }

  public DbSet<Category> Categories { get; set; }
  public DbSet<Operation> Operations { get; set; }

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
      modelBuilder.Entity<Operation>().ToView("OPERATIONSVIEW");
      modelBuilder.Entity<Category>().ToTable("CATEGORIES");
  }

  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    string connectionString = _config.GetConnectionString("MySql");

    optionsBuilder.UseMySQL(connectionString);
  }
}