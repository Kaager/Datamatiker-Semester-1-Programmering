using System;
using System.Collections.Generic;
using System.Text;

namespace Pr31_ObserverPattern
{
    public class Student : Person, IObserver
    {
        private Academy _subject;
        public string Message { get; set; }
        
        public Student(Academy subject, string name)
            : base(name)
        {
            _subject = subject;
        }

        public void Update()
        {
            Message = _subject.Message;
            Console.WriteLine($"Studerende {Name} modtog nyheden '{Message}' fra akademiet {_subject.Name}");
        }
    }
}
