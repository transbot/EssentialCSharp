namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_40;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        int x;
        x = (-7 >> 2); // 11111111111111111111111111111001变成
                       // 11111111111111111111111111111110
                       // 输出"x = -2。"
        Console.WriteLine($"x = {x}。");
        #endregion INCLUDE
    }
}
