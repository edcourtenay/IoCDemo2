using System;
using Ninject.Modules;
using WebFilm.Data;
using WebFilm.Services;

namespace WebFilm.App_Start
{
    public class BindingConfig : NinjectModule
    {
        public override void Load()
        {
            Bind<IFilmService>()
                .To<FilmService>();

            Bind<IFilmRepository>()
                .To<FilmRepository>();
        }
    }
}