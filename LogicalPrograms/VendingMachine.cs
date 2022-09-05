using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class VendingMachine
    {
        public void Machine()
        {
            Console.WriteLine("Enter the amount: ");
            int amount = Convert.ToInt32(Console.ReadLine());
            count(amount);
        }
        private static void count(int amount)
        {                                       //Initialization of New Array
            int[] notes = new int[] { 1000, 500, 200, 100, 50, 20, 10, 5, 1 };
            int[] noteCounter = new int[9];
            for (int i = 0; i < 9; i++)
            {
                if (amount >= notes[i])
                {
                    noteCounter[i] = amount / notes[i];
                    amount = amount % notes[i];
                }
            }
            Console.WriteLine("Counting Currency :");
            for (int i = 0; i < 9; i++)
            {
                if (noteCounter[i] != 0)
                {
                    Console.WriteLine("Total Number of Notes are Rs " + notes[i] + " : "+ noteCounter[i]);
                }
            }
        }
    }
}