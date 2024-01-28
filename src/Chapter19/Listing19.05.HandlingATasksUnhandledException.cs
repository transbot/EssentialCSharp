namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter19.Listing19_05;

#region INCLUDE
using System;
using System.Threading.Tasks;

public static class Program
{
    public static void Main()
    {
        // .NET 4.5之前Task.Run()不可用，要改为使用
        // Task.Factory.StartNew<string>()
        Task task = Task.Run(() =>
        {
            throw new InvalidOperationException();
        });

        try
        {
            task.Wait();
        }
        catch(AggregateException exception)
        {
            exception.Handle(eachException =>
            {
                Console.WriteLine(
                    $"错误: { eachException.Message }");
                return true;
            });
        }
    }
}
#endregion INCLUDE
