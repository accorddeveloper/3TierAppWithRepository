using _3TierAppWithRepository.DAL.Abstracts;
using _3TierAppWithRepository.DAL.Entities;
using _3TierAppWithRepository.DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace _3TierAppWithRepository.DAL.Repositories
{
    public class PersonRepository : Repository<Person>, IPersonRepository
    {
        public PersonRepository(DbContext context) : base(context)
        {
        }

        public Person GetById(int id)
        {
            return _dbset.Include(p => p.Country).Where(p => p.Id == id).FirstOrDefault();
        }

        public override IEnumerable<Person> GetAll()
        {
            return _dbset.Include(p => p.Country).AsEnumerable();
        }
    }
}
