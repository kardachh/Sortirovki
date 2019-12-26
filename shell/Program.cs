using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shell
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
            Sort(a);
        }
        static void Sort(int[] a)
        {

            WriteArray(a);
            ShellSort(a);
            Console.WriteLine();
            WriteArray(a);


            Console.ReadKey();
        }

        static void ShellSort(int[] a)
        {
            int j;
            int step = a.Length / 2;
            while (step > 0)
            {
                for (int i = 0; i < (a.Length - step); i++)
                {
                    j = i;
                    while ((j >= 0) && (a[j] > a[j + step]))
                    {
                        Swap(a, j, j + step);
                        j = j - step;
                    }
                }
                step = step / 2;
            }
        }
        static void Swap(int[] a, int i, int j)
        {
            int g = a[i];
            a[i] = a[j];
            a[j] = g;
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
