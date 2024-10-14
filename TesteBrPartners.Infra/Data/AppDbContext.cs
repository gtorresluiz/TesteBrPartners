using Microsoft.EntityFrameworkCore;
using TesteBrPartners.Domain.Entities; 

namespace TesteBrPartners.Infra.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=GAMER-PC;Database=brpartners;Integrated Security=True;Encrypt=False;", options =>
                    options.EnableRetryOnFailure());
            }
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
    }
}
