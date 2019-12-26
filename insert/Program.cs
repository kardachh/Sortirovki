using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insert
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
            InsertSort(a);
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
        static void InsertSort(int[] a)
        {
            for (int i = 1; i < a.Length; i++)
            {
                int k = a[i];
                int j = i;
                while (j > 0 && k < a[j - 1])
                {
                    a[j] = a[j - 1];
                    j--;
                }
                a[j] = k;
            }
        }
    }
    
}
