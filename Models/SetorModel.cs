using System.ComponentModel.DataAnnotations;

namespace SmartFix.Models
{
    public class SetorModel
    {
        [Required]
        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }
        
    }
}
