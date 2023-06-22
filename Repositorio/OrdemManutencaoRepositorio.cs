using SmartFix.Data;
using SmartFix.Models;

namespace SmartFix.Repositorio
{
    public class OrdemManutencaoRepositorio : IOrdemManutencaoRepositorio
    {
        private readonly BancoContext _bancoContext;

        public OrdemManutencaoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public OrdemManutencaoModel Adicionar(OrdemManutencaoModel ordem_Manutencao)
        {
            _bancoContext.OrdemManutencao.Add(ordem_Manutencao);
            _bancoContext.SaveChanges();
            return ordem_Manutencao;
        }

        public List<MaquinaModel> BuscarMaquina()
        {
            return _bancoContext.Maquina.ToList();
        }

        public List<OrdemManutencaoModel> BuscarOrdens()
        {
            return _bancoContext.OrdemManutencao.ToList();
        }
    }
}
