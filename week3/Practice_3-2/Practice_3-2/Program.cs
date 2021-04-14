using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_3_2
{
    class Program
    {
        static int SIZE = 12;
        static int[] dir_x = new int[]{ 1, 2, 2, 1, -1, -2, -2, -1 };
        static int[] dir_y = new int[]{ -2, -1, 1, 2, 2, 1, -1, -2 };

        static int if_grid_exists(int num, int dir)
        {
            if (num % SIZE + dir_x[dir] >= 0 && num % SIZE + dir_x[dir] < SIZE && num / SIZE + dir_y[dir] >= 0 && num / SIZE + dir_y[dir] < SIZE)
                return 1;
            return 0;
        }

        static void reduce_canwalk(int num, ref int[] steps_order, ref int[] steps_canwalk)
        {
            steps_canwalk[num] = -1;
            for (int i = 0; i < 8; i++)
                if (if_grid_exists(num, i) == 1)
                    if (steps_order[SIZE * (num / SIZE + dir_y[i]) + num % SIZE + dir_x[i]] == -1)
                        steps_canwalk[SIZE * (num / SIZE + dir_y[i]) + num % SIZE + dir_x[i]]--;
        }

        static int find_dir(int num, ref int[] steps_canwalk)
        {
            int min = 100;
            int dir = 100;
            for (int i = 0; i < 8; i++)
                if (if_grid_exists(num, i) == 1)
                    if (steps_canwalk[SIZE * (num / SIZE + dir_y[i]) + num % SIZE + dir_x[i]] >= 0)
                        if (steps_canwalk[SIZE * (num / SIZE + dir_y[i]) + num % SIZE + dir_x[i]] < min)
                        {
                            min = steps_canwalk[SIZE * (num / SIZE + dir_y[i]) + num % SIZE + dir_x[i]];
                            dir = i;
                        }       
                 
            return dir;
        }

        static void Main(string[] args)
        {
            //initialize arrays
            int[] steps_order = new int[SIZE * SIZE]; //record steps order
            for (int i = 0; i < SIZE * SIZE; i++) steps_order[i] = -1; //record how many paths can walk
            int[] steps_canwalk = new int[SIZE * SIZE];
            for (int i = 0; i < SIZE * SIZE; i++) steps_canwalk[i] = 0;
            for (int i = 0; i < SIZE * SIZE; i++)
                for (int j = 0; j < 8; j++)
                    if (if_grid_exists(i, j)==1)
                        steps_canwalk[i]++;

            //=========

            //set initial grid
            Random ran = new Random();
            int init = ran.Next(0, 144);
            //int init = 113; //this line is for test
            steps_order[init] = 1;
            reduce_canwalk(init, ref steps_order, ref steps_canwalk);

            //==========

            //start calculate
            int now_grid = init;
            int fail = 0;

            for(int i = 2; i <= SIZE * SIZE; i++)
            {
                fail = 0;
                int dir = find_dir(now_grid, ref steps_canwalk);
                if(dir == 100)
                {
                    fail = i;
                    break;
                }
                else
                {
                    now_grid = SIZE * (now_grid / SIZE + dir_y[dir]) + now_grid % SIZE + dir_x[dir];
                    steps_order[now_grid] = i;
                    reduce_canwalk(now_grid, ref steps_order, ref steps_canwalk);
                }
            }

            //=============

            //print
            Console.WriteLine("Initial point: {0}", init + 1);

            if (fail != 0)
            {
                Console.WriteLine("No Answer.");
                Console.WriteLine("Die when finding step {0}.", fail);
                Console.WriteLine();
            } 
            else
            {
                Console.WriteLine("Success.");
                Console.WriteLine();

                Console.WriteLine("Steps: ");
                Console.Write("{0}", init + 1);
                for(int i = 2; i <= SIZE * SIZE; i++)
                {
                    for (int j = 0; j < SIZE * SIZE; j++)
                        if (steps_order[j] == i)
                            Console.Write(" -> {0}", j + 1);
                    if (i % SIZE == 0) Console.Write("\n");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Chessmap: ");
            for (int i = 0; i < SIZE * SIZE; i++)
            {
                Console.Write("{0}\t", steps_order[i]);
                if ((i + 1) % SIZE == 0) Console.Write("\n");
            }

            if (fail != 0) Console.WriteLine("*The grids with value -1 are which can't be passed.");

            Console.ReadKey(true);
        }
    }
}
