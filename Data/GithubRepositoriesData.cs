using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LexiconMvc.Models;

namespace LexiconMvc.Data
{
    public class GithubRepositoriesData : IGithubRepositoriesData
    {
        private List<GithubRepository> githubRepositories;

        public GithubRepositoriesData()
        {
            githubRepositories = new List<GithubRepository>()
            {
                new GithubRepository(1, "TodoIt", "https://github.com/Nekooos/LexiconTodoIt",  "vitae ornare mauris interdum. Phasellus ullamcorper sapien vitae ultrices luctus. Curabitur at erat felis. Proin in purus aliquet, luctus lectus id, suscipit augue. Maecenas id velit faucibus, condimentum odio sit amet, ornare mauris. Vestibulum pellentesque sapien ut fringilla vehicula."),
                new GithubRepository(2, "Vending Machine", "https://github.com/Nekooos/LexiconVendingMachine",  "Sed odio orci, congue sed nibh et, iaculis varius purus. Quisque laoreet gravida ligula, ut lacinia nunc lobortis at. Sed a egestas lacus. Ut hendrerit pulvinar suscipit. Nulla tincidunt, quam in ultricies sagittis, sapien ipsum eleifend lectus, at rhoncus augue ligula sit amet velit."),
                new GithubRepository(3, "Sokoban", "https://github.com/Nekooos/LexiconSokoban", "Phasellus sed fermentum nibh, nec aliquam urna. Praesent commodo libero maximus placerat aliquam. Mauris imperdiet erat dictum augue varius viverra Morbi euismod purus augue, non tempor orci dapibus nec. Vivamus blandit dui sed nisi placerat viverra. Duis et risus sed eros ultricies ultrices."),
                new GithubRepository(4, "Hangman", "https://github.com/Nekooos/LexiconHangman", "am ac tortor sagittis, id eleifend dui gravida. Etiam placerat posuere sagittis. Fusce mattis cursus lacinia. Nulla aliquam vehicula dignissim. Praesent posuere, libero eu convallis mattis, est orci volutpat mauris, at lobortis massa tortor sed odio. Nulla vulputate luctus pharetra."),
                new GithubRepository(5, "Calculator", "https://github.com/Nekooos/LexiconCalculator", " libero eu convallis mattis, est orci volutpat mauris, at lobortis massa tortor sed odio. Nulla vulputate luctus pharetra. Nam at elit a quam ullamcorper accumsan. Etiam rutrum at mauris ac cursus. Quisque a nibh in est sagittis mollis. Aenean id nisl ut eros commodo posuere. Curabitur lorem leo, dapibus et consequat in, cursus sit amet elit."),
                new GithubRepository(6, "Html and Css", "https://github.com/Nekooos/LexiconHtmlCss", " Vestibulum semper erat at risus auctor, quis gravida orci placerat. Morbi dictum posuere rhoncus. Duis a ex a augue condimentum mattis. Aliquam sit amet tempor dui. Proin interdum sapien sit amet elit varius cursus gravida vel nisl. Donec pharetra, odio eu bibendum tempus, ante augue mollis sapien, in varius sem ex et libero.")
            };
        }

        public GithubRepository getById(int id)
        {
            return githubRepositories.ElementAt(id-1);
        }

        public IEnumerable<GithubRepository> getAll()
        {
            return githubRepositories;
        }
    }
}
