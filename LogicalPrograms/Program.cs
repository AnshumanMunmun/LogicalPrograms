using System;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Enter the Number for selecting the program:");
            Console.WriteLine("1. Fibonacci Series");
            Console.WriteLine("2. Perfect Series");
            Console.WriteLine("3. Prime Number Series");
            Console.WriteLine("4. Reverse Nnumber Series");
            Console.WriteLine("5. Converting Temperature");
            Console.WriteLine("6. Coupan Numbers");
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
                case 3:
                    Console.WriteLine("3. Prime Number Series");
                    Prime prime = new Prime();
                    prime.Series();
                    break;
                case 4:
                    Console.WriteLine("4. Reverse Nnumber Series");
                    Reverse reverse = new Reverse();
                    reverse.Series();
                    break;
                case 5:
                    Console.WriteLine("5. Converting Temperature");
                    Temperature temperature = new Temperature();
                    temperature.Temp();
                    break;
                case 6:
                    Console.WriteLine("6. Coupan Numbers");
                    Coupan coupan = new Coupan();
                    coupan.Dist();
                    break;
                default:
                    break;
            }
        }
    }
}