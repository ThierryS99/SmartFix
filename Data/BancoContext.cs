using Microsoft.EntityFrameworkCore;
using SmartFix.Models;

namespace SmartFix.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        { }

        public DbSet<MaquinaModel> Maquina { get; set; }

        public DbSet<SetorModel> Setor { get; set; }

        public DbSet<OrdemManutencaoModel> OrdemManutencao { get; set; }
    }
}
