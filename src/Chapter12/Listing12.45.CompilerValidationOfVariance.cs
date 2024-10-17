// 重要：这个文件不能编译

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_45
{
    #region INCLUDE
    // 错误:  无效可变性，类型参数'T'变型无效
    interface IPairInitializer<in T>
    {
        void Initialize(IPair<T> pair);
    }
    // 假定上述代码合法，那么看看会在什么地方出错:
    public class FruitPairInitializer : IPairInitializer<Fruit>
    {
        // 初始化由一个苹果和一个桔子构成的pair
        public void Initialize(IPair<Fruit> pair)
        {
            pair.First = new Orange();
            pair.Second = new Apple();
        }
    }

    // ... 然后 ...
    #region EXCLUDE
    public class Program
    {
        public static void Main()
        {
            #endregion EXCLUDE
            var f = new FruitPairInitializer();
            // 如果逆变性合法，那么以下代码合法:
            IPairInitializer<Apple> a = f;
            // 现在，将一个桔子写入一对苹果中:
            a.Initialize(new Pair<Apple>());
            #region EXCLUDE
        }
    }
    #endregion EXCLUDE
    #endregion INCLUDE
}