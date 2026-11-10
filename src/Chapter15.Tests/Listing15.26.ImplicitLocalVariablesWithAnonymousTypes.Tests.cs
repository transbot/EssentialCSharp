
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter15.Listing15_26.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void DictionaryInitialization()
    {
        string expected = @"双焦点眼镜 (1784)
留声机 (1877)

{ Title = 双焦点眼镜, YearOfPublication = 1784 }
{ Title = 留声机, YearOfPublication = 1877 }

{ Title = 双焦点眼镜, Year = 1784 }";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
        () =>
        {
            Program.Main();
        });
    }
}
