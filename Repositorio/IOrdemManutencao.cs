using SmartFix.Models;

namespace SmartFix.Repositorio
{
    public interface IOrdemManutencaoRepositorio
    {
        OrdemManutencaoModel Adicionar(OrdemManutencaoModel model);
    }
}
