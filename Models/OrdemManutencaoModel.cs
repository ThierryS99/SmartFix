using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace SmartFix.Models
{

    public class OrdemManutencaoModel
    {
        
        [Required]
        public int Id { get; set; }

        [Required]
        public int SetorId { get; set; }

        [Required]
        public int MaquinaId { get; set; }

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

        [Required]
        public int StatusNumero { get; set; }

        [Required]
        public int TipoNumero { get; set; }

        public enum Status
        {
            Aberta_Aguardando,
            Aberta_Executando,
            Aberta_Parada,
            Fechada
        }

        public enum Tipo
        {
            Preventiva,
            Corretiva_Agendada,
            Corretiva_Inesperada
        }

        public string StatusEnum()
        {
            if (StatusNumero == 0)
            {
                return Status.Aberta_Aguardando.ToString();
            }
            else if (StatusNumero == 1)
            {
                return Status.Aberta_Executando.ToString();
            }
            else if (StatusNumero == 2)
            {
                return Status.Aberta_Parada.ToString();
            }
            else if (StatusNumero == 3)
            {
                return Status.Fechada.ToString();
            }
            return "";
        }

        public string TipoEnum()
        {
            if (TipoNumero == 0)
            {
                return Tipo.Preventiva.ToString();
            }
            else if (TipoNumero == 1)
            {
                return Tipo.Corretiva_Agendada.ToString();
            }
            else if (TipoNumero == 2)
            {
                return Tipo.Corretiva_Inesperada.ToString();
            }
            return "";
        }
    }
}