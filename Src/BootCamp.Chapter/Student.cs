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
			Id = new Guid();
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
    }

	public class MiddleSchoolStudent : Student
	{
	}

	public class HighSchoolStudent : Student
	{
	}

	public class UniversityStudent : Student
	{
	}
}
