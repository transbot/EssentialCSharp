namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_44;

#region INCLUDE
class Fruit { }
class Apple : Fruit { }
class Orange : Fruit { }

#region HIGHLIGHT
interface ICompareThings<in T>
{
    bool FirstIsBetter(T t1, T t2);
}
#endregion HIGHLIGHT

public class Program
{

    private class FruitComparer : ICompareThings<Fruit>
    {
        #region EXCLUDE
        #region Generated Interface Stub
        public bool FirstIsBetter(Fruit t1, Fruit t2)
        {
            throw new System.NotImplementedException();
        }
        #endregion Generated Interface Stub
        #endregion EXCLUDE
    }
    static void Main()
    {
        ICompareThings<Fruit> fc = new FruitComparer();

        Apple apple1 = new();
        Apple apple2 = new();
        Orange orange = new();

        // 一个水果comparer可以比较苹果与桔子:
        bool b1 = fc.FirstIsBetter(apple1, orange);
        // 或者苹果与苹果:
        bool b2 = fc.FirstIsBetter(apple1, apple2);
        // 这是合法的，因为接口是逆变的
        ICompareThings<Apple> ac = fc;
        // 这实际是一个水果comparer，所以仍然可以比较两个苹果
        bool b3 = ac.FirstIsBetter(apple1, apple2);
    }
}
#endregion INCLUDE
