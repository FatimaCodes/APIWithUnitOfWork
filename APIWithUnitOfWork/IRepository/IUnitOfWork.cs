using System.Threading.Tasks;
using System;
using System.Numerics;
using APIWithUnitOfWork.Data;
namespace APIWithUnitOfWork.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Doctor> Doctors { get; }
        //IGenericRepository<DoctorCategory> Types { get; }
        IGenericRepository<Country> Countries { get; }

        Task Save();
    }
}
