using BootCamp.Chapter.Hints;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    //public class School<TStudent> : ISchool<TStudent>, IClass<TStudent> where TStudent : Student
    public class School<TStudent> : IBuilding<TStudent> where TStudent : Student
    {
        public string Name { get; set; }

        public List<TStudent> _studentList { get; set; } = new List<TStudent>();

        public School() : this ("School", new List<TStudent>())
        {
        }

        public School(string name) : this(name, new List<TStudent>())
        {
        }

        public School(string name, List<TStudent> studentsList)
        {
            Name = name;
            _studentList = studentsList;
        }

        public void Add(TStudent student)
        {
            _studentList?.Add(student);
        }

        public void PrintStudentById(Guid id)
        {
            foreach (var student in _studentList)
            {
                if (student?.Id == id)
                {
                    Console.WriteLine($"{student.Name} {student.Id}");
                }
            }
        }
        public TStudent GetStudentById(Guid id)
        {
            foreach (var student in _studentList)
            {
                if (student?.Id == id) return student;
            }

            return null;
        }
    }

    public class MiddleSchool : School<MiddleSchoolStudent>
    {
        public MiddleSchool() : base(nameof(MiddleSchool), new List<MiddleSchoolStudent>())
        {
        }

        public MiddleSchool(string name) : base(name, new List<MiddleSchoolStudent>())
        {
        }

        public MiddleSchool(string name, List<MiddleSchoolStudent> studentsList) : base(name, studentsList)
        {
        }
    }

    public class HighSchool : School<HighSchoolStudent>
    {
        public HighSchool() : base(nameof(MiddleSchool), new List<HighSchoolStudent>())
        {
        }

        public HighSchool(string name) : base(name, new List<HighSchoolStudent>())
        {
        }

        public HighSchool(string name, List<HighSchoolStudent> studentsList) : base(name, studentsList)
        {
        }
    }

    public class University : School<UniversityStudent>
    {
        public University() : base(nameof(MiddleSchool), new List<UniversityStudent>())
        {
        }

        public University(string name) : base(name, new List<UniversityStudent>())
        {
        }

        public University(string name, List<UniversityStudent> studentsList) : base(name, studentsList)
        {
        }
    }
}
