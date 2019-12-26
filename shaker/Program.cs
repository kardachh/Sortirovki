using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shaker
{
    class Program
    {
        private static void Main(string[] args)
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
            ShakerSort(a);
            Console.WriteLine();
            WriteArray(a);


            Console.ReadKey();
        }

        static void ShakerSort(int[] a)
        {
            int l = 0,
                r = a.Length - 1;
            while (l < r)
            {
                for(int i = l; i < r; i++)
                {
                    if (a[i] > a[i+1])
                        Swap(a, i, i+1);
                }
                r--;

                for (int i = r; i > l; i--)
                {
                    if (a[i - 1] > a[i])
                        Swap(a, i - 1, i);
                }
                l++;
            }
        }
        static void Swap(int[] a,int i,int j)
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
        static void RandomArray(int[] vs)
        {
            
        }
    }
}
