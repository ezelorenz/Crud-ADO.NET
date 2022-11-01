using System.ComponentModel.DataAnnotations;

namespace CRUDCOREmvc.Models
{
    public class ContactoModel
    {
        //cada una de éstas lineas hacen referencia a cada una de las columnas que tengo en la tabla
        public int IdContacto { get; set; }
        [Required(ErrorMessage ="El campo Nombre es obligatorio")]
        public string? Nombre { get; set; }
        [Required(ErrorMessage = "El campo Telefono es obligatorio")]
        public string? Telefono { get; set; }
        [Required(ErrorMessage = "El campo Correo es obligatorio")]
        public string? Correo { get; set; }
    }
}
