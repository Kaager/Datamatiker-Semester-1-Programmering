using System;
using System.Collections.Generic;
using System.Text;

namespace Pr15_Disaheim
{
    public interface IPersistable
    {
        void Save(string fileName);
        void Load(string fileName);
    }
}
