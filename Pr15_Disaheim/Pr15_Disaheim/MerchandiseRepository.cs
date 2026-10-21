using System;
using System.Collections.Generic;
using System.Text;

namespace Pr15_Disaheim
{
    public class MerchandiseRepository
    {
        private List<Merchandise> merchandises = new();

        public void AddMerchandise(Merchandise merchandise)
        {
            merchandises.Add(merchandise);
        }

        public Merchandise? GetMerchandise(string itemId)
        {
            return merchandises.Find(someMerch => someMerch.ItemId == itemId);
        }

        public double GetTotalValue()
        {
            double totalValue = 0;
            Utility util = new();

            foreach (Merchandise merch in merchandises)
            {
                totalValue += util.GetValueOfMerchandise(merch);
            }
            return totalValue;
        }
    }
}
