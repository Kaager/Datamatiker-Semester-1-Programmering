using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Text;

namespace Pr31_ObserverPattern
{
    public interface ISubject
    {
        void Attach(IObserver o);
        void Detach(IObserver o);
        void Notify();
    }
}
