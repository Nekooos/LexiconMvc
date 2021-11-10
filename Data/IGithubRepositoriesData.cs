using LexiconMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMvc.Data
{
    public interface IGithubRepositoriesData
    {
        GithubRepository getById(int id);

        IEnumerable<GithubRepository> getAll();
    }
}
