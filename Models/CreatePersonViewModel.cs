using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMvc.Models
{
    public class CreatePersonViewModel
    {
        [DataType(DataType.Text)]
        [Required(ErrorMessage ="Name is required"), MaxLength(30), MinLength(2)]
        [Display(Name="Name")]
        public String Name { get; set; }

        public City City { get; set; }

        public int CityId { get; set; }


        [Required(ErrorMessage = "Phone number is required")]
        public String PhoneNumber { get; set; }

    }
}
