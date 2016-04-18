using System.Runtime.CompilerServices;
using Ninject;
using Ninject.Extensions.Factory;
using Ninject.Modules;
using WebFilm.Data;
using WebFilm.Services;

namespace WebFilm.App_Start
{
    public class BindingConfig : NinjectModule
    {
        public override void Load()
        {
            Bind<ScopeObjectProvider>()
                .ToSelf()
                .InSingletonScope();

            Bind<HttpContextWrapper>()
                .ToSelf()
                .InSingletonScope();

            Bind<IFilmService>()
                .To<FilmService>()
                .InScope(context => context.Kernel.Get<ScopeObjectProvider>().Scope);

            Bind<IFilmRepositoryFactory>()
                .ToFactory();

            Bind<IFilmRepository>()
                .ToProvider<FilmRepositoryProvider>();

            Bind<ISiteIdentifierService>()
                .To<SiteIdentifierServiceService>()
                .InTransientScope();
        }
    }
}