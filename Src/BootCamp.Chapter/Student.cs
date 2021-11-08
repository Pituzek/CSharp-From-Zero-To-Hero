using BootCamp.Chapter.Hints;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class Student : IStudent
    {
		public Guid Id { get; }
		public string Name { get; set; }
		public string Surname { get; set; }

        long IStudent.Id => throw new NotImplementedException();

		public Student()
        {

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

		public void LearnFrom<TTeacher, TSubject>(TTeacher teacher)
            where TTeacher : ITeacher<TSubject>
            where TSubject : ISubject
        {
            throw new NotImplementedException();
        }
    }

	public class HighSchoolStudent : Student
	{
	}

	public class UniversityStudent : Student
	{
	}
}
