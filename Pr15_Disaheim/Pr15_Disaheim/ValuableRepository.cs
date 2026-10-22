using System;
using System.Collections.Generic;
using System.Text;

namespace Pr15_Disaheim
{
    public class ValuableRepository
    {
        private List<IValuable> valuables = new();

        public void AddValuable(IValuable valuable)
        {
            valuables.Add(valuable);
        }

        public IValuable GetValuable(string id)
        {
            foreach (IValuable valuable in valuables)
            {
                if (valuable is Merchandise merch)
                {
                    if (id == merch.ItemId)
                        return valuable;
                }
                else if (valuable is Course aCourse)
                {
                    if (id == aCourse.Name)
                        return aCourse;
                }
            }
            throw new KeyNotFoundException($"No valuable with ID '{id}' found.");
        }

        public double GetTotalValue()
        {
            double totalValue = 0;
            foreach(IValuable v in valuables)
            {
                totalValue += v.GetValue();
            }
            return totalValue;
        }

        public int Count()
        {
            return valuables.Count;
        }
    }
}
