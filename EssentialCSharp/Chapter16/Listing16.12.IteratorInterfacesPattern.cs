namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_12
{
    using System.Collections;
    using System.Collections.Generic;

    public class BinaryTree<T> :
    IEnumerable<T>
    {
        public BinaryTree(T value)
        {
            Value = value;
        }

        #region IEnumerable<T>
        public IEnumerator<T> GetEnumerator()
        {
            // ...
            return new List<T>.Enumerator(); // This will be implemented in 16.16
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            // ...
            return GetEnumerator(); // This will be implemented in 16.16
        }
        #endregion IEnumerable<T>

        public T Value
        { get; private set; }
        public Pair<BinaryTree<T>> SubItems
        { get; private set; }
    }

    public struct Pair<T>
    {
        public Pair(T first, T second)
            : this()
        {
            First = first;
            Second = second;
        }
        public T First { get; private set; }
        public T Second { get; private set; }
    }
}
