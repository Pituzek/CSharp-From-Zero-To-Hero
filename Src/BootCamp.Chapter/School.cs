using BootCamp.Chapter.Hints;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class School<TStudent> : ISchool<TStudent> where TStudent : Student
    {
        public string Name { get; set; }
        public TStudent student;
        public List<TStudent> _studentList { get; set; }

        public School()
        {
            Name = nameof();
        }
        public School(string name)
        {
            Name = name;
        }

        public void Add(List<TStudent> student)
        {
            _studentList.Add(student);
        }

        public void Get<TStudent1>(Guid id)
        {
            throw new NotImplementedException();
        }
    }

    public class MiddleSchool : School
    {
        public MiddleSchool()
        {
            Name = nameof(MiddleSchool);
        }

        public MiddleSchool(string name) : base(name)
        {
        }
    }

    public class HighSchool : School
    {
        public HighSchool()
        {
            Name = nameof(HighSchool);
        }

        public HighSchool(string name) : base(name)
        {
        }
    }

    public class University : School
    {
        public University()
        {
            Name = nameof(University);
        }

        public University(string name) : base(name)
        {
        }
    }
}
