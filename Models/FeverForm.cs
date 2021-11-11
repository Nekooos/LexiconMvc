using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMvc.Models
{
    public class FeverForm
    {
        public int FeverValue { get; set; }
        public string Type { get; set; }

        public FeverForm(int feverValue, String type)
        {
            FeverValue = feverValue;
            Type = type;
        }

        public FeverForm()
        {

        }
    }
}
