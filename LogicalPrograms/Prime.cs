using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Prime
    {
        int i, num, count = 0;
        public void Series()
        {
            Console.Write("Enter the number of Series: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num; ++i)
            {
                if (num % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine(num + " is Prime Number");
            }
            else
            {
                Console.WriteLine(num + " is not a Prime Number ");
            }
        }
    }
}
