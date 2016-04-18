using WebFilm.App_Start;

namespace WebFilm.Services
{
    public class SiteIdentifierServiceService : ISiteIdentifierService
    {
        private readonly HttpContextWrapper _httpContextWrapper;

        public SiteIdentifierServiceService(HttpContextWrapper httpContextWrapper)
        {
            _httpContextWrapper = httpContextWrapper;
        }

        public Site IdentifyRequest()
        {
            switch (_httpContextWrapper.HostName)
            {
                case "artfilm.localhost":
                    return Site.Arthouse;

                default:
                    return Site.Default;
            }
        }
    }
}