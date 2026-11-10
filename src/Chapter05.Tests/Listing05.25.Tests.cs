
using IntelliTect.TestTools.Console;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter05.Listing05_25.Tests;

[TestClass]
public class SpecifyingParametersByNameTests
{
    [TestMethod]
    public void SpecifyingParametersByName_WithNamedParameters_WritesToConsole()
    {
        const string expected = "名字: Inigo 中间名:  姓氏: Montoya";

        ConsoleAssert.Expect(expected, () => SpecifyingParametersByName.Main());
    }

    [TestMethod]
    public void SpecifyingParametersByName_WithNamedParametersInReverseOrder_WritesToConsole()
    {
        const string expected = "名字: Inigo 中间名: MiddleName 姓氏: Montoya";

        ConsoleAssert.Expect(expected, () => SpecifyingParametersByName.DisplayGreeting(firstName: "Inigo", middleName: "MiddleName", lastName: "Montoya"));
    }
}
