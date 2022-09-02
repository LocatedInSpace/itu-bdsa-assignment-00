using ConsoleApp;

namespace TestProject;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        Assert.False(Program.IsLeapYear(-1));
        Assert.False(Program.IsLeapYear(9));
        Assert.False(Program.IsLeapYear(0));
        Assert.False(Program.IsLeapYear(-400));
        Assert.False(Program.IsLeapYear(1582));
        
        Assert.True(Program.IsLeapYear(1584));
        Assert.True(Program.IsLeapYear(1588));
        Assert.True(Program.IsLeapYear(2020));
    }
    
    [Fact]
    public void Test2()
    {
        Assert.False(Program.IsLeapYear(1500));
        Assert.False(Program.IsLeapYear(1700));
        
        Assert.True(Program.IsLeapYear(1600));
    }
    
    [Fact]
    public void Test3()
    {
        Assert.Equal(Program.YayOrNay("4"), "nay");
        Assert.Equal(Program.YayOrNay("7"), "nay");
        Assert.Equal(Program.YayOrNay("1582"), "nay");
        Assert.Equal(Program.YayOrNay("-400"), "nay");
        
        Assert.Equal(Program.YayOrNay("1600"), "yay");
        Assert.Equal(Program.YayOrNay("1604"), "yay");
        Assert.Equal(Program.YayOrNay("2000"), "yay");
    }
    
    [Fact]
    public void Test4()
    {
        Assert.Equal(Program.YayOrNay("four"), "nay");
        Assert.Equal(Program.YayOrNay("8"), "nay");
        Assert.Equal(Program.YayOrNay("0000000000000A1"), "nay");
        Assert.Equal(Program.YayOrNay("------3"), "nay");
        Assert.Equal(Program.YayOrNay("+4"), "nay");
        
        Assert.Equal(Program.YayOrNay("+1600"), "yay");
        Assert.Equal(Program.YayOrNay("+1612"), "yay");
        Assert.Equal(Program.YayOrNay("+2024"), "yay");
    }
}