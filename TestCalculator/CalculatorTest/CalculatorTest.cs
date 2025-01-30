[TestClass]
public class CalculatorTest
{
    private CalculatorTest _calculator;

    [TestInitialize]
    public void Setup()
    {
        //Test Arrange
        _calculator = new Calculator();
    }

    [TestMethod] //Testing Add
    public void AddSumPositiveNum() //void makes result local for the test
    {
        //Test Act
        var result = _calculator.Add(5, 5);

        //Test Assert
        Assert.AreEqual(10, result);
    }

    [TestMethod]
    public void AddSumWithNegative()
    {
        //Act
        var result = _calculator.Add(-3, 7);

        //Assert
        Assert.AreEqual(4, result);
    }

    [TestMethod] //Testing for Subtract
    public void SubPositive()
    {
        var result = _calculator.Sub(10, 4);

        //Assert
        Assert.AreEqual(6, result);
    }

    [TestMethod]
    public void SubNegative()
    {
        //Act
        var result = _calculator.Sub(4, -4);

        //Assert
        Assert.AreEqual(8, result);
    }

    [TestMethod] //Testing mutiply
    public void MulPositive()
    {
        //Act
        var result = _calculator.mul(5, 5);

        //Assert
        Assert.AreEqual(25, result);
    }

    [TestMethod]
    public void MulNegative()
    {
        //Act
        var result = _calculator.mul(5, -5);

        //Assert
        Assert.AreEqual(-25, result);
    }

    [TestMethod] //Testing divide
    public void DivPositive()
    {
        //Act
        var result = _calculator.div(10, 5);

        //Assert
        Assert.AreEqual(2, result);
    }

    [TestMethod]
    public void DivNegative()
    {
        //Act
        var result = _calculator.div(10, -2);

        //Assert
        Assert.AreEqual(-5, result);
    }
}