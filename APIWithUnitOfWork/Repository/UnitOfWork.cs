using APIWithUnitOfWork.Data;
using APIWithUnitOfWork.IRepository;
using System.Threading.Tasks;
using System;

namespace APIWithUnitOfWork.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        private IGenericRepository<Country> _countries;
        private IGenericRepository<Doctor> _doctors;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }
        public IGenericRepository<Country> Countries => _countries ??= new GenericRepository<Country>(_context);
        public IGenericRepository<Doctor> Hotels => _doctors ??= new GenericRepository<Doctor>(_context);

        public IGenericRepository<Doctor> Doctors => throw new NotImplementedException();

        public IGenericRepository<Category> Categories => throw new NotImplementedException();

        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }

}
