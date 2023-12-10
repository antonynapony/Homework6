using System.Globalization;

namespace Classes2
{
    static class Program
    {
        static void Main(string[] args)
        {
            Math calculator = new Math();
            Console.WriteLine("Для сложения введите: 1");
            Console.WriteLine("Для вычитания введите: 2");
            Console.WriteLine("Для умножения введите: 3");
            Console.WriteLine("Для деления введите: 4");
            Console.WriteLine("Введите номер операции, которую хотели бы совершить: ");
            bool isParseSuccess = int.TryParse(Console.ReadLine(), out int operationNumber);
            if (isParseSuccess && operationNumber >= 1 && operationNumber <= 4)
            {
                Console.WriteLine("Введите числа, с которыми хотите провести операцию");
                double firstOperand = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                double secondOperand = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                switch (operationNumber)
                {
                    case 1:
                        Console.WriteLine(calculator.Add(firstOperand, secondOperand));
                        break;
                    case 2:
                        Console.WriteLine(calculator.Difference(firstOperand, secondOperand));
                        break;
                    case 3:
                        Console.WriteLine(calculator.Multiple(firstOperand, secondOperand));
                        break;
                    case 4:
                        Console.WriteLine(calculator.Divide(firstOperand, secondOperand));
                        break;
                }
            }
            else
            {
               Console.WriteLine("Некорректный номер операции!");
            }
        }
    }
}
