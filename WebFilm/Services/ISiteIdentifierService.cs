using WebFilm.App_Start;

namespace WebFilm.Services
{
    public interface ISiteIdentifierService
    {
        Site IdentifyRequest();
    }
}