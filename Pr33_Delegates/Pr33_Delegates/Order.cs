using System;
using System.Collections.Generic;
using System.Text;

namespace Pr33_Delegates
{
    public class Order
    {
        public BonusProvider Bonus { get; set; }
        private List<Product> products = [];

        public void AddProduct(Product p)
        {
            products.Add(p);
        }

        public double GetValueOfProducts()
        {
            double value = 0;

            foreach(Product p in products)
            {
                value += p.Value;
            }

            return value;
        }

        public double GetBonus()
        {
            double value = GetValueOfProducts();
            return Bonus(value);
        }

        public double GetTotalPrice()
        {
            return GetValueOfProducts() - GetBonus();
        }
    }
}
