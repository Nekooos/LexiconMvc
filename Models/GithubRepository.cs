using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMvc.Models
{
    public class GithubRepository
    {
        public long Id { get; set; }
        public String Name { get; set; }
        public String RepositoryUrl { get; set; }
        public String Description { get; set; }

        public GithubRepository(long id, String name, String repositoryUrl, String description)
        {
            Id = id;
            Name = name;
            RepositoryUrl = repositoryUrl;
            Description = description;
        }

        public GithubRepository()
        {

        }
    }
}
