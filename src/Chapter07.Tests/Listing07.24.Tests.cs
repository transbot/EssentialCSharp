namespace AddisonWesley.Michaelis.EssentialCSharp.Chapter07.Listing07_24.Tests;

[TestClass]
public class PeriodsOfTheDayTests
{
    [TestMethod]
    public void IsDeveloperWorkHours_ValidWorkingHours_ReturnsTrue()
    {
        Assert.IsTrue(PeriodsOfTheDay.IsDeveloperWorkHours(12));
    }

    [TestMethod]
    public void IsDeveloperWorkHours_ValidNonWorkingHours_ReturnsFalse()
    {
        Assert.IsFalse(PeriodsOfTheDay.IsDeveloperWorkHours(3));
    }

    [TestMethod]
    public void GetPeriodOfDay_Dawn_ReturnsDawn()
    {
        Assert.AreEqual("黎明", PeriodsOfTheDay.GetPeriodOfDay(5));
    }

    [TestMethod]
    public void GetPeriodOfDay_Morning_ReturnsMorning()
    {
        Assert.AreEqual("上午", PeriodsOfTheDay.GetPeriodOfDay(6));
    }

    [TestMethod]
    public void GetPeriodOfDay_Afternoon_ReturnsAfternoon()
    {
        Assert.AreEqual("下午", PeriodsOfTheDay.GetPeriodOfDay(13));
    }

    [TestMethod]
    public void GetPeriodOfDay_Evening_ReturnsEvening()
    {
        Assert.AreEqual("晚上", PeriodsOfTheDay.GetPeriodOfDay(18));
    }

    [TestMethod]
    public void GetPeriodOfDay_InvalidHour_ReturnsInvalid()
    {
        Assert.ThrowsException<ArgumentOutOfRangeException>(() => PeriodsOfTheDay.GetPeriodOfDay(25));
    }
}
