using SmartFix.Models;
using SmartFix.Models.OrdemManutencao;

namespace SmartFix.Repositorio
{
    public interface IOrdemManutencaoRepositorio
    {
        OrdemManutencaoModel Adicionar(OrdemManutencaoModel model);
    }
}
