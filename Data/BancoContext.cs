using Microsoft.EntityFrameworkCore;
using SmartFix.Models;
using SmartFix.Models.OrdemManutencao;

namespace SmartFix.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {

        }

        public DbSet<MaquinaModel> Maquina { get; set; }

        public DbSet<SetorModel> Setor { get; set; }

        public DbSet<OrdemManutencaoModel> ordemManutencao { get; set; }
    }
}
