using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMvc.Models
{
    public class Country
    {
        [Key]
        [Column("CountryId")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(30)]
        [Required]
        public String Name { get; set; }

        [MaxLength(30)]
        public List<City> Cities { get; set; }

        public Country(String name, List<City> cities)
        {
            Name = name;
            Cities = cities;
        }


        public Country(String name)
        {
            Name = name;
        }


        public Country(int id, String name)
        {
            Id = id;
            Name = name;
        }

        public Country()
        {

        }
    }
}
