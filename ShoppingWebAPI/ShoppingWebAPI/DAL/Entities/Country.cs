using System.ComponentModel.DataAnnotations;

namespace ShoppingWebAPI.DAL.Entities
{
    public class Country : Entity
    {
        [Display(Name = "País")]
        [MaxLength(50, ErrorMessage = "El campo {0} debe tener máximo {1} caractéres.")] // Longitud máxima
        [Required(ErrorMessage = "El campo {0} es obligatorio.")] //Not null
        public string Name { get; set; }
    }
}
