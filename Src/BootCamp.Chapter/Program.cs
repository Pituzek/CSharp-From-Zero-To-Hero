using BootCamp.Chapter.Hints;
using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {

            ///<summary>
            ///     Specific teachers produce material for a specific subject  
            /// </summary>
            test2();

            ///<summary>
            ///     Specific schools have ability to add or get specific students
            ///</summary>
            test3();

            Console.ReadKey();
        }

        public static void test2()
        {
            ITeacher<Maths> mathTeacher = new Teacher();

        }

        public static void test3()
        {

            MiddleSchoolStudent middleStudent = new MiddleSchoolStudent(Guid.NewGuid(), "Peter", "N");
            MiddleSchoolStudent middleStudent2 = new MiddleSchoolStudent(Guid.NewGuid(), "John", "H");
            MiddleSchoolStudent middleStudent3 = new MiddleSchoolStudent(Guid.NewGuid(), "Aria", "J");

            ISchool<MiddleSchoolStudent> midSchool = new MiddleSchool();
            ISchool<HighSchoolStudent> highSchool = new HighSchool();

            HighSchoolStudent highStudent = new HighSchoolStudent();
            //midSchool.Add(highStudent);

            midSchool.Add(middleStudent);
            midSchool.Add(middleStudent2);
            midSchool.Add(middleStudent3);

            highSchool.Add(highStudent);

            Console.WriteLine(midSchool.GetStudentById(middleStudent2.Id));
        }
    }
}
