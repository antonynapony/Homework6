namespace Classes3
{
    static class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car("Седан", "Коричневый", 2014);
            Console.WriteLine(car.Type);
            Console.WriteLine(car.Color);
            Console.WriteLine(car.Year);
            car.SetType("Минивэн");
            car.SetColor("Черный");
            car.SetYear(1997);
            Console.WriteLine(car.Type);
            Console.WriteLine(car.Color);
            Console.WriteLine(car.Year);
            int condition;
            Console.WriteLine("Введите <0>, если двигатель выключен");
            Console.WriteLine("Введите <1>, если двигатель включен");
            bool isParseSuccess = int.TryParse(Console.ReadLine(), out condition);
            if (isParseSuccess && condition >= 0 && condition <= 1)
            {
                if (condition == 0)
                {
                    car.TurnOff(true);
                }
                else if (condition == 1)
                {
                    car.TurnOn(true);
                }
            }
            else
            {
                Console.WriteLine("Неверно задано значение!");
                return;
            }
        }
    }
}
