using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Select
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
            SelectSort(a);
            Console.WriteLine();
            WriteArray(a);


            Console.ReadKey();
        }
        static void WriteArray(int[] a)
        {
            foreach (int k in a)
            {
                Console.Write(k + " ");
            }
        }
        static void SelectSort(int[] a)
        {
            for (int i = 0; i < a.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < a.Length; j++)
                {
                    if (a[j] < a[min])
                    {
                        min = j;
                    }
                }
                int k = a[i];
                a[i] = a[min];
                a[min] = k;
            }
        }
    }
    
}
