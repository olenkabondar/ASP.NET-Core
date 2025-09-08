namespace _2Task.Models
{
    public class CalcService : ICalcService
    {
        public int Add(int a, int b) => a + b;
        public int Subtract(int a, int b) => a - b;
        public int Multiply(int a, int b) => a * b;
        public double Divide(int a, int b)
        {
            if (b == 0) throw new DivideByZeroException("Ділення на нуль заборонено!");
            return (double)a / b;
        }
    }
}
