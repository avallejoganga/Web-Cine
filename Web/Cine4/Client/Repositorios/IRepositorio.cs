using Cine4.Shared.Entidades;


namespace Cine4.Client.Repositorios
{
    public interface IRepositorio
    {
        List<Pelicula> ObtenerPeliculas();
        List<Pelicula> Peliculas { get; set; }
        List<Genero> ObtenerGeneros();
        public List<Genero> Generos { get; set; }

    }
}
