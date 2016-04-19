using System.Web.Mvc;
using WebFilm.Services;

namespace WebFilm.Controllers
{
    public class FilmCountController : Controller
    {
        private readonly IFilmService _filmService;

        public FilmCountController(IFilmService filmService)
        {
            _filmService = filmService;
        }

        [Route("filmcount")]
        public PartialViewResult Index()
        {
            return PartialView("FilmCount", _filmService.GetFilms());
        }
    }
}