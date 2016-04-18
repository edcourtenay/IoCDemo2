using Ninject;
using Ninject.Activation;
using WebFilm.Data;
using WebFilm.Services;

namespace WebFilm.App_Start
{
    public class FilmRepositoryProvider : Provider<IFilmRepository>
    {
        private readonly ISiteIdentifierService _siteIdentifierService;

        public FilmRepositoryProvider(ISiteIdentifierService siteIdentifierService)
        {
            _siteIdentifierService = siteIdentifierService;
        }

        protected override IFilmRepository CreateInstance(IContext context)
        {
            switch (_siteIdentifierService.IdentifyRequest())
            {
                case Site.Arthouse:
                    return context.Kernel.Get<ArtFilmRepository>();

                default:
                    return context.Kernel.Get<FilmRepository>();
            }
        }
    }
}