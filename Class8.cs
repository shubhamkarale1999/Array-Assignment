using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Class8
    {
        public static void Execute()
        {

            int[] a = { 1, 2, 3};
            int[] b = { 1, 2, 3};
            int[] c = new int[a.Length + b.Length];
            int index=0;
            for(int i=0; i<a.Length; i++)
            {
                c[index++] = a[i];
            }
            for(int i=0; i<b.Length; i++)
            {
                c[index++] = b[i];
            }
            for(int i=0; i<c.Length; i++)
            {
                for(int j=i+1; j<a.Length; j++)
                {
                    if (c[i] > c[j])
                    {
                        int temp = c[i];
                        c[i] = c[j];
                        c[j] = temp;
                    }
                }
                
            }
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(c[i]);
            }
            Console.ReadLine();
        }
    }
}
