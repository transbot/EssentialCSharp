// 说明 : Checking for null isn't discussed yet.
#pragma warning disable CS8600 // Converting null literal or possible null value to non-nullable type
// 说明 : args is declared and referenced in the manuscript but now used because the listing is incomplete.
#pragma warning disable IDE0060 // Remove unused parameter
// 说明 : Attempting to use message outside of it's scope so it goes unused.
#pragma warning disable CS0219  // Variable is assigned but its value is never used

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_28;

public class Program
{
    public static void Main(string[] args)
    {
        #region INCLUDE
        string playerCount;
        Console.Write(
            "输入玩家数量(1或2):");
        playerCount = Console.ReadLine();
        if (playerCount != "1" && playerCount != "2")
        {
            #region HIGHLIGHT
            string message =
                "你输入了无效的玩家数量。";
            #endregion HIGHLIGHT
        }
        else
        {
            // ...
        }
        #if COMPILEERROR  //EXCLUDE
        #region HIGHLIGHT
        // ERROR: message is not in scope:
        Console.WriteLine(message);
        #endregion HIGHLIGHT
        #endif // COMPILEERROR  //EXCLUDE
        #endregion INCLUDE
    }
}
