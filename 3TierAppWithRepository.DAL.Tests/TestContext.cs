using _3TierAppWithRepository.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3TierAppWithRepository.DAL.Tests
{
    public class TestContext : DbContext
    {
        public DbSet<Person> Persons { get; set; }
        public DbSet<Country> Countries { get; set; }

        public TestContext() : base("name=TestContext")
        {
            AppDomain.CurrentDomain.SetData("DataDirectory", System.IO.Directory.GetCurrentDirectory());
            Database.SetInitializer<TestContext>(new AlwaysCreateInitializer());
        }
    }

    public class AlwaysCreateInitializer : DropCreateDatabaseAlways<TestContext>
    {
        protected override void Seed(TestContext context)
        {
            var countries = new List<Country>
            {
                new Country { Name = "USA" },
                new Country { Name = "Russia" },
                new Country { Name = "Italy" },
                new Country { Name = "Spain" }
            };
            foreach (var country in countries)
                context.Countries.Add(country);

            base.Seed(context);
        }
    }
}
