
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter16.Listing16_05.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void InvokingDelegateWithoutCheckingForNull()
    {
        string expected = @"1. delegateInvocations=0
2. 上下文关键字数量=29
3. delegateInvocations=29
4. 上下文关键字数量=29
5. delegateInvocations=58
6. delegateInvocations=87
7. selectionCache数量=29
8. delegateInvocations=87";

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(expected,
        () =>
        {
            Program.Main();
        });
    }
}