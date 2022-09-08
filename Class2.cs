using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Class2
    {
        public static void Execute()
        {
            int[] number = new int[11];
            number[0] = 1;
            number[1] = 1;
            number[2] = 2;
            number[3] = 3;
            number[4] = 4;
            number[5] = 5;
            number[6] = 6;
            number[7] = 7;
            number[8] = 8;
            number[9] = 9;
            number[10] = 10;
            for(int i = 0; i < number.Length; i++)
            {
                Console.WriteLine(number[i]+" ");
            }
            Console.ReadLine();


        }

      
    }
}
