using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero
{
    internal class Hero : Person
    {
        public Hero(string name, string nickname, int age, List<string> powerList, int heroID, int deedTime) : base(name, nickname, age, powerList)
        {
            HeroID = heroID;
            DeedTime = deedTime;
        }

        public int HeroID { get; set; }
        public int DeedTime { get; set; }
        public Hero() : base("Not defined", "Not defined", 0, new List<string>())
        {
            HeroID = 0;
            DeedTime= 0;
        }
        public override void PrintInfo() 
        {
            Console.WriteLine($"{Name} {Nickname} {Age} {HeroID} {DeedTime}");
        }
        public int CalculateLevel()
        {
            int level = 0;
            if (DeedTime < 20)
            {
                level = 1;
            }
            if (DeedTime >= 20 && DeedTime <= 40)
            {
                level = 2;
            }
            if (DeedTime > 40)
            {
                level = 3;
            }
            return level;
        }
        public void PrintGeneralInfo() 
        {
            Console.WriteLine(".......POWERS..........");
            Console.WriteLine($"Hero: {Name}");
            Console.WriteLine($"Nickname: {Nickname}");
            Console.WriteLine($"Age: {Age}");
            foreach (var power in PowerList)
             {
            Console.WriteLine($"Powers: {power}");
            }
        }
    }
}





