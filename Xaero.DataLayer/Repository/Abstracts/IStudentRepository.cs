using System;
using System.Collections.Generic;
using System.Text;
using Xaero.DataLayer.Entities;

namespace Xaero.DataLayer.Repository.Abstracts
{
    public interface IStudentRepository
    {
            IEnumerable<Student> GetStudents();
            Student GetStudentByID(int studentId);
            void InsertStudent(Student student);
            void DeleteStudent(int studentID);
            void UpdateStudent(Student student);
            void Save();
    }
}
