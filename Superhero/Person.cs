using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero
{
    internal class Person
    {
        public string Name { get; set; }
        public string Nickname { get; set; }
        public int Age { get; set; }
        public List<string> PowerList { get; set; }

        public Person(string name, string nickname, int age, List<string> powerList)
        {
            Name = name;
            Nickname = nickname;
            Age = age;
            PowerList = powerList;
        }
        public virtual void PrintInfo()
        {
            Console.WriteLine($"Name:{Name}\n Nickname: {Nickname}\n Age: {Age}");
        }
        public virtual void PrintGeneralInfo()
        {
            Console.WriteLine(".........GENERAL INFO.........");
            Console.WriteLine($"Hero: {Nickname}");
            Console.WriteLine($"Age:  {Age} year old");
            Console.WriteLine($"SuperPersons powers2d array: \n ");
            for (int i = 0; i < PowerList.Count; i++)
            {
                Console.WriteLine($"{i}. {PowerList[i]} ");
            }
        }
    }
}
