using _3TierAppWithRepository.DAL.Interfaces;
using _3TierAppWithRepository.DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3TierAppWithRepository.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private DbContext _context;
        private bool disposed = false;

        public UnitOfWork(DbContext context)
        {
            _context = context;
            Countries = new CountryRepository(_context);
            Persons = new PersonRepository(_context);
        }

        public ICountryRepository Countries { get; private set; }

        public IPersonRepository Persons { get; private set; }

        public int Commit()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
                _context.Dispose();

            disposed = true;
        }
    }
}
