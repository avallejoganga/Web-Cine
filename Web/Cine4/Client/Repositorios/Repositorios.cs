using Cine4.Shared.Entidades;
using static System.Net.WebRequestMethods;

namespace Cine4.Client.Repositorios
{
    public class Repositorios : IRepositorio
    {
        public List<Pelicula> ObtenerPeliculas()
        {
            List<Pelicula> provisional = new List<Pelicula>()
            {
                 new Pelicula(){Titulo = "Spider-Man: Far From Home", Lanzamiento = new DateTime(2019, 7, 2), Poster = "https://i.etsystatic.com/18242346/r/il/4ec38e/1929832510/il_fullxfull.1929832510_achv.jpg",
                 Generos = new List<Genero>(){new Genero("Accion"), new Genero("Aventura")}},
                 new Pelicula(){Titulo = "Moana", Lanzamiento = new DateTime(2016, 11, 23), Poster = "https://ae01.alicdn.com/kf/HTB1emlJAfuSBuNkHFqDq6xfhVXaQ/Pintura-de-pared-de-lona-personalizada-p-ster-de-Moana-Maui-pegatinas-de-pared-pel-cula.jpg",
                 Generos = new List<Genero>(){new Genero("Animación"), new Genero("Aventura")}},                 
                 new Pelicula(){Titulo = "Inception", Lanzamiento = new DateTime(2010, 7, 16), Poster = "https://m.media-amazon.com/images/I/91Rc8cAmnAL._AC_SY679_.jpg",
                 Generos = new List<Genero>(){new Genero("Drama"), new Genero("Aventura")}},
                 new Pelicula(){Titulo = "El Padrino", Lanzamiento = new DateTime(1972, 3, 12), Poster = "https://pics.filmaffinity.com/the_godfather-488102675-large.jpg",
                 Generos = new List<Genero>(){new Genero("Drama")}},
                 new Pelicula(){Titulo = "La lista de Schindler", Lanzamiento = new DateTime(1993, 2, 26), Poster = "https://pics.filmaffinity.com/schindler_s_list-473662617-large.jpg",
                 Generos = new List<Genero>(){new Genero("Drama"), new Genero("Belico")}},
                 new Pelicula(){Titulo = "Testigo de cargo", Lanzamiento = new DateTime(1957, 1, 12), Poster = "https://pics.filmaffinity.com/witness_for_the_prosecution-236651370-large.jpg",
                 Generos = new List<Genero>(){new Genero("Drama"), new Genero("Comedia")}},
                 new Pelicula(){Titulo = "Luces de Ciudad", Lanzamiento = new DateTime(1917, 8, 12), Poster ="https://pics.filmaffinity.com/city_lights-825971402-large.jpg",
                 Generos = new List<Genero>(){new Genero("Drama"), new Genero("Comedia")}},
                 new Pelicula(){Titulo = "El Gran Dictador", Lanzamiento = new DateTime(1940, 8, 1), Poster = "https://pics.filmaffinity.com/the_great_dictator-416205081-large.jpg",
                 Generos = new List<Genero>(){new Genero("Drama"), new Genero("Comedia")}},
                 new Pelicula(){Titulo = "Pulp Fiction", Lanzamiento = new DateTime(1994, 12, 16), Poster = "https://pics.filmaffinity.com/pulp_fiction-210382116-large.jpg",
                 Generos = new List<Genero>(){new Genero("Drama"), new Genero("Comedia")}},
                 new Pelicula(){Titulo = "El Señor de los Anillos", Lanzamiento = new DateTime(2003, 10, 26), Poster = "https://pics.filmaffinity.com/the_lord_of_the_rings_the_return_of_the_king-178294596-large.jpg",
                 Generos = new List<Genero>(){new Genero("Fantasia"), new Genero("Aventura")}},
                 new Pelicula(){Titulo = "El Silencio de los Corderos", Lanzamiento = new DateTime(1991, 4, 6), Poster = "https://pics.filmaffinity.com/the_silence_of_the_lambs-767447992-large.jpg",
                 Generos = new List<Genero>(){new Genero("Suspense"), new Genero("Terror")}},
                 new Pelicula(){Titulo = "El Club de la Lucha", Lanzamiento = new DateTime(1999, 11, 6), Poster = "https://pics.filmaffinity.com/fight_club-320750671-large.jpg",
                 Generos = new List<Genero>(){new Genero("Suspense"), new Genero("Drama")}},
                 new Pelicula(){Titulo = "Chinatown", Lanzamiento = new DateTime(1974, 4, 12), Poster = "https://pics.filmaffinity.com/chinatown-715792129-large.jpg",
                 Generos = new List<Genero>(){new Genero("Suspense"), new Genero("Drama")}},
                 new Pelicula(){Titulo = "En Busca del Arca Perdida", Lanzamiento = new DateTime(1981, 2, 15), Poster = "https://pics.filmaffinity.com/indiana_jones_raiders_of_the_lost_ark-316486950-large.jpg",
                 Generos = new List<Genero>(){new Genero("Accion"), new Genero("Aventura")}},
                 new Pelicula(){Titulo = "Mad Max: Fury Road", Lanzamiento = new DateTime(2015, 2, 15), Poster = "https://pics.filmaffinity.com/mad_max_fury_road-429261909-large.jpg",
                 Generos = new List<Genero>(){new Genero("Accion"), new Genero("Aventura")}},
                 new Pelicula(){Titulo = "Salvar al Soldado Ryan", Lanzamiento = new DateTime(1998, 3, 25), Poster = "https://pics.filmaffinity.com/saving_private_ryan-585301228-large.jpg",
                 Generos = new List<Genero>(){new Genero("Belico"), new Genero("Drama")}},
                 new Pelicula(){Titulo = "La Chaqueta Metalica", Lanzamiento = new DateTime(1987, 12, 24), Poster = "https://pics.filmaffinity.com/full_metal_jacket-577943737-large.jpg",
                 Generos = new List<Genero>(){new Genero("Belico"), new Genero("Drama")}},
                 new Pelicula(){Titulo = "El viento se Levanta", Lanzamiento = new DateTime(2013, 4, 5), Poster = "https://pics.filmaffinity.com/kaze_tachinu-603357491-large.jpg",
                 Generos = new List<Genero>(){new Genero("Animacion"), new Genero("Drama")}},
                 new Pelicula(){Titulo = "Spider-Man: Un nuevo Universo", Lanzamiento = new DateTime(2018, 2, 13), Poster = "https://pics.filmaffinity.com/spider_man_into_the_spider_verse-917347027-large.jpg",
                 Generos = new List<Genero>(){new Genero("Animacion"), new Genero("Acción")}},
                 new Pelicula(){Titulo = "El bueno, el feo y el malo", Lanzamiento = new DateTime(1966, 12, 19), Poster = "https://pics.filmaffinity.com/il_buono_il_brutto_il_cattivo_aka_the_good_the_bad_and_the_ugly-589330734-large.jpg",
                 Generos = new List<Genero>(){new Genero("Western"), new Genero("Aventura")}},
                 new Pelicula(){Titulo = "Sin perdón", Lanzamiento = new DateTime(1992, 8, 21), Poster = "https://pics.filmaffinity.com/unforgiven-854755790-large.jpg",
                 Generos = new List<Genero>(){new Genero("Western"), new Genero("Drama")}},
            };
            provisional.Sort((x, y) => string.Compare(x.Titulo, y.Titulo));
            return provisional;
        }
        public List<Genero> ObtenerGeneros()
        {
            List<Genero> Temporal = new List<Genero>()
            {
                new Genero("Comedia"),
                new Genero("Drama"),
                new Genero("Accion"),
                new Genero("Aventura"),
                new Genero("Suspense"),
                new Genero("Fantasia"),
                new Genero("Terror"),
                new Genero("Romance"),
                new Genero("Western"),
                new Genero("Animación"),
                new Genero("Belico")
            };
            return Temporal;
        }

        public List<Pelicula> Peliculas { get; set; }
        public List<Genero> Generos { get; set; }
        
        public Repositorios()
        {
            Peliculas = ObtenerPeliculas();
            IDPeliculas();
            Generos = ObtenerGeneros();
            IDGeneros();
        }
        

        
        public List<Genero> DarGenero(string? genero1)
        {
            List<Genero> Temporal = new List<Genero>();

            if (genero1 != null)
            {
                Temporal.Add(new Genero(genero1));
            }            

            return Temporal;
        }

        


        void IDPeliculas()
        {
            for (int i = 0; i < Peliculas.Count; i++)
            {
                Peliculas[i].ID = i;
            }
        }

        void IDGeneros()
        {
            for (int i = 0; i < Generos.Count; i++)
            {
                Generos[i].ID = i;
            }
        }

    }
}
