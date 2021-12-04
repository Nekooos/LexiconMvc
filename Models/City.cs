using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMvc.Models
{
    public class City
    {
        [Key]
        [Column("CityId")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(30)]
        [Required]
        public String Name { get; set; }

        public Country Country { get; set; }
        public int? CountryId { get; set; }

        public List<Person> Persons { get; set; }

        public City(String name, List<Person> persons)
        {
            Name = name;
            Persons = persons;

        }

        public City(String name, int? countryId)
        {
            Name = name;
            CountryId = countryId ?? default(int);

        }

        public City(int id, String name)
        {
            Id = id;
            Name = name;
        }


        public City(int id, String name, List<Person> persons, int countryId)
        {
            Id = id;
            Name = name;
            CountryId = countryId;
            Persons = persons;
        }

        public City()
        {

        }
    }
}
