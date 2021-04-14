using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("請輸入風箏的大小(n >= 4): ");
            int n = int.Parse(Console.ReadLine());

            for(int i=n+1; i>0; i--)
            {
                for (int j = 1; j <= i; j++) Console.Write(" ");
                Console.Write("*");
                if(i >= n - 2)
                {
                    for (int j = 0; j < n + 1 - i; j++) Console.Write(" *");
                    Console.Write("\n");
                }
                else
                {
                    Console.Write(" *");
                    for (int j = 0; j < (2 * n - 5) / 2 + 1 - i; j++) Console.Write(" ");
                    Console.Write("*");
                    for (int j = 0; j < (2 * n - 5) / 2 + 1 - i; j++) Console.Write(" ");
                    Console.Write("* *\n");
                }
            }

            Console.Write("* * ");
            for (int i = 0; i < 2 * n - 5; i++) Console.Write("*");
            Console.Write(" * *\n");

            for (int i = 1; i <=n+1; i++)
            {
                for (int j = 1; j <= i; j++) Console.Write(" ");
                Console.Write("*");
                if (i >= n - 2)
                {
                    for (int j = 0; j < n + 1 - i; j++) Console.Write(" *");
                    Console.Write("\n");
                }
                else
                {
                    Console.Write(" *");
                    for (int j = 0; j < (2 * n - 5) / 2 + 1 - i; j++) Console.Write(" ");
                    Console.Write("*");
                    for (int j = 0; j < (2 * n - 5) / 2 + 1 - i; j++) Console.Write(" ");
                    Console.Write("* *\n");
                }
            }

            for(int i = 0; i<n-1; i++)
            {
                for (int j = 0; j < n-i; j++) Console.Write(" ");
                Console.Write("*");
                for (int j = 0; j < 2 * i + 1; j++) Console.Write(" ");
                Console.Write("*\n");
            }

            Console.ReadKey(true);


        }
    }
}
