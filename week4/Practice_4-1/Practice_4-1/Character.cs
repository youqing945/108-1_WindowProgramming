using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_4_1
{
    class Character
    {
        protected string type; //name ex: Saber, Archer...
        protected string[] typesStrongTo; //enemies that this char is strong to (attack *= 2)
        protected string[] typesWeakTo; //enemies that this char is weak to (attack *= 0.5)
        protected double health;
        protected double attack; //default attack value
        protected double attackBuff; //attack buff ratio (attack *= attackBuff)
        protected double hitRate; // if a Random.nextDouble > hitRate, this attack count as 0

        //=======================================
        public double attackWithRatio(string enemyType) //Calculate the attack this char generates
        {
            double fa = attack * attackBuff;
            for(int i=0;i<typesStrongTo.Length;i++)
                if (typesStrongTo[i] == enemyType)
                {
                    fa = fa * 2;
                    break;
                }
            for (int i = 0; i < typesWeakTo.Length; i++)
                if (typesWeakTo[i] == enemyType)
                {
                    fa = fa * 0.5;
                    break;
                }
            Random ran = new Random();
            if (ran.NextDouble() > hitRate) fa = 0;
            return fa;
        }
        public string getType() //Get this char's type
        {
            return type;
        }
        public double getHealth() //Get this char's health
        {
            return health;
        }
        public void setHealth(double newHealth) //Set this char's health
        {
            health = newHealth;
        }

        //=======================================
        public Character(int flag)
        {
            if (flag == 0)
            {
                type = "Saber";
                typesStrongTo = new string[2] { "Lancer", "Berserker" };
                typesWeakTo = new string[1] { "Archer" };
                health = 100;
                attack = 50;
                attackBuff = 1;
                hitRate = 1;
            }
            else if (flag == 1)
            {
                type = "Archer";
                typesStrongTo = new string[2] { "Saber", "Berserker" };
                typesWeakTo = new string[1] { "Lancer" };
                health = 50;
                attack = 100;
                attackBuff = 0.95;
                hitRate = 0.5;
            }
            else if (flag == 2)
            {
                type = "Lancer";
                typesStrongTo = new string[2] { "Archer", "Berserker" };
                typesWeakTo = new string[1] { "Saber" };
                health = 75;
                attack = 75;
                attackBuff = 1.05;
                hitRate = 0.75;
            }
            else if(flag == 3)
            {
                type = "Rider";
                typesStrongTo = new string[2] { "Caster", "Berserker" };
                typesWeakTo = new string[1] { "Assassin" };
                health = 150;
                attack = 50;
                attackBuff = 1;
                hitRate = 0.8;
            }
            else if (flag == 4)
            {
                type = "Caster";
                typesStrongTo = new string[2] { "Assassin", "Berserker" };
                typesWeakTo = new string[1] { "Rider" };
                health = 200;
                attack = 25;
                attackBuff = 0.9;
                hitRate = 1;
            }
            else if (flag == 5)
            {
                type = "Assassin";
                typesStrongTo = new string[2] { "Rider", "Berserker" };
                typesWeakTo = new string[1] { "Caster" };
                health = 50;
                attack = 100;
                attackBuff = 0.9;
                hitRate = 1;
            }
            else if(flag == 6)
            {
                type = "Berserker";
                typesStrongTo = new string[7] { "Saber", "Archer", "Lancer", "Rider", "Caster", "Assassin", "Berserker" };
                typesWeakTo = new string[1] { "none" };
                health = 60;
                attack = 100;
                attackBuff = 1.1;
                hitRate = 1;
            }
        }
    }
}
