using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LexiconMvc.Models;
using LexiconMvc.Data;
using Microsoft.AspNetCore.Http;
using System.Text.Json;

namespace LexiconMvc.Controllers
{
    public class RepositoriesController : Controller
    {
        private IGithubRepositoriesData _githubProjectsData;

        public RepositoriesController(IGithubRepositoriesData githubProjectsData)
        {
            _githubProjectsData = githubProjectsData;
        }

        public IActionResult ShowAllRepositories()
        {
            ViewBag.HeadLine = "Github Repositories Lexicon";
            IEnumerable<GithubRepository> githubRepositories = _githubProjectsData.getAll();
            return View(githubRepositories);
        }

        
    }
}
