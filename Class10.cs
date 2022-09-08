using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Class10
    {
        public static void Execute()
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for(int i = 0; i < a.Length; i++)
            {
                for(int j=i+1; j<a.Length; j++)
                {
                    int temp = a[i];
                    a[i] = a[j];
                    a[j] = temp;
                }
            }
            for(int i=0; i < a.Length; i++)
            {
                //Console.WriteLine(a[i]);
            }
            Console.WriteLine("max "+a[0]);
            Console.WriteLine("min "+a[a.Length-1]);
            Console.ReadLine();
        }
        
    }
}
