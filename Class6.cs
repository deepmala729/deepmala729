using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    class Class6
    {
        static void print_di(int n)
        {
            int i, j;
            for (i = 1; i <= n; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    if (i == 1 || i == n ||
                        j == 1 || j == n ||
                        i == j || j == (n - i + 1))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }

        }


        public static void Main7()
        {
            int rows = 9;
            print_di(rows);
        }

    }
}
