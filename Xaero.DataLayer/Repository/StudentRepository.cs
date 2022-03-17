using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xaero.DataLayer.Entities;
using Xaero.DataLayer.Repository.Abstracts;

namespace Xaero.DataLayer.Repository
{
    public class StudentRepository : IStudentRepository,IDisposable
    {
        private ApplicationDbContext _context;

        public StudentRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public void DeleteStudent(int studentID)
        {
            throw new NotImplementedException();
        }

        public Student GetStudentByID(int studentId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetStudents()
        {
           return _context.Students.ToList();
        }

        public void InsertStudent(Student student)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void UpdateStudent(Student student)
        {
            throw new NotImplementedException();
        }


        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _context.Dispose();
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
