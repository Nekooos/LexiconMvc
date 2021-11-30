using LexiconMvc.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace LexiconMvc.Data
{
    public class LexiconMvcContext : DbContext
    {
        public LexiconMvcContext(DbContextOptions<LexiconMvcContext> options) : base(options) { }
        public DbSet<Person> Persons { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            modelBuilder.Entity<Person>().HasData(new Person {Id=1, Name = "Kristoffer", City = "Göteborg", PhoneNumber = "0701112233" });
            modelBuilder.Entity<Person>().HasData(new Person {Id=2, Name = "Marvin", City = "Växjö", PhoneNumber = "0701112244" });
            modelBuilder.Entity<Person>().HasData(new Person {Id=3, Name = "Malin", City = "Växjö", PhoneNumber = "0701112255" });
            modelBuilder.Entity<Person>().HasData(new Person {Id=4, Name = "Sara", City = "Göteborg", PhoneNumber = "0701112266" });

            

        }
    }
}
