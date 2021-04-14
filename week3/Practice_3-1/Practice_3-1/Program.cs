using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            while (1 > 0)
            {
                Console.Write("輸入y來開始隨機發牌，輸入n結束遊戲: ");
                string input = Console.ReadLine();

                //y
                if (input == "y")
                {
                    int[,] player = new int[4, 13];
                    int[] size = new int[] { 0, 0, 0, 0 };

                    //distribute
                    Random ran = new Random();
                    for (int i = 1; i <= 52; i++)
                    {
                        while (1 > 0)
                        {
                            int n = ran.Next(0, 4);
                            if (size[n] < 13)
                            {
                                //Console.Write("{0} ", n);
                                player[n, size[n]] = i;
                                size[n]++;
                                break;
                            }
                        }
                    }

                    //display
                    for (int i = 0; i < 4; i++)
                    {
                        Console.Write("玩家{0}獲得的牌:", i + 1);
                        for (int j = 0; j < 13; j++)
                        {
                            Console.Write(" ");
                            switch (player[i, j] / 13)
                            {

                                case 0: Console.Write("A_"); break;
                                case 1: Console.Write("B_"); break;
                                case 2: Console.Write("C_"); break;
                                case 4:
                                case 3: Console.Write("D_"); break;
                            }
                            player[i, j] = player[i, j] % 13;
                            if (player[i, j] == 0)
                            {
                                player[i, j] = 13;
                            }
                            Console.Write("{0}", player[i, j]);
                        }
                        Console.Write("\n");
                    }
                    //==========
                    //pair or not
                    for (int i = 0; i < 4; i++)
                    {
                        int ispair = 0;
                        int[] pair = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
                        for (int j = 0; j < 13; j++)
                        {
                            pair[player[i, j] - 1]++;
                            if (pair[player[i, j] - 1] >= 2)
                            {
                                ispair = 1;
                                //break;
                            }
                        }
                        if (ispair == 1)
                        {
                            Console.Write("玩家{0}有對子:", i + 1);
                            for (int j = 0; j < 13; j++) if (pair[j] >= 2) Console.Write(" {0}", j + 1);
                            Console.Write("\n");
                        }
                        else Console.Write("玩家{0}無對子\n", i + 1);
                    }
                }


                else if (input == "n") break;
            }
        }
    }
}
