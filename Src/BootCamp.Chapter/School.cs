using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class School
    {
        public string Name { get; set; }

        public School()
        {
            Name = nameof(School);
        }
        public School(string name)
        {
            Name = name;
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
