using ConsoleApp;

namespace TestProject;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.True(Program.IsLeapYear(4));
        Assert.True(Program.IsLeapYear(8));
        Assert.False(Program.IsLeapYear(-1));
        Assert.False(Program.IsLeapYear(9));
        Assert.True(Program.IsLeapYear(0));
        Assert.True(Program.IsLeapYear(-400));
    }
    
    [Fact]
    public void Test2()
    {
        Assert.True(Program.IsLeapYear(96));
        Assert.False(Program.IsLeapYear(-100));
        Assert.False(Program.IsLeapYear(300));
        Assert.True(Program.IsLeapYear(400));
        Assert.False(Program.IsLeapYear(1521));
    }
    
    [Fact]
    public void Test3()
    {
        Assert.Equal(Program.YayOrNay("4"), "yay");
        Assert.Equal(Program.YayOrNay("7"), "nay");
        Assert.Equal(Program.YayOrNay("419"), "nay");
        Assert.Equal(Program.YayOrNay("-400"), "yay");
        Assert.Equal(Program.YayOrNay("1600"), "yay");
    }
}