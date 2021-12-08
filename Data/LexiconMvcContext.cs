using LexiconMvc.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.Entity.ModelConfiguration.Conventions;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace LexiconMvc.Data
{
    public class LexiconMvcContext : IdentityDbContext<ApplicationUser, ApplicationRole, String>
    {
        public LexiconMvcContext(DbContextOptions<LexiconMvcContext> options) : base(options) { }
        public DbSet<Person> Persons { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<PersonLanguage> PersonLanguage { get; set; }

        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<ApplicationRole> ApplicationRoles { get; set; }
        public DbSet<ApplicationUserRole> ApplicationUserRoles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Person>()
                .HasOne<City>(person => person.City)
                .WithMany(city => city.Persons)
                .HasForeignKey(person => person.CityId);

            modelBuilder.Entity<City>()
                .HasOne<Country>(city => city.Country)
                .WithMany(country => country.Cities)
                .HasForeignKey(city => city.CountryId);

            modelBuilder.Entity<Country>()
                .HasMany(country => country.Cities)
                .WithOne(city => city.Country);

            modelBuilder.Entity<PersonLanguage>()
                .HasKey(personLanguage => new { personLanguage.PersonId, personLanguage.LanguageId });

            modelBuilder.Entity<PersonLanguage>()
                .HasOne<Person>(personLanguage => personLanguage.Person)
                .WithMany(person => person.PersonLanguages)
                .HasForeignKey(personLanguage => personLanguage.PersonId);

            modelBuilder.Entity<PersonLanguage>()
                .HasOne<Language>(personLanguage => personLanguage.Language)
                .WithMany(language => language.PersonLanguages)
                .HasForeignKey(personLanguage => personLanguage.LanguageId);


            /*
            modelBuilder.Entity<ApplicationUserRole>(userRole =>
            {
                userRole.HasKey(userRole => new { userRole.UserId, userRole.RoleId });

                userRole.HasOne(userRole => userRole.Role)
                    .WithMany(role => role.UserRoles)
                    .HasForeignKey(userRole => userRole.RoleId);



                userRole.HasOne(userRole => userRole.User)
                    .WithMany(user => user.UserRoles)
                    .HasForeignKey(userRole => userRole.UserId);
            });
            */



            Person person1 = new Person(1, "Kristoffer", "0731112233");
            Person person2 = new Person(2, "Sara", "0731112233");
            Person person3 = new Person(3, "Björgen", "0731112233");
            Person person4 = new Person(4, "Marcus", "0731112233");

            City city2 = new City(6, "StockHolm");
            City city3 = new City(7, "Göteborg");
            City city4 = new City(8, "Oslo");

            person1.CityId = 6;
            person2.CityId = 7;
            person3.CityId = 8;
            person4.CityId = 6;

            Country country1 = new Country(11, "Sverige");
            Country country2 = new Country(12, "Norge");

            city2.CountryId = 11;
            city3.CountryId = 11;
            city4.CountryId = 12;

            

            modelBuilder.Entity<Country>().HasData(country1);
            modelBuilder.Entity<Country>().HasData(country2);


            modelBuilder.Entity<City>().HasData(city2);
            modelBuilder.Entity<City>().HasData(city3);
            modelBuilder.Entity<City>().HasData(city4);

            modelBuilder.Entity<Person>().HasData(person1);
            modelBuilder.Entity<Person>().HasData(person2);
            modelBuilder.Entity<Person>().HasData(person3);
            modelBuilder.Entity<Person>().HasData(person4);

            Language language1 = new Language(11, "Svenska");
            Language language2 = new Language(12, "Norska");
            Language language3 = new Language(13, "English");

            List<Language> languages1 = new List<Language>() { language1, language3 };
            List<Language> languages2 = new List<Language>() { language2, language3 };

            modelBuilder.Entity<Language>().HasData(language1);
            modelBuilder.Entity<Language>().HasData(language2);
            modelBuilder.Entity<Language>().HasData(language3);

            modelBuilder.Entity<PersonLanguage>().HasData(new PersonLanguage(1, 11));
            modelBuilder.Entity<PersonLanguage>().HasData(new PersonLanguage(2, 11));
            modelBuilder.Entity<PersonLanguage>().HasData(new PersonLanguage(3, 12));
            modelBuilder.Entity<PersonLanguage>().HasData(new PersonLanguage(4, 11));

            String roleAdminId = Guid.NewGuid().ToString();
            String roleUserId = Guid.NewGuid().ToString();
            String userId = Guid.NewGuid().ToString();
            String adminId = Guid.NewGuid().ToString();

            modelBuilder.Entity<ApplicationRole>().HasData(new ApplicationRole
            { 
                Id = roleAdminId, 
                Name = "Admin", 
                NormalizedName = "ADMIN" 
            });

            PasswordHasher <ApplicationUser> hasher = new PasswordHasher<ApplicationUser>();

            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id= adminId,
                UserName = "admin@admin.com",
                NormalizedEmail = "ADMIN@ADMIN.COM",
                NormalizedUserName="ADMIN",
                PasswordHash = hasher.HashPassword(null, "password"),
                FirstName = "Admin",
                LastName = "Adminsson",
                BirthDate = "1/1 1980"
            });

            modelBuilder.Entity<ApplicationRole>().HasData(new ApplicationRole
            {
                Id = roleUserId,
                Name = "User",
                NormalizedName = "USER"
            });

            modelBuilder.Entity<ApplicationUser>().HasData(new ApplicationUser
            {
                Id = userId,
                UserName = "user@user.com",
                NormalizedEmail = "USER@USER.COM",
                NormalizedUserName = "USER",
                PasswordHash = hasher.HashPassword(null, "password"),
                FirstName = "User",
                LastName = "Usersson",
                BirthDate = "1/1 1990"
            }); 

            //modelBuilder.Entity<IdentityUserRole<String>>().HasData(new IdentityUserRole<string> { RoleId = roleId, UserId = userId });

        }

    }
}
