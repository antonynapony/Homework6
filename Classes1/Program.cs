namespace Classes1
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите вкус либо оставьте поле пустым: ");
            Soda taste = new Soda(Console.ReadLine());
            taste.OutputTaste();
        }
    }
}