namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter03.Listing03_05;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        var patent1 =
            new { Title = "双焦点眼镜",
                YearOfPublication = "1784" };
        var patent2 =
            new { Title = "留声机",
                YearOfPublication = "1877" };

        Console.WriteLine(
            $"{patent1.Title} ({patent1.YearOfPublication})");
        Console.WriteLine(
            $"{patent2.Title} ({patent2.YearOfPublication})");
        #endregion INCLUDE
    }
}
