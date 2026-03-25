using System.ComponentModel.DataAnnotations;

namespace Vehicles.API.Data.Entities
{
    public class VehicleType
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="El campo {0} es obligatorio")]
        [StringLength(50, ErrorMessage = "El campo {0} debe tener entre {2} y {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Tipo de Vehículo")]
        public int Description { get; set; }
    }
}
