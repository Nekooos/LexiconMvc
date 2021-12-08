using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LexiconMvc.Models;
using LexiconMvc.Data;

namespace LexiconMvc.Controllers
{
    public class SiteController : Controller
    {
        private IGithubRepositoriesData _githubProjectsData;

        public SiteController(IGithubRepositoriesData githubProjectsData)
        {
            _githubProjectsData = githubProjectsData;
        }

        public IActionResult ShowAllRepositories()
        {
            ViewBag.HeadLine = "Github Repositories Lexicon";
            IEnumerable<GithubRepository> githubRepositories = _githubProjectsData.getAll();
            return View(githubRepositories);
        }

        public IActionResult ShowContactInformation()
        {
            ViewBag.Headline = "Contact information";
            ViewBag.Name = "Kristoffer Gustafsson";
            ViewBag.Address = "Imaginary Street 44B 123 45 Göteborg";
            ViewBag.PhoneNumber = "070 777 77 77";
            ViewBag.Email = "mail@mail.com";

            return View();
        }

        public IActionResult Index()
        {
            string information = "Fusce vel euismod nisl. Suspendisse laoreet, mi vitae scelerisque venenatis, leo arcu hendrerit tortor, sed efficitur eros justo in eros. Maecenas sit amet euismod neque. Nunc suscipit ullamcorper lectus, ac volutpat elit dignissim vel. Vestibulum cursus arcu vel odio commodo, eu rhoncus mauris gravida. Ut quis massa ligula. Pellentesque habitant morbi tristique senectus et netus et malesuada fames ac turpis egestas. Praesent eu nibh dui. Quisque vel tortor metus. In hac habitasse platea dictumst. Proin a dignissim tortor. Pellentesque congue, sem quis tristique viverra, ex velit pretium neque, in fermentum lorem ligula vitae odio. Cras a leo consequat, euismod tortor ac, lacinia velit. Nullam tempus nulla purus, bibendum ornare risus volutpat ut. Nunc egestas hendrerit sem, eu luctus erat aliquam id."
            + "Orci varius natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus.Nulla augue felis,<br> lacinia at scelerisque mollis, accumsan ut turpis. Fusce fermentum nibh eget tincidunt viverra. Quisque et placerat enim. Pellentesque ipsum tortor, viverra nec tincidunt quis, porta eget justo. Suspendisse potenti. Quisque ac porttitor ex. Maecenas ac commodo turpis. Morbi nec nulla vel lectus imperdiet elementum.Fusce at lacinia lorem. Nulla ornare metus ut tortor fermentum, sit amet consectetur est dictum. Pellentesque augue lorem, efficitur at semper nec, consectetur sed lacus. Proin vestibulum sapien ac purus varius mattis.Fusce eu lorem velit. Nulla vulputate laoreet elit sit amet hendrerit.Nullam ipsum urna, eleifend sed interdum et, dictum at velit.";

            ViewBag.HeadLine = "About";
            ViewBag.Name = "Kristoffer gustafsson";
            ViewBag.Information = information;

            return View();
        }

    }
}
