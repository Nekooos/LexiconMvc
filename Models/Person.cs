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
        [Required]
        public String City { get; set; }

        [Required]
        public String PhoneNumber { get; set; }

        public Person(String name, String city, String phoneNumber)
        {
            Name = name;
            City = city;
            PhoneNumber = phoneNumber;
        }

        public Person(int id, String name, String city, String phoneNumber)
        {
            Id = id;
            Name = name;
            City = city;
            PhoneNumber = phoneNumber;
        }

        public Person()
        {

        }
    }


}
