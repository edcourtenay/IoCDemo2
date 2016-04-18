using System.Collections.Generic;

namespace WebFilm.Data
{
    public interface IFilmRepository
    {
        IEnumerable<Film> Films();
    }
}