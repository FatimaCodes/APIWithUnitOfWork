using APIWithUnitOfWork.Data;
using APIWithUnitOfWork.IRepository;
using System.Threading.Tasks;
using System;

namespace APIWithUnitOfWork.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
        private IGenericRepository<Doctor> _doctors;
        private IGenericRepository<Country> _countries;
        private IGenericRepository<Category> _categories;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }
        public IGenericRepository<Country> Countries => _countries ??= new GenericRepository<Country>(_context);
        public IGenericRepository<Doctor> Doctors => _doctors ??= new GenericRepository<Doctor>(_context);
        public IGenericRepository<Category> Categories => _categories ??= new GenericRepository<Category>(_context);


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
