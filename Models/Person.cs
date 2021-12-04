using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LexiconMvc.Models
{
    public class Person
    {
        [Key]
        [Column("PersonId")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(30)]
        [Required]
        public String Name { get; set; }

        [MaxLength(30)]
        public City City { get; set; }

        
        public int? CityId { get; set; }

        public String PhoneNumber { get; set; }

        public List<PersonLanguage> PersonLanguages { get; set; }

        public Person(String name, City city, String phoneNumber)
        {
            Name = name;
            City = city;
            PhoneNumber = phoneNumber;
        }

        public Person(int id, String name, City city, int cityId, String phoneNumber)
        {
            Id = id;
            Name = name;
            City = city;
            CityId = cityId;
            PhoneNumber = phoneNumber;
        }

        public Person(int id, String name, String phoneNumber)
        {
            Id = id;
            Name = name;
            PhoneNumber = phoneNumber;
        }

        public Person()
        {

        }
    }


}
