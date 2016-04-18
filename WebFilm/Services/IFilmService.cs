using System.Collections.Generic;
using WebFilm.Data;

namespace WebFilm.Services
{
    public interface IFilmService
    {
        IList<Film> GetFilms();
    }
}