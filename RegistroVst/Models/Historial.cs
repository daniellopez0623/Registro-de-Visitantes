using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace RegistroVst.Models
{
    public class Historial
    {
        //prop

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "La cédula es requerida.")]
        [Display(Name = "Cédula")]
        public int IdVisitante { get; set; }

        [Required(ErrorMessage = "La ID Evento es requerida.")]
        [Display(Name = "ID Evento")]
        public int IdEvento { get; set; }

        [Required(ErrorMessage = "La Fecha de salida, es requerida.")]
        [DataType(DataType.DateTime)]
        [Display(Name = "Fecha de salida")]
        public DateTime FechaSalida { get; set; }
     
    }
}
