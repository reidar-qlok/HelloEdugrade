namespace HelloEdugrade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            DateTime currentDate = DateTime.Now;
            Console.WriteLine($"Hej, {name}, på {currentDate:d}");
        }
    }
}