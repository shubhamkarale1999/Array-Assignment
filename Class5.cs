using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Class5
    {
        public static void Execute()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int[] b = new int[a.Length];
            int index = 0;
            Console.WriteLine("The elements stored in the first array are :");
            for(int i=0; i<a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            for(int i=0; i<a.Length; i++)
            {
                b[index++] = a[i];
            }
            Console.WriteLine("The elements Copied in the Second array are :");
            for (int i=0; i<b.Length; i++)
            {
                Console.WriteLine(b[i]);
            }  
            Console.ReadLine();
        }
    }
}
