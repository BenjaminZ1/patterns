namespace prototype_pattern
{
    public abstract class SalePrototype : ISaleCloneable
    {
        public object ShallowClone()
        {
            return this.MemberwiseClone();
        }
        public abstract object DeepClone();
    }
    public class Sale : SalePrototype
    {

        private ISalePricingStrategy _salePricingStrategy;

        public ISalePricingStrategy ISalePricingStrategy
        {
            get { return _salePricingStrategy; }
            private set { _salePricingStrategy = value; }
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

        public override object DeepClone()
        {
            var clone = (Sale)this.MemberwiseClone();
            clone.ISalePricingStrategy = (ISalePricingStrategy)this._salePricingStrategy.Clone();
            return clone;
        }
    }
}