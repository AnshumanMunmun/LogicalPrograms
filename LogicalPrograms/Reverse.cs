using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Reverse
    {
        int num, a, b = 0;
        public void Series()
        {
            Console.WriteLine("Enter a numbers series to reverse");
            num = Convert.ToInt32(Console.ReadLine());
            while (num != 0)
            {
                a = num % 10;
                b = b * 10 + a;
                num = num / 10;
            }
            Console.WriteLine("The Reverse Number Series :" + b);
        }
    }
}
