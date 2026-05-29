namespace DesingPatternSamples.Behavioral.Iterator
{
    // Iterator Interface
    // This is going to be an interface defining the operations for accessing and traversing elements in a sequence.
    public interface IAbstractIterator
    {
        Employee First();
        Employee Next();
        bool IsCompleted { get; }
    }
}
