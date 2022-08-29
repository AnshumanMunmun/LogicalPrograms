using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Perfect
    {
        int a, b = 0, i, num;
        public void Series()
        {
            Console.Write("Enter the number of Series: ");
            num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= num / 2; ++i)    
            {
                b = num % i;
                if (b == 0)
                {
                    a = a + i;
                }
            }
            if (a == num)
            {
                Console.WriteLine(num + " is Perfect Number");
            }
            else
            {
                Console.WriteLine(num + " is not a Pefect Number ");
            }
        }
    }
}
