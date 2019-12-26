using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble_with_methods
{
    class Program
    {

        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("vvedite kol-vo elementov");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = rnd.Next(-25, 26);
            }
            WriteArray(a);
            BubbleSort(a);
            Console.WriteLine();
            WriteArray(a);



            Console.ReadKey();
        }
        static void WriteArray(int[] a)
        {
            foreach (int k in a)
            {
                Console.Write(k+" ");
            }
        }



        static void BubbleSort(int[] a)
        {
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
        }
    }
}
