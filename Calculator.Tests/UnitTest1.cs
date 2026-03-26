using System.Runtime.InteropServices.JavaScript;
using CalculatorProject;
namespace Calculator.Tests;

public class UnitTest1
{
    [Fact]
    public void Add_Test()
    {
        double result = CalculatorProject.Calculator.Add(2, 3);
        Assert.Equal(5, result);
    }
}

public class UnitTest2
{
    [Fact]
    public void Add_Test()
    {
        double result = CalculatorProject.Calculator.Subtract(15, 5);
            Assert.Equal(10, result);
    }
}

public class UnitTest3
{
    [Fact]
    public void Add_Test()
    {
        double result = CalculatorProject.Calculator.Multiply(5, 5);
        Assert.Equal(25, result);
    }
}

public class UnitTest4
{
    [Fact]
    public void Add_Test()
    {
        double result = CalculatorProject.Calculator.Divide(10, 2);
        Assert.Equal(5, result);
    }
}
