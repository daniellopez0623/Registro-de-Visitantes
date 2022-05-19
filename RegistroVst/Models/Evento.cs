using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace RegistroVst.Models
{
    public class Evento
    {
        //prop

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "La cédula es requerida.")]
        [Display(Name = "Cédula")]
        public int IdVisitante { get; set; }

        [Required(ErrorMessage = "La Fecha de inicio, es requerida.")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha de inicio")]
        public DateTime FechaEntrada { get; set; }

        [Required(ErrorMessage = "La descripción es requerida.")]
        [StringLength(100, ErrorMessage = "El {0} debe ser al menos {2} y maximo {1} caracteres", MinimumLength = 3)]
        [Display(Name = "Descripción  del evento.")]
        public string Descripcion { get; set; }

    }
}
