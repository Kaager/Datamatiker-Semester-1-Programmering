using System;
using System.Collections.Generic;
using System.Text;

namespace Pr31_ObserverPattern
{
    public class ConcreteObserver : Observer
    {
        private ConcreteSubject _subject;
        public int State { get; set; } = 0;

        public ConcreteObserver(ConcreteSubject subject)
        {
            _subject = subject;
        }

        public override void Update()
        {
            State = _subject.State;
        }
    }
}
