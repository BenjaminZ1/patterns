using System;
using System.Collections.Generic;
using System.Text;

namespace prototype_pattern
{
    public interface ISalePricingStrategy
    {
        decimal GetTotal(Sale sale);
        object Clone();
    }
}