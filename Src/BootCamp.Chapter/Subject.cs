using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    public class Subject<TSubject> where TSubject : Subject
    {
        public string Name { get; set; }

        public Subject()
        {
            //Name = nameof(Subject);
        }

        public Subject(string name)
        {
            Name = name;
        }
    }

    public class Maths : Subject<Maths>
    {
        public Maths()
        {
            Name = nameof(Maths);
        }

        public Maths(string name)
        {
            Name = name;
        }
    }

    public class Art : Subject
    {
        public Art()
        {
            Name = nameof(Art);
        }

        public Art(string name)
        {
            Name = name;
        }
    }

    public class Music : Subject
    {
        public Music()
        {
            Name = nameof(Music);
        }

        public Music(string name)
        {
            Name = name;
        }
    }

    public class PE : Subject
    {
        public PE()
        {
            Name = nameof(PE);
        }

        public PE(string name)
        {
            Name = name;
        }
    }

    public class English : Subject
    {
        public English()
        {
            Name = nameof(English);
        }

        public English(string name)
        {
            Name = name;
        }
    }

    public class Programming : Subject
    {
        public Programming()
        {
            Name = nameof(Programming);
        }

        public Programming(string name)
        {
            Name = name;
        }
    }
}
