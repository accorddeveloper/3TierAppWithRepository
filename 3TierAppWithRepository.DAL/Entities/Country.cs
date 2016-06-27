using _3TierAppWithRepository.DAL.Abstracts;
using System.Collections.Generic;

namespace _3TierAppWithRepository.DAL.Entities
{
    public class Country : Entity<int>
    {
        public string Name { get; set; }

        public virtual IEnumerable<Person> Persons { get; set; }
    }
}