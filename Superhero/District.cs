using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superhero
{
    internal class District
    {
        public string Title { get; set; }
        public string City { get; set; }
        public int DistrictID { get; set; }
        public List<Hero> HeroesInTheDistrict { get; set; }
        public List<Villain> VillainsInTheDistrict { get; set; }
        public District()
        {
            Title = "Not defined";
            City = string.Empty;
            DistrictID = 0;
            HeroesInTheDistrict = new List<Hero>();
        }
        public District(string title, string city, int districtID, List<Hero> herosInTheDistrict, List<Villain> villainsInTheDistrict)
        {
            this.Title = title;
            this.City = city;
            this.DistrictID = districtID;
            this.HeroesInTheDistrict = herosInTheDistrict;
            VillainsInTheDistrict = villainsInTheDistrict;
        }
        public void AddHero(Hero hero)
        {
            Console.WriteLine($"We have added to {Title} hero {hero.Nickname}");
            HeroesInTheDistrict.Add(hero);
        }
        public void RemoveHero(int position)
        {
            Console.WriteLine($"We removed the hero {HeroesInTheDistrict[position].Nickname} from {Title}");
            HeroesInTheDistrict.RemoveAt(position);
        }
        public void PrintInformationAboutDistrict()
        {
            Console.WriteLine($".........{City}.........");
            Console.WriteLine($"District: {Title}");
            Console.WriteLine($"ID: {DistrictID}");
            PrintListOfHeroes();
            PrintListOfVillains();
        }
        public void PrintListOfHeroes()
        {
            Console.WriteLine(".........List of superheroes.........");
            Console.WriteLine($"{Title} {City}, ID: {DistrictID}");
            foreach (var hero in HeroesInTheDistrict)
            {
                hero.PrintGeneralInfo();
            }
        }
        public void PrintListOfVillains()
        {
            Console.WriteLine(".........List of villains.........");
            Console.WriteLine($"{Title} {City}, ID: {DistrictID}");
            foreach (var villain in VillainsInTheDistrict)
            {
                villain.PrintGeneralInfo();
            }
        }
        public double CalculateAvgLevelInDistrict()
        {
            double totalHeroLevel = 0;
            foreach (var hero in HeroesInTheDistrict)
            {
                totalHeroLevel += hero.CalculateLevel();
            }
            var averageLevel = totalHeroLevel / HeroesInTheDistrict.Count;
            return averageLevel;
        }
        public int CalculateTotalCrimeTime()
        {
            int totalCrimeTime = 0;
            foreach (var villain in VillainsInTheDistrict)
            {
                totalCrimeTime += villain.CrimeTime;
            }
            return totalCrimeTime;
        }
    }
}
