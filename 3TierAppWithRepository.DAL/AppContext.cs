using _3TierAppWithRepository.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3TierAppWithRepository.DAL
{
    public class AppContext :DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Country> Countries { get; set; }
        public AppContext(string connectionString): base(connectionString)
        {
            Database.SetInitializer<AppContext>(new AppDbIntializer());
        }
    }

    public class AppDbIntializer : DropCreateDatabaseIfModelChanges<AppContext>
    {
        protected override void Seed(AppContext context)
        {
            var countries = new List<Country>
            {
                new Country { Name = "USA" },
                new Country { Name = "Russia" },
                new Country { Name = "Italy" }
            };
            foreach (var country in countries)
                context.Countries.Add(country);

            var persons = new List<Person>
            {
                new Person { FirstName="Sergei", LastName = "Trofimov", Country = countries[1] },
                new Person { FirstName="Anton", LastName = "Pegushin", Country = countries[0] }
            };
            foreach (var person in persons)
                context.Persons.Add(person);

            base.Seed(context);
        }
    }
}
