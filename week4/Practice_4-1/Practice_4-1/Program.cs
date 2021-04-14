using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_4_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            int endgame = 0; //0:new game 1:going on 2:win new game
            Character player = new Character(ran.Next() % 7);
            Character enemy = new Character(ran.Next() % 7);
            //==============================

            Console.Write("輸入y來開始遊戲，n退出遊戲：");
            int endprogram = 0;
            double playerph = 0, enemyph = 0; //previous health
            double playerfa = 0, enemyfa = 0; //final attack
            while (1>0)
            {
                switch (Console.ReadLine())
                {
                    case "n":
                        endprogram = 1;
                        break;
                    case "y":
                        if (endgame == 0) //new game
                        {
                            player = new Character(ran.Next() % 7);
                            enemy = new Character(ran.Next() % 7);
                        }
                        else if(endgame == 1) //going on
                        {
                        }
                        else if(endgame == 2) //win new game
                        {
                            enemy = new Character(ran.Next() % 7);
                        }
                        playerph = player.getHealth();
                        enemyph = enemy.getHealth();
                        playerfa = player.attackWithRatio(enemy.getType());
                        enemyfa = enemy.attackWithRatio(player.getType());
                        player.setHealth(player.getHealth()-enemyfa);
                        enemy.setHealth(enemy.getHealth()-playerfa);
                        if (player.getHealth() <= 0) endgame = 0;
                        else
                        {
                            if (enemy.getHealth() <= 0) endgame = 2;
                            else endgame = 1;
                        }
                        //----------------
                        Console.Write("您的角色為" + player.getType() + "，此回合前血量" + playerph + "，攻擊對方" + playerfa + "，此回合後血量" + player.getHealth() + "\n\n");
                        Console.Write("敵人角色為" + enemy.getType() + "，此回合前血量" + enemyph + "，攻擊我方" + enemyfa + "，此回合後血量" + enemy.getHealth() + "\n\n");
                        if (endgame == 0) Console.Write("您已死亡，輸入y來重新遊戲，n退出遊戲：");
                        else if (endgame == 1) Console.Write("雙方均存活，輸入y來進行下一回合，n退出遊戲：");
                        else if (endgame == 2) Console.Write("敵人倒下，此回合獲勝，輸入y來繼續遊戲，n退出遊戲：");
                        break;
                }
                if (endprogram == 1) break;
            }
        }
    }
}
