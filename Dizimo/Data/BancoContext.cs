using Dizimo.Data;
using Dizimo.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Hosting;

namespace Dizimo.Data
{
    public class BancoContext : DbContext 
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        { 
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<PessoaModel> Pessoas { get; set; }
        public DbSet<ComunidadeModel> Comunidades { get; set; }


    }
}
