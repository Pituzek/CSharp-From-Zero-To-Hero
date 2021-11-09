using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter.Hints
{
    // Leave it empty, because subjects are unrelated. Just for simulation
    // Alternatively use base Subject class.
    public interface ISubject { }

    public interface IClass<out TStudent> where TStudent : Student
    {
        TStudent GetStudentById(Guid id);
    }

    // For simulation you can store a specific teacher to school.
    // However for the interface based on requirements it is not needed.
    interface ISchool<TStudent> where TStudent : Student
    {
        // Missing:
        // Add
        // Get
        void Add(TStudent student);
        TStudent GetStudentById(Guid id);
    }

    public interface IStudent
    {
        //long Id { get; }
        Guid Id { get; }

        void LearnFrom<TTeacher, TSubject>(TTeacher teacher, TSubject subject)
            where TTeacher : ITeacher<TSubject>
            where TSubject : ISubject;
    }


    public interface ITeacher<TSubject> where TSubject : ISubject
    {
        TSubject ProduceMaterial();
    }
}
