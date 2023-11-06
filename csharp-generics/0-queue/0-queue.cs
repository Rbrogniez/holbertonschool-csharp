public class Queue<T>
{
    /// <summary>
    /// Returns the type of elements stored in the queue.
    /// </summary>
    /// <returns>The <see cref="System.Type"/> of the elements in the queue.</returns>
    public Type CheckType()
    {
        return typeof(T);
    }
}
