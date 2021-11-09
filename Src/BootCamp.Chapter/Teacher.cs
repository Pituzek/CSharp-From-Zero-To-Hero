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
            Name = nameof(TSubject);
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
    public class MathTeacher : Teacher<Maths>
    {
        public MathTeacher()
        {
            Name = nameof(MathTeacher);
        }

        public MathTeacher(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return string.Format($"{Name}");
        }
    }

    public class ArtTeacher : Teacher<Art>
    {
        public ArtTeacher()
        {
            Name = nameof(ArtTeacher);
        }

        public ArtTeacher(string name)
        {
            Name = name;
        }
    }

    public class MusicTeacher : Teacher<Music>
    {
        public MusicTeacher()
        {
            Name = nameof(MusicTeacher);
        }

        public MusicTeacher(string name)
        {
            Name = name;
        }
    }
    public class PETeacher : Teacher<PE>
    {
        public PETeacher()
        {
            Name = nameof(PETeacher);
        }

        public PETeacher(string name)
        {
            Name = name;
        }
    }

    public class EnglishTeacher : Teacher<English>
    {
        public EnglishTeacher()
        {
            Name = nameof(EnglishTeacher);
        }

        public EnglishTeacher(string name)
        {
            Name = name;
        }
    }

    public class ProgrammingTeacher : Teacher<Programming>
    {
        public ProgrammingTeacher()
        {
            Name = nameof(ProgrammingTeacher);
        }

        public ProgrammingTeacher(string name)
        {
            Name = name;
        }
    }

}
