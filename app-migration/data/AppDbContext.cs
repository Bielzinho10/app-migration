using Microsoft.EntityFrameworkCore;

namespace MeuProjetoBackEnd.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Exemplo de tabela
        public DbSet<Produto> Produtos { get; set; }
    }

    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
    }
}
