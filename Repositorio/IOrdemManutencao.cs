using SmartFix.Models;

namespace SmartFix.Repositorio
{
    public interface IOrdemManutencaoRepositorio
    {
        OrdemManutencaoModel Adicionar(OrdemManutencaoModel ordemManutencao);

        List<MaquinaModel> BuscarMaquina();

        List<OrdemManutencaoModel> BuscarOrdens();
    }
}
