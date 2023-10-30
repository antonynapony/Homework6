namespace Classes1
{
    public class Soda
    {
        private string _taste;

        public Soda() { }

        public Soda(string taste)
        {
            _taste = taste;
        }

        public void OutputTaste()
        {
            if (!string.IsNullOrWhiteSpace(_taste))
            {
                Console.WriteLine($"У вас газировка со вкусом: {_taste}");
            }
            else
            {
                Console.WriteLine("У вас обычная газировка");
            }
        }
    }
}
