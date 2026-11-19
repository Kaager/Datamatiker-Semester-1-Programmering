using System;
using System.Collections.Generic;
using System.Text;

namespace Pr31_ObserverPattern
{
    public abstract class Subject
    {
        private List<Observer> observers = [];

        public void Attach(Observer o)
        {
            observers.Add(o);
        }

        public void Detach(Observer o)
        {
            observers.Remove(o);
        }

        public void Notify()
        {
            foreach (Observer o in observers)
            {
                o.Update();
            }
        }
    }
}
