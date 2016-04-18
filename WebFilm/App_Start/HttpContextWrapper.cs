using System.Web;

namespace WebFilm.App_Start
{
    public class HttpContextWrapper
    {
        public string HostName => HttpContext.Current.Request.ServerVariables["HTTP_HOST"];
    }
}