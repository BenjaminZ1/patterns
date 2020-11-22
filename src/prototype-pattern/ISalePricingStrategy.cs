namespace prototype_pattern
{
    public interface ISalePricingStrategy
    {
        decimal GetTotal(Sale sale);
        object Clone();
    }
}