using System;

namespace Vetor3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] a;
            int[] b;
            int[] c;
            int n = int.Parse(Console.ReadLine());
            a = new int[n];
            b = new int[n];
            c = new int[n];
            string[] s = Console.ReadLine().Split(' ');
            for(int i = 0; i< n; i++)
            {
                a[i] = int.Parse(s[i]);
            }

            s = Console.ReadLine().Split(' ');

            for(int i = 0; i < n; i++)
            {
                b[i] = int.Parse(s[i]);
            }

            for(int i = 0; i< n; i++)
            {
                c[i] = a[i] + b[i];
                Console.Write(c[i] + " ");
            }
            

        }
    }
}
