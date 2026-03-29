namespace Assignment_Adv_01
{
    #region Q01
    //A generic class uses type parameters that are replaced with actual types when you create an instance.
    //The type parameter T acts as a placeholder.
    //-------//
    //We use generics to make classes, methods,
    //and interfaces work with different data types while maintaining type safety
    //and code reusability.

    #endregion
    #region Q02
    //public class Container<T>
    //{
    //    private T item;

    //    public void Add(T value)
    //    {
    //        item = value;
    //    }

    //    public T Get()
    //    {
    //        return item;
    //    }
    //}
    #endregion
    #region Q03
    //Generic classes can have multiple type parameters.
    //Common examples: Dictionary<TKey, TValue>, Tuple<T1, T2>
    //public class Pair<TFirst, TSecond>
    //{
    //    public TFirst First { get; set; }
    //    public TSecond Second { get; set; }

    //    public Pair(TFirst first, TSecond second)
    //    {
    //        First = first;
    //        Second = second;
    //    }

    //    public void Deconstruct(out TFirst first, out TSecond second)
    //    {
    //        first = First;
    //        second = Second;
    //    }
    //}

    #endregion
    internal class Program
    {
        //static void Main(string[] args)
        //{

        //    Pair<int, string> p = new Pair<int, string>(1, "Hello");

        //    Console.WriteLine(p.First);
        //    Console.WriteLine(p.Second);
        //}
    }
}
