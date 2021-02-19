using OdeToFood.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace OdeToFood.Data.Services
{
    public class InMemoryBacASableData : IStudentData
    {
        List<Student> students;

        public InMemoryBacASableData()
        {
            students = new List<Student>()
            {
                new Student(){StudentId = 1, FirstName = "Romain", LastName = "CAZE-SULFOURT", Age = 16, Description = "Eleve calme et serieux mais un peu rêveur et pas très studieux dans ses études", IsActive = true, Gender = Gender.male, Password = "tototiti"},
                new Student(){StudentId = 2, FirstName = "Ombeline", LastName = "CAZE-SULFOURT", Age = 9, Description = "Jeune, intelligente et capricieuse, a du mal à partager, nottament avec son frère", IsActive = true, Gender = Gender.female, Password = "tatatutu"},
                new Student(){StudentId = 3, FirstName = "Frédéric", LastName = "CAZE-SULFOURT", Age = 44, Description = "Intelligent et bosseur, aime évoluer dans sa vie et apprendre - raleur",IsActive = true, Gender = Gender.male},
                new Student(){StudentId = 4, FirstName = "Sabrina", LastName = "CAZE-SULFOURT", Age = 48, Description = "Femme jolie et intelligente mais parfois maniaque pour le rangement et l'ordre",IsActive = true, Gender = Gender.nonBinary},
                new Student(){StudentId = 5, FirstName = "Florin", LastName = "RUSSEN", Age = 43, Description = "Bon copain, aime le métal, serieux mais dort tard le matin",IsActive = true, Gender = Gender.nonBinary},
                new Student(){StudentId = 6, FirstName = "Monica", LastName = "RUSSEN", Age = 49, Description = "Femme de Florin, très intelligente et psychologue",IsActive = false, Gender = Gender.female},
                new Student(){StudentId = 7, FirstName = "Arnaud", LastName = "SULFOURT", Age = 41, Description = "Elève très perturbé et malade. A besoin d'aide à domicile pour mener sa vie à bien",IsActive = true, Gender = Gender.male},
                new Student(){StudentId = 8, FirstName = "Deborah", LastName = "SULFOURT", Age = 71, Description = "Elève très disciplinée mais très bavarde aussi",IsActive = true, Gender = Gender.female},
                new Student(){StudentId = 9, FirstName = "Colette", LastName = "SULFOURT", Age = 74, Description = "Elève brouillon qui aime surtout faire la fête et n'aime pas l'école",IsActive = true, Gender = Gender.female}
            };
        }

        /// <summary>
        /// Get all students list
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Student> GetAllStudents()
        {
            return students.OrderBy(s => s.StudentId);
        }

        /// <summary>
        /// Get the first student by gender in the parameter
        /// </summary>
        /// <param name="gender"></param>
        /// <returns></returns>
        public Student GetByGender(Gender gender)
        {
            return students.FirstOrDefault(s => s.Gender == gender);
        }

        /// <summary>
        /// Get one student by his id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Student GetById(int id)
        {
            return students.FirstOrDefault(s => s.StudentId == id);
        }

        /// <summary>
        /// Get one student by his last name
        /// </summary>
        /// <param name="lastName"></param>
        /// <returns></returns>
        public Student GetByLastName(string lastName)
        {
            return students.FirstOrDefault(s => s.LastName.ToUpper() == lastName.ToUpper());
        }

        /// <summary>
        /// Get all the students by gender defined in the parameter
        /// </summary>
        /// <param name="gender"></param>
        /// <returns></returns>
        public IEnumerable<Student> GetStudentsByGender(Gender gender)
        {
            return students.Where(s => s.Gender == gender);
        }
    }
}
