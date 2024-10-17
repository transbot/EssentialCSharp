namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter10.Listing10_07;

using Microsoft.Extensions.Logging;

#region INCLUDE
public sealed class Program
{
    public static void Main(string[] args)
    {
        using ILoggerFactory loggerFactory =
            LoggerFactory.Create(builder =>
            builder.AddConsole().AddDebug());

        ILogger logger = loggerFactory.CreateLogger<Program>();

        logger.LogInformation($@"医院紧急代码: = '{
            string.Join("', '", args)}'");
        // ...

        logger.LogWarning("测试紧急事件...");
        // ...
    }
}
#endregion INCLUDE
