using SmartFix.Models;

namespace SmartFix.Repositorio
{
    public interface IMaquinaRepositorio
    {
        MaquinaModel Adicionar(MaquinaModel maquina);
        List<MaquinaModel> BuscarTodasMaquinas();
    }
}
