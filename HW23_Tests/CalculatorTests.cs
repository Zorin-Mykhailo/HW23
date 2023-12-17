using HW23;
using Moq;

namespace HW23_Tests;

[TestFixture]
public class CalculatorTests
{
    private Calculator Calc;

    [SetUp]
    public void SetUp()
    {
        Calc = new();
    }

    [Test()]
    [TestCase(10, 20, 30)]
    [TestCase(0, 10, 10)]
    [TestCase(20, 0, 20)]
    public void CheckSum(double a, double b, double expected)
    {
        double actual = Calc.Sum(a, b);
        Assert.That(actual, Is.EqualTo(expected), $"Expected {actual} to be {expected}");
    }

    [Test()]
    [TestCase(30, 20, 10)]
    [TestCase(30, 10, 20)]
    [TestCase(0, 0, 0)]
    public void CheckSubstract(double a, double b, double expected)
    {
        double actual = Calc.Substract(a, b);
        Assert.That(actual, Is.EqualTo(expected), $"Expected {actual} to be {expected}");
    }

    [Test()]
    [TestCase(10, 20, 200)]
    [TestCase(20, 10, 200)]
    [TestCase(10, 0, 0)]
    [TestCase(0, 10, 0)]
    [TestCase(0, 0, 0)]
    public void CheckMultiply(double a, double b, double expected)
    {
        double actual = Calc.Multiply(a, b);
        Assert.That(actual, Is.EqualTo(expected), $"Expected {actual} to be {expected}");
    }

    [Test()]
    [TestCase(20, 5, 4)]
    [TestCase(20, 4, 5)]
    [TestCase(0, 1, 0)]
    [TestCase(0, 100, 0)]
    [TestCase(100, 0, double.PositiveInfinity)]
    [TestCase(-100, 0, double.NegativeInfinity)]
    [TestCase(0, 0, double.NaN)]
    public void CheckDivide(double a, double b, double expected)
    {
        double actual = Calc.Divide(a, b);
        Assert.That(actual, Is.EqualTo(expected), $"Expected {actual} to be {expected}");
    }

    [Test()]
    [TestCase(10, 20, false)]
    [TestCase(20, 10, true)]
    [TestCase(10, 10, false)]
    public void CheckCompareSimple(double a, double b, bool expected)
    {
        bool actual = Calc.CompareSimple(a, b);
        Assert.That(actual, Is.EqualTo(expected), $"Expected {actual} to be {expected}");
    }


    [Test()]
    [TestCase(1, 1, false)]
    [TestCase(2, 2, false)]
    [TestCase(3, 3, true)]
    public void CheckCompare(double a, double b, bool expected)
    {
        bool actual = Calc.Compare(a, b);
        Assert.That(actual, Is.EqualTo(expected), $"Expected {actual} to be {expected}");
    }


    [Test()]
    public void Compare_Call_SomeMethod()
    {
        var calcMock = new Mock<Calculator>() { CallBase = true };
        calcMock.Object.Compare(It.IsAny<double>(), It.IsAny<double>());

        calcMock.Verify(x => x.SomeMethod(), Times.Once);
    }


    [Test()]
    public void Compare_Call_Sum()
    {
        var calcMock = new Mock<Calculator>(){ CallBase = true };
        calcMock.Object.Compare(It.IsAny<double>(), It.IsAny<double>());

        calcMock.Verify(x => x.Sum(It.IsAny<double>(), It.IsAny<double>()));
    }

    [Test()]
    public void Compare_Call_Multiply()
    {
        var calcMock = new Mock<Calculator>(){ CallBase = true };
        calcMock.Object.Compare(It.IsAny<double>(), It.IsAny<double>());

        calcMock.Verify(x => x.Multiply(It.IsAny<double>(), It.IsAny<double>()));
    }
}