namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_28;

#region INCLUDE
public class Program
{
    public static void Main()
    {
        var patent1 =
            new
            {
                Title = "双焦点眼镜",
                YearOfPublication = "1784"
            };

        var patent2 =
            new
            {
                YearOfPublication = "1877",
                Title = "留声机"
            };

        var patent3 =
            new
            {
                patent1.Title,
                Year = patent1.YearOfPublication
            };

        // 错误: 无法将类型'AnonymousType#2'隐式转换为'AnonymousType#1'
        // patent1 = patent2; // 撤消注释将无法编译

        // 错误: 无法将类型'AnonymousType#3'隐式转换为'AnonymousType#1'
        // patent1 = patent3; // 撤消注释将无法编译

        // 错误: 无法为属性或索引器'AnonymousType#1.Title'赋值 -- 它是只读的
        // patent1.Title = "瑞士奶酪";  // 撤消注释将无法编译
    }
}
#endregion INCLUDE
