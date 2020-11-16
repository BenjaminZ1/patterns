using System;
using System.Collections.Generic;
using System.Text;

namespace prototype_pattern
{
    public class Sale : ISaleCloneable
    {
        
        private ISalePricingStrategy _salePricingStrategy;

        public ISalePricingStrategy ISalePricingStrategy
        {
            get { return _salePricingStrategy; }
        }
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

        private void SetSalePricingStrategy(ISalePricingStrategy salePricingStrategy)
        {
            _salePricingStrategy = salePricingStrategy;
        }

        public object ShallowClone()
        {
            return this.MemberwiseClone() as Sale;
        }

        public object DeepClone()
        {
            var clone = (Sale)this.MemberwiseClone() ;
            clone.SetSalePricingStrategy((ISalePricingStrategy)this._salePricingStrategy.Clone());
            return clone;
        }
    }
}