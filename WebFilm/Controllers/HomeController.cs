using System.Web.Mvc;
using WebFilm.Services;

namespace WebFilm.Controllers
{
    public class HomeController : Controller
    {
        private readonly IFilmService _filmService;

        public HomeController(IFilmService filmService)
        {
            _filmService = filmService;
        }

        [Route("")]
        public ActionResult Index()
        {
            return View(_filmService.GetFilms());
        }
    }
}