namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the Number for selecting the program:");
            Console.WriteLine("1. Fibonacci Series");
            Console.WriteLine("2. Perfect Series");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.WriteLine("1. Fibonicci Series");
                    Fibonacci fibonacci = new Fibonacci();
                    fibonacci.Series();
                    break;
                case 2:
                    Console.WriteLine("2. Perfect Series");
                    Perfect perfect = new Perfect();
                    perfect.Series();
                    break;
                default:
                    break;
            }
        }
    }
}