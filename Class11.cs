using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Class11
    {
        public static void Execute()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine("The Even Elements are");
            for(int i = 0; i < a.Length; i++)
            {
                if(a[i]%2==0)
                {
                    Console.WriteLine(a[i]);
                }
            }
            Console.WriteLine("The Odd Elements are");
            for(int i=0; i<a.Length; i++)
            {
                if (a[i]%2!=0)
                {
                    Console.WriteLine(a[i]);
                }
            }
            Console.ReadLine();
        }
    }
}
