using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Fibonacci
    {
        public void Series()
        {
            int a = 0, b = 1, c, i, num;
            Console.Write("Enter the number of Series: ");
            num = int.Parse(Console.ReadLine());
            Console.Write(a + " " + b + " "); //printing 0 and 1    
            for (i = 2; i < num; ++i) //loop starts from 2 because 0 and 1 are already printed    
            {
                c = a + b;
                Console.Write(c + " ");
                a = b;
                b = c;
            }
        }
    }
}
