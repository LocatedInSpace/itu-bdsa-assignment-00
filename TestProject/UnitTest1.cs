using ConsoleApp;

namespace TestProject;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var year = new Program();
        Assert.True(year.IsLeapYear(4));
        Assert.True(year.IsLeapYear(8));
        Assert.False(year.IsLeapYear(-1));
        Assert.False(year.IsLeapYear(9));
        Assert.True(year.IsLeapYear(0));
        Assert.True(year.IsLeapYear(-400));
    }
    
    [Fact]
    public void Test2()
    {
        var year = new Program();
        Assert.True(year.IsLeapYear(96));
        Assert.False(year.IsLeapYear(-100));
        Assert.False(year.IsLeapYear(300));
        Assert.True(year.IsLeapYear(400));
        Assert.False(year.IsLeapYear(1521));
    }
}