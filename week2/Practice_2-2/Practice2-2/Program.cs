using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] glass = new int[11];
            int truelen = 0;
            int max = 0;
            Console.WriteLine("請輸入數列(輸入0結束)");
            for(int i=0; i<11; i++)
            {
                int input = int.Parse(Console.ReadLine());
                if (input != 0)
                {
                    glass[i] = input;
                }
                else
                {
                    truelen = i;
                    break;
                }
            }

            //====================
            //Solution
            for(int i=truelen-1; i>0; i--)
            {
                for(int j=0;j<truelen-i; j++)
                {
                    if (glass[j] > glass[j + i])
                    {
                        if (max < glass[j + i] * i)
                        {
                            max = glass[j + i] * i;
                        }
                    }
                    else
                    {
                        if (max < glass[j] * i)
                        {
                            max = glass[j] * i;
                        }
                    }
                }
            }
            //====================
            Console.Write("最大面積為{0}\n", max);
            Console.ReadKey(true);
        }
    }
}
