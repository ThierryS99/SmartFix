using SmartFix.Data;
using SmartFix.Models;

namespace SmartFix.Repositorio
{
    public class MaquinaRepositorio : IMaquinaRepositorio
    {
        private readonly BancoContext _bancoContext;

        public MaquinaRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public MaquinaModel Adicionar(MaquinaModel maquina)
        {
            _bancoContext.Maquina.Add(maquina);
            _bancoContext.SaveChanges();
            return maquina;
        }

        public List<MaquinaModel> BuscarTodasMaquinas()
        {
            return _bancoContext.Maquina.ToList();
        }
    }
}
