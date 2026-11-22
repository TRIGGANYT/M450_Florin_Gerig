namespace CalculatorLib
{
    public class Calculator : ICalculator
    {
        public int Add(int a, int b)
        {
            int result = a + b;
            return result;
        }

        public int Divide(int a, int b)
        {
            int result = a / b;
            return result;
        }

        public int Multiply(int a, int b)
        {
            int result = a * b;
            return result;
        }

        public int Subtract(int a, int b)
        {
            int result = a - b;
            return result;
        }
    }
}
