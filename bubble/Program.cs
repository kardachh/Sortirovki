using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vvedite kol-vo chisel");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine("vvedite " + (i + 1) + " число");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int k in a) { Console.Write(" " + k); }
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[i] > a[j])
                    {
                        int o = a[i];
                        a[i] = a[j];
                        a[j] = o;
                    }
                }
            }
            Console.WriteLine();
            foreach (int k in a) { Console.Write(" " + k); }
            Console.ReadKey();
        }
    }
}
