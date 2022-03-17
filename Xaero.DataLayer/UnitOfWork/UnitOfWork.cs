using System;
using Xaero.DataLayer.Entities;
using Xaero.DataLayer.Repository;

namespace Xaero.DataLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork,IDisposable
    {
        private ApplicationDbContext context;
        private GenericRepository<Student> studentRepository;
        public UnitOfWork(ApplicationDbContext _context)
        {
            context = _context;
        }
        public GenericRepository<Student> StudentRepository
        {
            get
            {

                if (studentRepository == null)
                {
                    studentRepository = new GenericRepository<Student>(context);
                }
                return studentRepository;
            }
        }


        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
