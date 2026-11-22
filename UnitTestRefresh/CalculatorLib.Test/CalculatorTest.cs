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
        public void AddNegativeNumber()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(3, -1);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void AddTwoNegativeNumbers()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Add(-3, -1);
            Assert.AreEqual(-4, result);
        }

        [TestMethod]
        public void SubtractTwoPositiveNumbers()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Subtract(3, 1);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void SubtractNegativeNumber()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Subtract(3, -1);
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void SubtractTwoNegativeNumbers()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Subtract(-3, -1);
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void DivideTwoPositiveNumbers()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Divide(4, 2);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void DivideTwoNegativeNumbers()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Divide(-4, -2);
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void DivideNegativeNumber()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Divide(-4, 2);
            Assert.AreEqual(-2, result);
        }

        [TestMethod]
        public void DivideByZero()
        {
            Calculator calculator = new Calculator();

            Assert.ThrowsExactly<DivideByZeroException>(() => calculator.Divide(4, 0));
        }

        [TestMethod]
        public void MultiplyTwoPositiveNumbers()
        {
            Calculator calculator = new Calculator();
            int result = calculator.Multiply(4, 2);
            Assert.AreEqual(8, result);
        }
    }
}