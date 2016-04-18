using WebFilm.Data;

namespace WebFilm.App_Start
{
    public interface IFilmRepositoryFactory
    {
        IFilmRepository Create();
    }
}