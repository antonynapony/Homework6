namespace Classes2
{
    public class Math
    {
        public Math() { }

        public void Add(double operandA, double operandB)
        {
            double sum = operandA + operandB;
            Console.WriteLine($"{operandA} + {operandB} = {sum}");
        }
        public void Multiple(double operandA, double operandB)
        {
            double sum = operandA * operandB;
            Console.WriteLine($"{operandA} * {operandB} = {sum}");
        }
        public void Divide(double operandA, double operandB)
        {
            double sum = operandA / operandB;
            Console.WriteLine($"{operandA} / {operandB} = {sum}");
        }
        public void Difference(double operandA, double operandB)
        {
            double sum = operandA - operandB;
            Console.WriteLine($"{operandA} - {operandB} = {sum}");
        }
    }
}
