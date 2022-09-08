using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Class4
    {
        public static void Execute()
        {


            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int  sum=0;
            for(int i=0; i<a.Length; i++)
            {
                sum += sum + a[i];
            }
            Console.WriteLine("sum of all elements" +sum);
            Console.ReadLine();
        }
            
    }
}
