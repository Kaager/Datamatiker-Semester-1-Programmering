using System;
using System.Collections.Generic;
using System.Text;

namespace Pr15_Disaheim
{
    public abstract class Merchandise : IValuable
    {
        public string ItemId { get; set; }

        public abstract double GetValue();

        public override string ToString()
        {
            return $"ItemId: {ItemId}";
        }
    }
}
