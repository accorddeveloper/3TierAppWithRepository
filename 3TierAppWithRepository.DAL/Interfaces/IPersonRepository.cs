using _3TierAppWithRepository.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3TierAppWithRepository.DAL.Interfaces
{
    public interface IPersonRepository : IRepository<Person>
    {
        Person GetById(int id);
    }
}
