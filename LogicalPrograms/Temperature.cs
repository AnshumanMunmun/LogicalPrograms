using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Temperature
    {
        int cels, fahr;
        public void Temp()
        {
            Console.WriteLine("please enter your choice");
            Console.WriteLine("1.Convert Celsius to Fahrenheit");
            Console.WriteLine("2.Convert Fahrenheit to Celsius");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Converting Celsius to Fahrenheit");
                    cels = Convert.ToInt32(Console.ReadLine());
                    fahr = (cels * 9 / 5) + 32;
                    Console.WriteLine("Converted Temperature of Celsius " + cels + " to Fahrenheit temperature is: " + fahr);
                    break;
                case 2:
                    Console.WriteLine("Converting Fahrenheit to Celsius");
                    fahr = Convert.ToInt32(Console.ReadLine());
                    cels = (fahr - 32) * 5 / 9;
                    Console.WriteLine("Converted Temperature of Fahrenheit " + fahr + " to Celsius temperature is: " + cels);
                    break;
                default:
                    break;
            }
        }
    }
}
