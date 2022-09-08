using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Class9
    {
       
            public static void Execute()
            {
                int[] a = { 1, 2, 3, 3, 5, 5, 7, 7, 9 };
                int cnt = 0;
                for(int i = 0; i < a.Length; i++)
                {
                   for(int j=i+1; j<a.Length; j++)
                   {
                    if (a[i] == a[j])
                    {
                        cnt++;
                    }
                    Console.WriteLine(a[i]+""+cnt);
                   }
                }
            Console.ReadLine();
            }
    }
}
