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
    //where T : IInterface requires T to implement a specific interface.
    //This enables calling interface methods on type parameter.
    //public interface IPrintable
    //{
    //    void Print();
    //}

    //public class Printer<T> where T : IPrintable
    //{
    //    public void PrintItem(T item)
    //    {
    //        item.Print();
    //    }
    //}
    #endregion
    #region 11
    //T must inherit from BaseClass
    //---//
    //public class Employee
    //{
    //    public string Name { get; set; }
    //}
    //
    //public class Company<T> where T : Employee
    //{
    //    public void Show(T emp)
    //    {
    //        Console.WriteLine(emp.Name);
    //    }
    #endregion
    #region 12
    //You can combine multiple constraints for a single type
    //parameter, and have different constraints for different type parameters.


    //public class Example<T>
    //where T : class, IComparable<T>, new()
    //{
    //    public T Create()
    //    {
    //        return new T();
    //    }
    //}
    #endregion
    #region 13
    //The default keyword in generics is used to return
    //the default value of a type T without knowing the actual type.
    //For value types : it returns values like 0, false
    //For reference types :it returns null
    #endregion
    #region 14
    //public class SafeList<T>
    //{
    //    private List<T> items = new List<T>();

    //    public void Add(T item)
    //    {
    //        items.Add(item);
    //    }

    //    public T Get(int index)
    //    {
    //        if (index < 0 || index >= items.Count)
    //            return default; 

    //        return items[index];
    //}
    #endregion
    #region 15
    //Covariance allows you to use a more derived type than originally specified.
    //Marked with out keyword. T can only appear in output positions.
    //-----//
    //public interface IProducer<out T>
    //{
    //    T GetItem();
    //}
    #endregion
    #region 16
    //Contravariance allows you to use a less derived type than originally specified.
    //Marked with in keyword. T can only appear in input positions.
    //----//
    //public interface IConsumer<in T>
    //{
    //    void Consume(T item);
    //}
    #endregion
    #region 17
    //Covariance (out)

    //Derived → Base
    //Output only (return)
    //IEnumerable<out T>
    //Producer of T
    //------//
    //Contravariance (in)
    //Base → Derived
    //Input only (parameter)
    //Action<in T>
    //Consumer of T

    #endregion
    #region 18
    //Each closed generic type has its own copy of static fields.
    



    #endregion
    #region 19
    //Generic classes can inherit from other generic or non - generic classes.
    //Several patterns are possible.
    //1: Inherit and Pass Type Parameter
    //2: Inherit with Concrete Type
    //3: Add New Type Parameter
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
