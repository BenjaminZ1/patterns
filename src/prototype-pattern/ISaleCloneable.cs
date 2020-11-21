using System;
using System.Collections.Generic;
using System.Text;

namespace prototype_pattern
{
    public interface ISaleCloneable
    {
        object ShallowClone();
        object DeepClone();
    }
}
