using System.Collections.Generic;
using System.Linq;
using WebFilm.Data;

namespace WebFilm.Services
{
    public class FilmService : IFilmService
    {
        private readonly IFilmRepository _repository;

        public FilmService(IFilmRepository repository)
        {
            _repository = repository;
        }

        public IList<Film> GetFilms()
        {
            return _repository.Films().ToList();
        }
    }
}