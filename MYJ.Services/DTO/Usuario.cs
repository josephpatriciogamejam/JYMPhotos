using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MYJ.Services.DTO
{
    public class Usuario
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }        
        [StringLength(100)]
        [Required]
        public string Email { get; set; }
        [NotMapped]
        [Compare("Email", ErrorMessage = "Los correos no coinciden.")]
        [DisplayName("Confirmar Email")]
        public string ConfirmEmail { get; set; }
    }
}
