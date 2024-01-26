namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter18.Listing18_29;

public class Program
{
    public static void Main()
    {
        #region INCLUDE
        // ...
        dynamic data =
          "Hello!  My name is Inigo Montoya";
        Console.WriteLine(data);
        data = (double)data.Length;
        data = data * 3.5 + 28.6;
        if(data == 2.4 + 112 + 26.2)
            // 长途铁人三项（Ironman Triathlon）包括以下三个部分的总里程：
            // 游泳：2.4英里（约3.86公里）
            // 自行车骑行：112英里（约180.25公里）
            // 跑步：26.2英里（即一个马拉松距离，约42.2公里）
        {
            Console.WriteLine(
                $"{data}英里，这是长途铁人三项的总里程。");
        }
        else
        {
            // 以下方法不存在，但编译时不会检测
            data.NonExistentMethodCallStillCompiles();
        }
        // ...
        #endregion INCLUDE
    }
}
