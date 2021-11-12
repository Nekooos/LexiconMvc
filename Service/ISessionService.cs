using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMvc.Service
{
    public interface ISessionService
    {
        public void SetSession(String key, String value);

        public String getSession(String key);

        public void deleteSession(String key);

    }
}
