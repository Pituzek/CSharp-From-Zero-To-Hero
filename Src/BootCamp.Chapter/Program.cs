using BootCamp.Chapter.Hints;
using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            MiddleSchool middleSChool = new MiddleSchool();
            MiddleSchoolStudent middleStudent = new MiddleSchoolStudent(Guid.NewGuid(), "Peter", "N");
            MiddleSchoolStudent middleStudent2 = new MiddleSchoolStudent(Guid.NewGuid(), "John", "H");
            MiddleSchoolStudent middleStudent3 = new MiddleSchoolStudent(Guid.NewGuid(), "Aria", "J");

            ISchool<MiddleSchoolStudent> midSchool = new MiddleSchoolStudent();

            HighSchoolStudent highStudent = new HighSchoolStudent();

            middleSChool.Add(middleStudent);
            middleSChool.Add(middleStudent2);
            middleSChool.Add(middleStudent3);

            Console.WriteLine(middleSChool.GetStudentById(middleStudent2.Id));

            Console.ReadKey();
        }
    }
}
