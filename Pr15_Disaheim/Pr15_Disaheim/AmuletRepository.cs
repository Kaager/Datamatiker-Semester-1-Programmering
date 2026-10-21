using System;
using System.Collections.Generic;
using System.Text;

namespace Pr15_Disaheim
{
    public class AmuletRepository
    {
        private List<Amulet> amulets = new();

        public void AddAmulet(Amulet amulet)
        {
            amulets.Add(amulet);
        }

        public Amulet? GetAmulet(string itemId)
        {
            // See BookRepository for alternative
            return amulets.Find(amuletX => amuletX.ItemId == itemId);
        }

        public double GetTotalValue()
        {
            double totalValue = 0;
            Utility util = new();

            foreach (Amulet amulet in amulets)
            {
                totalValue += util.GetValueOfAmulet(amulet);
            }
            return totalValue;
        }
    }
}
