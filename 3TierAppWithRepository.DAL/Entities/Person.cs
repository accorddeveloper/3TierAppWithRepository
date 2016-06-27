using _3TierAppWithRepository.DAL.Abstracts;

namespace _3TierAppWithRepository.DAL.Entities
{
    public class Person : Entity<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
