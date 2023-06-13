namespace SmartFix.Models
{
    public class ManutencaoModel
    {
        public string Tipo { get; set; }
        public DateTime TempoExecucao { get; set; }
        public void ManutencaoPreventiva(DateTime tempoNecessario)
        {
            ManutencaoModel manutencaoModel = new ManutencaoModel();

            manutencaoModel.Tipo = "Preventiva";
            manutencaoModel.TempoExecucao = tempoNecessario;
        }

        public void ManutencaoCorretivaAgendada(DateTime tempoNecessario)
        {
            ManutencaoModel manutencaoModel = new ManutencaoModel();

            manutencaoModel.Tipo = "Corretiva";
            manutencaoModel.TempoExecucao = tempoNecessario;
        }

        public void ManutencaoCorretivaUrgente(DateTime tempoNecessario)
        {
            ManutencaoModel manutencaoModel = new ManutencaoModel();

            manutencaoModel.Tipo = "Corretiva";
            manutencaoModel.TempoExecucao = tempoNecessario;
        }
    }
}