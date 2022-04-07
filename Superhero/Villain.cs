using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero
{
    internal class Villain : Person
    {
        public int VillainID { get; set; }
        public int CrimeTime { get; set; }
        public Villain(): base("Not defined", "Not defined", 0, new List<string>())
        {
            VillainID = 0;
            CrimeTime = 0;
        }
        public Villain(string name, string nickname, int age, int villainID, int crimeTime, List<string>powerList) :base (name, nickname, age, powerList)
        {
            Name = name;
            Nickname = nickname;
            Age = age;
            VillainID = villainID;
            CrimeTime = crimeTime;
        }
        public override void PrintGeneralInfo()
        {
            base.PrintGeneralInfo();
            Console.WriteLine($"Villain's Crime time: {CrimeTime}");
            Console.WriteLine($"VillainID: {VillainID}");
            Console.WriteLine("******************************************** \n \n");
        }
        public int CalculateLevel()
        {
            int level = 0;
            if (CrimeTime < 20)
            {
                level = 1;
            }
            if (CrimeTime >= 20 && CrimeTime <= 40)
            {
                level = 2;
            }
            if (CrimeTime > 40)
            {
                level = 3;
            }
            return level;
        }
    }
}
