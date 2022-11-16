using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine4.Shared.Entidades
{
    public class Persona
    {
        public int ID { get; set; }
        [Required]
        public string Nombre { get; set; }       

        public string Foto { get; set; }
        [Required]
        public DateTime? FechaNacimiento { get; set; }       
    }
}
