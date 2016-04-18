using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebFilm.App_Start;
using WebFilm.Data;

namespace WebFilm.Services
{
    public class FilmService : IFilmService
    {
        private readonly IFilmRepositoryFactory _factory;

        public FilmService(IFilmRepositoryFactory factory)
        {
            _factory = factory;
        }

        public IList<Film> GetFilms()
        {
            var repository = _factory.Create();
            return repository.Films().ToList();
        }
    }
}