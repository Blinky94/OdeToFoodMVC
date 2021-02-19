using OdeToFood.Data.Models;
using System.Collections.Generic;

namespace OdeToFood.Data.Services
{
    public interface IStudentData
    {
        IEnumerable<Student> GetAllStudents();
        Student GetById(int id);
        Student GetByLastName(string lastName);
        Student GetByGender(Gender gender);
        IEnumerable<Student> GetStudentsByGender(Gender gender);
    }
}
