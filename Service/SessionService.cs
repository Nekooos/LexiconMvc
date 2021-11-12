using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMvc.Service
{
    public class SessionService : ISessionService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;
        private ISession _session => _httpContextAccessor.HttpContext.Session;

        public SessionService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public void SetSession(String key, String value)
        {
            _session.SetString(key, value);
        }

        public String getSession(String key)
        {
            return _session.GetString(key);
        }

        public void deleteSession(String key)
        {
            _session.Remove(key);
        }
    }
}
