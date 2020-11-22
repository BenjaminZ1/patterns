namespace prototype_pattern
{
    public class SalePricingStrategyFixedDiscount : ISalePricingStrategy
    {
        private readonly decimal _fixedDiscount;
        private readonly bool _discountCondition;

        public SalePricingStrategyFixedDiscount(decimal fixedDiscount, bool discountCondition)
        {
            _fixedDiscount = fixedDiscount;
            _discountCondition = discountCondition;
        }
        public decimal GetTotal(Sale sale)
        {
            if (_discountCondition)
                return sale.Price - _fixedDiscount;
            return sale.Price;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
