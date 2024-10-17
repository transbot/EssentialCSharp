namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter12.Listing12_18;

#pragma warning disable 0693 // 禁止显示关于嵌套类型参数
                             // 与外部类型中的类型参数同名的警告
#region INCLUDE
public class Container<T, U>
{
    // 嵌套类已继承了类型参数。
    // 重用这些类型参数会显示警告。
    public class Nested<U>
    {
        #region HIGHLIGHT
        static void Method(T param0, U param1)
        #endregion HIGHLIGHT
        {
        }
    }
}
#endregion INCLUDE
