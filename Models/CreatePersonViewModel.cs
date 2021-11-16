﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMvc.Models
{
    public class CreatePersonViewModel
    {
        [Required(ErrorMessage ="Name is required")]
        public String Name { get; set; }

        [Required(ErrorMessage = "City is required")]
        public String City { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        public String PhoneNumber { get; set; }
    }
}