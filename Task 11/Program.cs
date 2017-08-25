using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку");
            string str = Console.ReadLine();

            int i, j = 1, n = 10, m = 0;
            int k = str.Length - 1;
            char [,] mas = new char [n + 1, n + 1];
            do
            {
                i = m;
                for (j = m; j <= n; j++)
                {
                    mas[i, j] = str[k];
                    k --;
                }
                j = n;
                for (i = m + 1; i <= n; i++)
                {
                    mas[i, j] = str[k];
                    k--;
                }
                i = n;
                for (j = n - 1; j >= m; j--)
                {
                    mas[i, j] = str[k];
                    k--;
                }
                j = m;
                for (i = n - 1; i > m; i--)
                {
                    mas[i, j] = str[k];
                    k--;
                }
                n--; m++;
            }
            while (k > -1);

            for (i = 0; i < 11; i++)
            {
                for (j = 0; j < 11; j++)
                    Console.Write(mas[i, j] + " ");
                Console.WriteLine();
            }

            Console.ReadLine();

        }
    }
}
