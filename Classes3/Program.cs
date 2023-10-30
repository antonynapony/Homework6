namespace Classes3
{
    static class Program
    {
        static void Main(string[] args)
        {
            int condition;
            Car engine = new Car();
            Console.WriteLine("Введите <0>, если двигатель выключен");
            Console.WriteLine("Введите <1>, если двигатель включен");
            bool isParseSuccess = int.TryParse(Console.ReadLine(), out condition);
            if (isParseSuccess && condition >= 0 && condition <= 1)
            {
                if (condition == 0)
                {
                    engine.TurnOff(true);
                }
                else if (condition == 1)
                {
                    engine.TurnOn(true);
                }
            }
            else
            {
                Console.WriteLine("Неверно задано значение!");
                return;
            }
                Car parameters = new Car();
                Console.Write("Укажите тип: ");
                string type = Console.ReadLine();
                Console.Write("Укажите цвет: ");
                string color = Console.ReadLine();
                Console.Write("Укажите год: ");
                string year = Console.ReadLine();
                parameters.Type(type);
                parameters.Color(color);
                parameters.Year(year);
            }
        }
    }
