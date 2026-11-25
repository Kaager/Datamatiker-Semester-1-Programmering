using System;
using System.Collections.Generic;
using System.Text;

namespace Pr31_ObserverPattern
{
    public class Academy : Organization, ISubject
    {
        private List<IObserver> _students = new();
        private string _message;
        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                Notify();
            }
        }

        public Academy(string name, string address) 
            : base(name)
        {
            Address = address;
        }

        public void Attach(IObserver o)
        {
            _students.Add(o);
        }

        public void Detach(IObserver o)
        {
            _students.Remove(o);
        }

        public void Notify()
        {
            foreach(IObserver o in _students)
            {
                o.Update();
            }
        }
    }
}
