
namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_17.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void Contact_GetSummaryOverridden()
    {
        Contact contact = new("Inigo Montoya")
        {
            Address = "111 W St City, State 11111"
        };

        string expected = "名字: Inigo" + Environment.NewLine +
                          "姓氏: Montoya" + Environment.NewLine +
                          "地址: 111 W St City, State 11111" + Environment.NewLine;
        
        Assert.AreEqual(expected, contact.GetSummary());
    }

    [TestMethod]
    public void Appointment_GetSummaryOverridden()
    {
        Appointment appointment = new(
               "Soccer tournament", "111 W St City, State 11111",
               new DateTime(2008, 7, 19), new DateTime(2008, 7, 18));

        string expected = "主题: Soccer tournament" + Environment.NewLine +
                          $"开始时间: {appointment.StartDateTime}" + Environment.NewLine +
                          $"结束时间: {appointment.EndDateTime}" + Environment.NewLine +
                          "地点: 111 W St City, State 11111";
        
        Assert.AreEqual(expected, appointment.GetSummary());
    }
}
