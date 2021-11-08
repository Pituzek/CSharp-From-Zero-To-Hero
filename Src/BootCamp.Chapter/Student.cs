using BootCamp.Chapter.Hints;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class Student
    {
		public Guid Id { get; }
		public string Name { get; set; }
		public string Surname { get; set; }

		public Student()
        {
			Id = Guid.NewGuid();
        }

        public Student(Guid id)
		{
			Id = id;
			Name = "";
			Surname = "";
		}

		public Student(Guid id, string name, string surname)
		{
			Id = id;
			Name = name;
			Surname = surname;
		}

        public override string ToString()
        {
			return String.Format($"{Name} {Surname}");
        }
    }

	public class MiddleSchoolStudent : Student
	{
		public MiddleSchoolStudent() : base()
		{
		}

		public MiddleSchoolStudent(Guid id) : base (id)
		{
		}

		public MiddleSchoolStudent(Guid id, string name, string surname) : base(id, name, surname)
		{
		}
	}

	public class HighSchoolStudent : Student
	{
		public HighSchoolStudent() : base()
		{
		}

		public HighSchoolStudent(Guid id) : base(id)
		{
		}

		public HighSchoolStudent(Guid id, string name, string surname) : base(id, name, surname)
		{
		}
	}

	public class UniversityStudent : Student
	{
		public UniversityStudent() : base()
		{
		}

		public UniversityStudent(Guid id) : base(id)
		{
		}

		public UniversityStudent(Guid id, string name, string surname) : base(id, name, surname)
		{
		}
	}
}
