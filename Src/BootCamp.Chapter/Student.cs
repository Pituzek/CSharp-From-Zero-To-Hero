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

		public Student() : this(Guid.NewGuid(), "", "")
        {
		}

		public Student(Guid id) : this (id, "", "")
		{
		}

		public Student(Guid id, string name) : this(id, name, "")
		{
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

        public void LearnFrom<TTeacher, TSubject>(TTeacher teacher, TSubject subject)
            where TTeacher : ITeacher<TSubject>
            where TSubject : ISubject
        {
			Console.WriteLine($"Learning {subject.ToString()} from {teacher.ToString()}");
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
