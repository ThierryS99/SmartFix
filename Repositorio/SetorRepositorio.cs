using SmartFix.Data;
using SmartFix.Models;

namespace SmartFix.Repositorio
{
    public class SetorRepositorio : ISetorRepositorio
    {
        private readonly BancoContext _bancoContext;

        public SetorRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public SetorModel Adicionar(SetorModel setor)
        {
            _bancoContext.Setor.Add(setor);
            _bancoContext.SaveChanges();
            return setor;
        }
    }
}