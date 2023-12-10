namespace Classes3
{
    public class Car
    {
        private string _type;
        public string Type
        {
            get { return _type; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _type = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        private string _color;
        public string Color
        {
            get { return _color; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _color = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }
        private int _year;
        public int Year
        {
            get { return _year; }
            set
            {
                if (value > 1900)
                {
                    _year = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public Car(string type, string color, int year)
        {
            Type = type;
            Color = color;
            Year = year;
        }



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
        public string SetType(string type)
        {
            Type = type;
            return type;
        }

        public string SetColor(string color)
        {
            Color = color;
            return color;
        }

        public int SetYear(int year)
        {
            Year = year;
            return year;
        }
    }
}
