using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Pr31_ObserverPattern
{
    public class ConcreteSubject : Subject
    {
        private int _state = 0;
        public int State
        {
            get => _state;
            set 
            {
                _state = value;
                Notify();
            }
        }
    }
}
