using System;
using System.Collections.Generic;
using System.Text;

namespace Pr15_Disaheim
{
    public class Controller
    {
        public ValuableRepository ValuableRepo { get; set; }

        public Controller()
        {
        }

        public void AddToList(IValuable valuable)
        {
            ValuableRepo.AddValuable(valuable);
        }
    }
}
