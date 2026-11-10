using IntelliTect.TestTools.Console;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter06.Listing06_12.Tests;

[TestClass]
public class EmployeeTests
{
    [TestMethod]
    public void DataStorage_ReadTrace()
    {
        const string expected =
            "将员工(Inigo Montoya)的信息写入文件。";

        Employee employee = new()
        {
            FirstName = "Inigo",
            LastName = "Montoya"
        };
        ConsoleAssert.Expect(expected, () =>
                   DataStorage.Store(employee));
    }
}
