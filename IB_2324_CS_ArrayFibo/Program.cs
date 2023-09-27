using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IB_2324_CS_ArrayFibo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] x = new int[100];
            long[] x = new long[100];
            x[0] = 0;
            x[1] = 1;

            // there are actually 3 answers
            // answer 1 starting from 2

            for (int a = 2; a < x.Length; a++)
            {
                x[a] = x[a - 1] + x[a - 2];
            }
            // answer 2 starting from 1
            for (int a = 1; a < x.Length - 1; a++)
            {
                x[a + 1] = x[a] + x[a - 1];
            }
            // answer 3 starting from 0
            for (int a = 0; a < x.Length - 2; a++)
            {
                x[a + 2] = x[a + 1] + x[a];
            }

            for (int a = 0; a < x.Length; a++) 
            {
                Console.WriteLine(x[a]);
            }

            Console.ReadKey();
        }
    }
}
