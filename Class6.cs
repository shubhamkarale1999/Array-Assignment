using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Class6
    {
        public static void Execute()
        {
            int[] a = { 1, 2, 3,3};
            int cnt = 0;
            int count=0;
            for(int i = 0; i < a.Length; i++)
            {
                for (int j = i+1; j < a.Length; j++)
                {
                    if (a[i] == a[j])
                    {
                        cnt++;
                    }
                }
                if(cnt == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
     }
}
