using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    internal class Coupan
    {
        int i, j, count;
        public void Dist()
        {
            int[] arr = new int[10];
            int[] Dist = new int[10];
            Random random = new Random();
            for ( i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(1, 11);
            }
            for ( i = 0; i < arr.Length; i++)
            {
                 count = 0;
                for (int j = 0; j < arr.Length; j++)
                {                                      //random values(1-10) = sequntial value(1-10)
                    if (arr[i] == arr[j])
                    {
                        count++;
                    }
                }
                if (count == 1)
                {
                    Dist[i] = arr[i];
                }
            }
            foreach (int i in Dist)
            {
                if (i != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
