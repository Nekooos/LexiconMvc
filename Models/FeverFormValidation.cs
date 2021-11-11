using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMvc.Models
{
    public class FeverFormValidation
    {
        public static Boolean isValidFeverValue(int feverValue)
        {

            return feverValue > 0;

        }
    }
}
