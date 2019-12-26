using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace merge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("vvedite kol-vo elementov");
            int n = Convert.ToInt32(Console.ReadLine());
            Random rnd = new Random();
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(-100, 101);
            }
            WriteArray(a);
            Console.WriteLine();
            Console.WriteLine(string.Join(" ", sort(a)));
            Console.ReadKey();

        }
        public static int[] sort(int[] a)
        {
            if (a.Length == 1)
                return a;
            int mid_point = a.Length / 2;
            return merge(sort(a.Take(mid_point).ToArray()), sort(a.Skip(mid_point).ToArray()));
        }
        public static int[] merge(int[] mass1, int[] mass2)
        {
            int a = 0, b = 0;
            int[] merged = new int[mass1.Length + mass2.Length];
            for (int i = 0; i < mass1.Length + mass2.Length; i++)
            {
                if (b < mass2.Length && a < mass1.Length)
                    if (mass1[a] > mass2[b] && b < mass2.Length)
                        merged[i] = mass2[b++];
                    else
                        merged[i] = mass1[a++];
                else
                    if (b < mass2.Length)
                    merged[i] = mass2[b++];
                else
                    merged[i] = mass1[a++];
            }
            return merged;
        }
        static void WriteArray(int[] a)
        {
            foreach (int k in a)
            {
                Console.Write(k + " ");
            }
        }
    }
}

