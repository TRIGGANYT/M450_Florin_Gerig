namespace CalculatorLib.Test
{
    [TestClass]
    public sealed class CalculatorTest
    {
        [TestMethod]
        public void AddTwoPositiveNumbers()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(2, 5);
            Assert.AreEqual(7, result);
        }

        [TestMethod]
        public void AddTwoNegativeNumbers()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(-3, -1);
            Assert.AreEqual(-4, result);
        }

    }
}