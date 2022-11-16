﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cine4.Shared.Entidades
{
    public class Pelicula
    {
        public int ID { get; set; }
        [Required]
        public string Titulo { get; set; }
        [Required]
        public DateTime Lanzamiento;        
        public string Poster { get; set; }
        public bool EnCartelera { get; set; }
        public List<Genero> Generos { get; set; }        

        public string TituloCortado
        {
            get
            { 
                if (string.IsNullOrEmpty(Titulo))
                {
                    return null;
                }

                if (Titulo.Length > 60)
                {
                    return Titulo.Substring(0, 60) + "...";
                }
                else
                {
                    return Titulo;
                }
            }
        }
    }
}
