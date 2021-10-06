using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrudTest.Models
{
    public class Libro
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="El campo 'título' es obligatorio")]
        [StringLength(50,ErrorMessage ="El {0} debe ser al menos {2} y máximo {1} carácteres", MinimumLength = 3 )]
        [Display(Name="Título")]
        public String Titulo { get; set; }

        [Required(ErrorMessage ="El campo 'descripción' es obligatorio")]
        [StringLength(200,ErrorMessage = "El {0} debe ser al menos {2} y máximo {1} carácteres", MinimumLength = 5)]
        [Display(Name ="Desripción")]
        public String Descripcion { get; set; }
        [Required(ErrorMessage = "El campo 'fecha de lanzamiento' es obligatorio")]
        [DataType(DataType.Date)]
        [Display(Name = "Fecha de lanzamiento")]
        public DateTime FechaLanzamiento { get; set; }
        [Required(ErrorMessage = "El campo 'autor' es obligatorio")]
        public String Autor { get; set; }
        [Required(ErrorMessage = "El campo 'precio' es obligatorio")]
        public int Precio { get; set; }

    }
}
