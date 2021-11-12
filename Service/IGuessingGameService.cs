using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMvc.Service
{
    public interface IGuessingGameService
    {
        public String GuessNumber(int guess, int answer);

        public void SetSessionRandomNumber(String key);

        public int getSessionAnswer(String key);

    }
}
