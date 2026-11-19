using System;
using System.Collections.Generic;
using System.Text;

namespace Pr31_ObserverPattern
{
    public class Student : Observer
    {
        private Academy _subject;
        public string Message { get; set; }
        public string Name { get; }
        
        public Student(Academy subject, string name)
        {
            _subject = subject;
            Name = name;
        }

        public override void Update()
        {
            Message = _subject.Message;
            Console.WriteLine($"Studerende {Name} modtog nyheden '{Message}' fra akademiet {_subject.Name}");
        }
    }
}
