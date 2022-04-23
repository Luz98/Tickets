using System.ComponentModel.DataAnnotations;

namespace Tickets.Models
{
    public class EntranceViewModel
    {
         public int Id { get; set; }

        [Display(Description = "Descripción")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} Caractéres")]
        [Required(ErrorMessage = " El campo {0} es obligatorio")]
        public string Description { get; set; }

        public int TicketId { get; set; }   

    }
}
