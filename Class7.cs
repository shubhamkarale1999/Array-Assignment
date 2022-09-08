using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Class7
    {
        public static void Execute()
        {

            int[] a = { 1, 2, 3, 4, 4, 5, 6, 7, 7 };
            Console.WriteLine("The unique elements found in the array are :\r\n");
            for (int i = 0; i < a.Length; i++)
            {
                int cnt = 0;
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] == a[i])
                        cnt++;
                }
                if (cnt == 0)
                {
                    Console.WriteLine(a[i] + " ");
                }
            }
            Console.ReadLine();
        }
    }
}
