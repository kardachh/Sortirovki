using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quick
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
            QSort(a, 0, a.Length - 1);
            Console.WriteLine();
            WriteArray(a);
            Console.ReadKey();
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
        static void QSort(int[] arr, int l, int r)
        {
            int i = l;
            int j = r;
            int x = arr[(l + r) / 2]; 
            while (i <= j)
            {
                while (arr[i] < x) i++;
                while (arr[j] > x) j--;
                if (i <= j)
                {
                    int temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    i++;
                    j--;
                }
            }
            if (l < j) QSort(arr, l, j);
            if (i < r) QSort(arr, i, r);
        }



    }
}
