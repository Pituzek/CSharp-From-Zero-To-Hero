using BootCamp.Chapter.Hints;
using System;
using System.Collections.Generic;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {

            ITeacher<Subject> midTeach = new Teacher<Maths>();
            ITeacher<Art> artTeacher = new MiddleSchoolTeacher<Art>();

            MiddleSchoolTeacher<Maths> test = new MiddleSchoolTeacher<Maths>();

            MiddleSchoolStudent middleStudent = new MiddleSchoolStudent(Guid.NewGuid(), "Peter", "N");
            HighSchoolStudent highStudent = new HighSchoolStudent(Guid.NewGuid(), "Johnny", "W");
            ISubject mathMaterial2 = midTeach.ProduceMaterial();
            ISubject mathMaterial = midTeach.ProduceMaterial();
            Subject artMaterial = artTeacher.ProduceMaterial();
            middleStudent.LearnFrom<ITeacher<Subject>, ISubject>(midTeach, mathMaterial2);

            ///<summary>
            ///     Specific teachers produce material for a specific subject 
            ///     Students can learn from **any teacher** (by consuming the material a teacher produced)
            /// </summary>
            test1And2();

            ///<summary>
            ///     Specific schools have ability to add or get specific students
            ///</summary>
            test3();

            Console.ReadKey();
        }

        public static void test1And2()
        {
            //ITeacher<Maths> mathTeacher = new MathTeacher();
            //Maths mathMaterial = mathTeacher.ProduceMaterial();

            //ISchool<MiddleSchoolStudent> midSchool = new MiddleSchool();
            //MiddleSchoolStudent middleStudent = new MiddleSchoolStudent(Guid.NewGuid(), "Peter", "N");
            //middleStudent.LearnFrom<MathTeacher, Maths>((MathTeacher)mathTeacher,(Maths)mathMaterial);
            //midSchool.Add(middleStudent);
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

            MiddleSchool midTest = new MiddleSchool();
            midTest.Add(middleStudent2);
            Console.WriteLine(midTest.GetStudentById(middleStudent2.Id));

            IBuilding<MiddleSchoolStudent> mid2 = new MiddleSchool();
            mid2.Add(middleStudent2);
            Console.WriteLine(mid2.GetStudentById(middleStudent2.Id));

            midSchool.PrintStudentById(middleStudent2.Id);
        }
    }
}
