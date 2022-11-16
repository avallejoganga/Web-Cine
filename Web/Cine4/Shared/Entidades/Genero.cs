using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine4.Shared.Entidades
{
    public class Genero
    {
        public Genero(String nombre)
        {
            Nombre = nombre;
        }
        public int ID { get; set; }
        [Required(ErrorMessage = "El campo {0} es requerido")]
        public string Nombre { get; set; }
        public string Foto { get; set; }        
    
    }
   
}