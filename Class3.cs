using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Class3
    {
        public static void Execute()
        {
            int[] a = {1,2,3,4,5,6,7,8,9};
            int cnt=0;
            Console.WriteLine("values in Array");
            for(int i=0; i<a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine("values in Array in Reverse Order");
            for (int i=a.Length-1;i>=0;i--)
            {
                cnt++;
                Console.WriteLine(a[i]+" ");
            }
            Console.ReadLine();
        }
    }
}
