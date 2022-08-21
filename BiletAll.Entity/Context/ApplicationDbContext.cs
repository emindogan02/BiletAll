using BiletAll.Entity.Models;
using Microsoft.EntityFrameworkCore;

namespace BiletAll.Entity.Context {
  public class ApplicationDbContext:DbContext {
    public DbSet<Firma>? Firmalar { get; set; }
    public DbSet<Pnr>? Pnrlar { get; set; }
    public DbSet<Sefer>? Seferler { get; set; }
    public DbSet<Yolcu>? Yolcular { get; set; }
    public DbSet<PnrYolcu>? PnrYolcular { get; set; }
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
         : base(options) {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {

    }
  }
}
