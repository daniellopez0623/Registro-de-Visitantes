using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace RegistroVst.Models
{
    public class Visitante
    {
        //prop

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "El Nombre es requerido.")]
        [StringLength(50, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El Apellido es requerido.")]
        [StringLength(50, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Apellido")]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "La Fecha de entrada, es requerida.")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha Entrada")]
        public DateTime FechaEntrada { get; set; }

        [Required(ErrorMessage = "El motivo de la visita, es requerido.")]
        [StringLength(100, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Motivo")]
        public string MotivoVisita { get; set; }
    }
}
