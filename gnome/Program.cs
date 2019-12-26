using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gnome
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
            GnomeSort(a);
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
        static void GnomeSort(int[] a)
        {
            int i = 1;
            int j = 2;
            while (i < a.Length)
            {
                if (a[i - 1] < a[i])
                {
                    i = j;
                    j = j + 1;
                }
                else
                {
                    Swap(a, i - 1, i);
                    i = i - 1;
                    if (i == 0)
                    {
                        i = j;
                        j = j + 1;
                    }
                }
            }   
        }
            static void Swap(int[] a, int i, int j)
        {
            int g = a[i];
            a[i] = a[j];
            a[j] = g;
        }
    }
}
