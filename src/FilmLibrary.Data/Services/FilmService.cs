using FilmLibrary.Data.Domain.Films;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmLibrary.Data.Services
{
    public class FilmService
    {
        private List<Film> peliculas;
        public FilmService()
        {
            this.peliculas = new List<Film>();
            peliculas.Add(new Film
            {
                Id = 1,
                Nombre = "Crash"
            });
        }
        public List<Film> GetFilms()
        {
            return peliculas;
        }
        public void AddFilm(Film film)
        {
            peliculas.Add(film);
        }
            

    }
}
