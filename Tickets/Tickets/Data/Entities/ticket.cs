using System.ComponentModel.DataAnnotations;

namespace Tickets.Data.Entities
{
    public class ticket
    {
        public int Id { get; set; }
        public bool WasUsed { get; set; }

        [Display(Description = "Documento")]
        [MaxLength(20, ErrorMessage = "El campo {0} debe tener máximo {1} Caractéres")]
        [Required(ErrorMessage = " El campo {0} es obligatorio")]
        public string Document { get; set; }

        [Display(Description = "Nombre")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} Caractéres")]
        [Required(ErrorMessage = " El campo {0} es obligatorio")]
        public string Name { get; set; }

        public Entrance  entrance { get; set; }
        
        public DateTime Date { get; set; }
    }
}
