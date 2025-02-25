using System;
using CalculatorProgram;


namespace CalculatorProgram
{
    public class CalculatorTest
    {

        [TestInitialize]
        public void Setup()
        {
            //Test Arrange
            Calculator calculator = new Calculator();
        }

        [TestMethod] //Testing Add
        public void AddSumPositiveNum() //void makes result local for the test
        {
            //Test Act
            var result = _calculator.Add(5, 5);

            //Test Assert
            Assert.AreEqual(10, result);
        }
    }
}