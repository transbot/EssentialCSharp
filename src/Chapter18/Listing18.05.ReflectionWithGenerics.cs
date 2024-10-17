namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_05;

#region INCLUDE

public class Program
{
    public static void Main()
    {
        Type type;
        type = typeof(System.Nullable<>);
        Console.WriteLine($"System.Nullable<>是否包含泛型参数：" +
            $"{type.ContainsGenericParameters}");
        Console.WriteLine($"System.Nullable<>是否泛型类型：" +
            $"{type.IsGenericType}");

        type = typeof(System.Nullable<DateTime>);
        Console.WriteLine($"System.Nullable<DateTime>是否包含泛型参数：" +
            $"{type.ContainsGenericParameters}");
        Console.WriteLine($"System.Nullable<DateTime>是否泛型类型：" +
            $"{type.IsGenericType}");
    }
}
#endregion INCLUDE
