using System;
using System.Collections.Concurrent;
using WebFilm.Services;

namespace WebFilm.App_Start
{
    public class ScopeObjectProvider
    {
        private readonly ISiteIdentifierService _siteIdentifierService;
        private readonly ConcurrentDictionary<Site, string> _map = new ConcurrentDictionary<Site, string>();

        public ScopeObjectProvider(ISiteIdentifierService siteIdentifierService)
        {
            _siteIdentifierService = siteIdentifierService;
        }

        public string Scope
        {
            get { return _map.GetOrAdd(_siteIdentifierService.IdentifyRequest(), site => Guid.NewGuid().ToString()); }
        }
    }
}