using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;

namespace WebAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Produto> Produtos{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produto>()
                .Property(p => p.Nome)
                .HasMaxLength(80);

            modelBuilder.Entity<Produto>()
                .Property(p => p.Preco)
                .HasPrecision(10, 2);



            modelBuilder.Entity<Produto>().HasData(
                 new Produto { Id = 1, Nome = "Trator", Preco= 1000000.00M, Estoque = 5 },
                 new Produto { Id = 2, Nome = "Ventilador Agricola", Preco= 156000.00M, Estoque = 10 },
                 new Produto { Id = 3, Nome = "Ração", Preco= 3000.00M, Estoque = 50 });
        }
    }
}
