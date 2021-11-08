using BootCamp.Chapter.Hints;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class Teacher
    {
        public string Name { get; set; }

        public Teacher()
        {
            Name = nameof(Teacher);
        }

        public Teacher(string name)
        {
            Name = name;
        }
    }
    public class HighSchoolTeacher : Teacher
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

    public class MiddleSchoolTeacher : Teacher
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

    public class UniversityTeacher : Teacher
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
