using BootCamp.Chapter.Hints;
using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class Subject : ISubject
    {
        public string Name { get; set; }

        public Subject()
        {
            Name = nameof(Subject);
        }

        public Subject(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return string.Format($"{Name}");
        }
    }

    public class Maths : Subject, ISubject
    {
        public Maths()
        {
            Name = nameof(Maths);
        }

        public Maths(string name) : base(name)
        {
        }

        public override string ToString()
        {
            return string.Format($"{Name}");
        }
    }

    public class Art : Subject, ISubject
    {
        public Art()
        {
            Name = nameof(Art);
        }

        public Art(string name) : base(name)
        {
        }

        public override string ToString()
        {
            return string.Format($"{Name}");
        }
    }

    public class Music : Subject, ISubject
    {
        public Music()
        {
            Name = nameof(Music);
        }

        public Music(string name) : base(name)
        {
        }
        
        public override string ToString()
        {
            return string.Format($"{Name}");
        }
    }

    public class PE : Subject, ISubject
    {
        public PE()
        {
            Name = nameof(PE);
        }

        public PE(string name) : base(name)
        {
        }
                
        public override string ToString()
        {
            return string.Format($"{Name}");
        }
    }

    public class English : Subject, ISubject
    {
        public English()
        {
            Name = nameof(English);
        }

        public English(string name) : base(name)
        {
        }
                
        public override string ToString()
        {
            return string.Format($"{Name}");
        }
    }

    public class Programming : Subject, ISubject
    {
        public Programming()
        {
            Name = nameof(Programming);
        }

        public Programming(string name) : base(name)
        {
        }
                
        public override string ToString()
        {
            return string.Format($"{Name}");
        }
    }
}
