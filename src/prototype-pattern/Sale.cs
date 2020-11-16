using System;
using System.Collections.Generic;
using System.Text;

namespace prototype_pattern
{
    public class Sale : ISaleCloneable
    {
        
        private readonly ISalePricingStrategy _salePricingStrategy;

        public string Name { get; set; }
        public decimal Price { get; set; }


        public Sale(string name, decimal price, ISalePricingStrategy salePricingStrategy)
        {
            Name = name;
            Price = price;
            _salePricingStrategy = salePricingStrategy;
        }

        public decimal GetTotal()
        {
            return _salePricingStrategy.GetTotal(this);
        }

        public ISaleCloneable Clone()
        {
            return this.MemberwiseClone() as ISaleCloneable;
        }
    }
}