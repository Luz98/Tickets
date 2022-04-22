using System.ComponentModel.DataAnnotations;

namespace Tickets.Data.Entities
{
    public class Entrance
    {
        public int Id { get; set; }

        [Display(Description = "Descripción")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} Caractéres")]
        [Required(ErrorMessage = " El campo {0} es obligatorio")]
        public string Description { get; set; } 
        
        public ICollection<ticket> tickets { get; set; }
    }
}
