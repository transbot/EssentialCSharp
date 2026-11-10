using AddisonWesley.Michaelis.EssentialCSharp.Shared;

namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter04.Listing04_07.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void MainTest()
    {
        string netCoreApp3expected =
$@"{4.2D} != {4.2000002861023D} - True
{4.2} != {4.20000028610229} - True
(float){4.2F}M != {4.2F}F - True
{4.20000028610229} != {4.2} - True
{4.2F}F != {4.2D}D - True
{4.19999980926514D} != {4.2D} - True
{4.2F}F != {4.2D}D - True";

        string expected =
            $@"{4.2D} != {4.2000002861023D} - True
{4.2} != {4.200000286102295} - True
(float){4.2F}M != {4.2000003F}F - True
{4.200000286102295} != {4.2} - True
{4.2000003F}F != {4.2}D - True
{4.199999809265137D} != {4.2D} - True
{4.2F}F != {4.2D}D - True";

        string netCoreVersion = NetCore.GetNetCoreVersion();
        if (string.Compare(netCoreVersion, "3") < 0)
        {
            expected = netCoreApp3expected;
        }

        IntelliTect.TestTools.Console.ConsoleAssert.Expect(
                expected, Program.Main);
    }
}