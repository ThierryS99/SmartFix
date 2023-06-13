using System.ComponentModel.DataAnnotations;

namespace SmartFix.Models.OrdemManutencao
{

    public class OrdemManutencaoModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public SetorModel Setor { get; set; }

        [Required]
        public MaquinaModel Maquina { get; set; }

        [Required]
        public double HorasFuncionamento { get; set; }

        [Required]
        public DateTime DataHoraExecucao { get; set; }

        [Required]
        public double TempoExecucao { get; set; }

        [Required]
        public string Motivo { get; set; }

        [Required]
        public string Observacao { get; set; }

        public enum Status
        {
            Aberta_Aguardando,
            Aberta_Executando,
            Fechada
        }

        public enum Tipo
        {
            Preventiva,
            Corretiva_Agendada,
            Corretiva_Inesperada
        }
    }
}