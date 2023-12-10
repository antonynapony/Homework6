namespace Classes2
{
    public class Math
    {
        public Math() { }

        public double Add(double operandA, double operandB)
        {
            double sum = operandA + operandB;
            return sum;
        }
        public double Multiple(double operandA, double operandB)
        {
            double sum = operandA * operandB;
            return sum;
        }
        public double Divide(double operandA, double operandB)
        {
            if (operandB != 0)
            {
                double sum = operandA / operandB;
                return sum;
            }
                throw new DivideByZeroException();
        }
        public double Difference(double operandA, double operandB)
        {
            double sum = operandA - operandB;
            return sum;
        }
    }
}
