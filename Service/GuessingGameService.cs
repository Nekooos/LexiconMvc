using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace LexiconMvc.Service
{
    public class GuessingGameService : IGuessingGameService
    {

        private ISessionService _sessionService;

        public GuessingGameService(ISessionService sessionService)
        {
            _sessionService = sessionService;
        }

        public String GuessNumber(int guess, int answer)
        {
            if (guess == getSessionAnswer("Answer"))
            {
                _sessionService.deleteSession("RandomNumber");
                return $"You guessed the right number {answer}";
            }
            else if (guess > answer)
            {
                return $"Answer is lower than {guess}";
            }
            else
            {
                return $"Answer is higher than {guess}";
            }
        }

        public void SetSessionRandomNumber(String key)
        {
            Random random = new Random();
            String randomNumber = random.Next(1, 100).ToString();
            _sessionService.SetSession(key, randomNumber);
        }

        public int getSessionAnswer(String key)
        {
            return int.Parse(_sessionService.getSession(key));
        }

    }
}
