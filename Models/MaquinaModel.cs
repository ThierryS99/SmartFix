using System.ComponentModel.DataAnnotations;

namespace SmartFix.Models
{
    public class MaquinaModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string CodigoIdentificacao { get; set; }

        [Required]
        public double HorasFuncionamento { get; set; }

        [Required]
        public bool Status { get; set; } // TRUE: trabalhando, FALSE: avariada (parada)

        public string MaquinasCadastradas()
        {
            List<MaquinaModel> list = new List<MaquinaModel>();

            foreach (MaquinaModel maquina in list)
            {
                list.ToList();
            }
            return "X";
        }

    }
}