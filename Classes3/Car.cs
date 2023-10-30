namespace Classes3
{
    public class Car
    {
        private string _type;
        private string _color;
        private string _year;

        public void TurnOn(bool turnOn)
        {
            if (turnOn)
            {
                Console.WriteLine("Вы запустили двигатель. Автомобиль заведен!");
            }
        }
        public void TurnOff(bool turnOff)
        {
            if (turnOff)
            {
                Console.WriteLine("Вы отключили двигатель. Автомобиль заглушен!");
            }
        }
        public void Type(string type)
        {
            _type = type;
            Console.WriteLine($"Тип автомобиля: {_type}");
        }

        public void Color(string color)
        {
            _color = color;
            Console.WriteLine($"Цвет автомобиля: {_color}");
        }

        public void Year(string year)
        {
            _year = year;
            Console.WriteLine($"Год выпуска автомобиля: {_year}");
        }
    }
}
