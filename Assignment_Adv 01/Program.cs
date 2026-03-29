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
    #region Q04
    //A generic method declares its own type parameter(s). It can exist in both generic and non-generic classes.
    //The compiler often infers the type argument.
    //-------//
    //public static void Swap<T>(ref T a, ref T b)
    //{
    //    T temp = a;
    //    a = b;
    //    b = temp;
    //}
    #endregion
    #region Q05
    //public static T FindMax<T>(T a, T b) where T : IComparable<T>
    //{
    //    return a.CompareTo(b) > 0 ? a : b;
    //}
    #endregion
    #region 06
    //Generic interfaces define contracts with type parameters.
    //Classes implementing them specify the actual types.
    //------//
    //public interface IRepository<T>
    //{
    //    void Add(T item);
    //    T GetById(int id);
    //}
    #endregion
    #region Q07
    // T must be a value type
    //----/
    //public class ValueHolder<T> where T : struct
    //{
    //    public T Value { get; set; }
    //}
    #endregion
    #region Q08
    //T must be a reference type
    //-----//
    //public class RefHolder<T> where T : class
    //{
    //    public T Value { get; set; }
    //}
    #endregion
    #region Q09
    //T must have parameterless constructor 
    //------//
    //public class Factory<T> where T : new()
    //{
    //    public T Create()
    //    {
    //        return new T();
    //    }
    //}
    #endregion
    #region 10
    #endregion
    #region 11
    #endregion
    #region 12
    #endregion
    #region 13
    #endregion
    #region 14
    #endregion
    #region 15
    #endregion
    #region 16
    #endregion
    #region 17
    #endregion
    #region 18
    #endregion
    #region 19
    #endregion
    #region 20
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
