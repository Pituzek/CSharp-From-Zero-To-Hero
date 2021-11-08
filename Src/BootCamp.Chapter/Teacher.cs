using BootCamp.Chapter.Hints;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class Teacher<TSubject> : ITeacher<TSubject> where TSubject : Subject, new()
    {
        public string Name { get; set; }

        public Teacher()
        {
            //Name = nameof(Teacher);
        }

        public Teacher(string name)
        {
            Name = name;
        }

        public TSubject ProduceMaterial()
        {
            //TSubject t = new TSubject();
            return new TSubject();
        }
    }
    public class HighSchoolTeacher : Teacher<Subject>
    {
        public HighSchoolTeacher()
        {
            Name = nameof(HighSchoolTeacher);
        }

        public HighSchoolTeacher(string name)
        {
            Name = name;
        }
    }

    public class MiddleSchoolTeacher : Teacher<Subject>
    {
        public MiddleSchoolTeacher()
        {
            Name = nameof(MiddleSchoolTeacher);
        }

        public MiddleSchoolTeacher(string name)
        {
            Name = name;
        }
    }

    public class UniversityTeacher : Teacher<Subject>
    {
        public UniversityTeacher()
        {
            Name = nameof(UniversityTeacher);
        }

        public UniversityTeacher(string name)
        {
            Name = name;
        }
    }

}
