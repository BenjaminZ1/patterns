namespace prototype_pattern
{
    public interface ISaleCloneable
    {
        object ShallowClone();
        object DeepClone();
    }
}
