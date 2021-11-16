using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMvc.Models
{
    public class Person
    {
        public long Id { get; set; }
        public String Name { get; set; }
        public String City { get; set; }
        public String PhoneNumber { get; set; }

        public Person(String name, String city, String phoneNumber)
        {
            Name = name;
            City = city;
            PhoneNumber = phoneNumber;
        }

        public Person()
        {

        }
    }


}
