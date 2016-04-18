using System.Web;
using Ninject;
using Ninject.Activation;
using WebFilm.Data;

namespace WebFilm.App_Start
{
    public class FilmRepositoryProvider : Provider<IFilmRepository>
    {
        private readonly HttpContext _httpContext;

        public FilmRepositoryProvider(HttpContext httpContext)
        {
            _httpContext = httpContext;
        }

        protected override IFilmRepository CreateInstance(IContext context)
        {
            switch (_httpContext.Request.ServerVariables["HTTP_HOST"])
            {
                case "artfilm.localhost":
                    return context.Kernel.Get<ArtFilmRepository>();

                default:
                    return context.Kernel.Get<FilmRepository>();
            }
        }
    }
}