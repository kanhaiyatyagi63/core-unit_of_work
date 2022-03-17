
using Xaero.DataLayer.Entities;
using Xaero.DataLayer.Repository;

namespace Xaero.DataLayer.UnitOfWork
{
    public interface IUnitOfWork
    {
        GenericRepository<Student> StudentRepository { get; }
        void Save();
    }
}
