// See https://aka.ms/new-console-template for more information
using Superhero;
Hero defaultHero = new Hero();

Hero hero = new Hero("Steve", "Fluffy", 30, new List<string> { "Can make you tell only the truth" }, 0, 55);
Hero hero1 = new Hero("George", "Moony", 27, new List<string> { "Can eat a lot" }, 1, 41);
Hero hero2 = new Hero("Silvester", "Sunman", 25, new List<string> {"Can burn everything"}, 2,  21);
Hero hero3 = new Hero("Alan", "Star", 35, new List<string> {"Can lift very heavy objects"}, 3, 32);
Hero hero4 = new Hero("Alda", "Auntie", 32, new List<string> { "Can fly" }, 4, 27);
Hero hero5 = new Hero("James", "Jim", 35, new List<string> { "Can drink everything" }, 5, 60);
Hero hero6 = new Hero("Mary", "Sunny", 29, new List<string> { "Can turn into an animal" }, 6, 22);
Villain villain = new Villain("John", "Milkman", 33, 0, 7, new List<string> {"Laser eyes"});
Villain villain1 = new Villain("Ana", "April", 28, 1, 5, new List<string> { "Can freeze you with a look"});
Villain villain2 = new Villain("Beatrice", "Betty", 29, 2, 6, new List<string> {"Can put you into a sleep"});
List<Hero> MezciemsHeroes = new List<Hero>();
MezciemsHeroes.Add(hero);
MezciemsHeroes.Add(hero1);
MezciemsHeroes.Add(hero2);
MezciemsHeroes.Add(hero3);
List<Hero> PurvciemsHeroes = new List<Hero>();
PurvciemsHeroes.Add(hero4);
PurvciemsHeroes.Add(hero5);
PurvciemsHeroes.Add(hero6);
List<Villain> MezciemsVillains = new List<Villain>();
MezciemsVillains.Add(villain);
List<Villain> PurvciemsVillains = new List<Villain>();
PurvciemsVillains.Add(villain1);
PurvciemsVillains.Add(villain2);

District mezciems = new District("Mezciems", "Riga", 1, MezciemsHeroes, MezciemsVillains);
mezciems.PrintInformationAboutDistrict();

District purvciems = new District("Purvciems", "Riga", 2, PurvciemsHeroes, PurvciemsVillains);
purvciems.PrintInformationAboutDistrict();

int deedTimeInHours1, deedTimeInHours2, deedTimeInHours3;
deedTimeInHours1 = 2;
deedTimeInHours2 = 5;
deedTimeInHours3 = 8;
double totalTime = deedTimeInHours1 + deedTimeInHours2 + deedTimeInHours3;
var averageTime = totalTime / 3;
double rewardMoney = totalTime * 5;
//double cookiesPerHour = 5;

double monthlySalary = 1000;
double dailySalary = Math.Round(monthlySalary / 30, 2);
bool isEvil = false;
double cookiesCost = 2;
double boughtCookies = Math.Floor(dailySalary/cookiesCost);

/*Console.WriteLine(".........FINANCIAL INFO.........");

Console.WriteLine($"Fluffy can buy {monthlySalary/cookiesCost}");
Console.WriteLine($"Fluffy earns {monthlySalary}");
Console.WriteLine($"The average time Fluffy spends {averageTime}");
Console.WriteLine($"Fluffy is evil {isEvil}");
Console.WriteLine($"Fluffy bought {boughtCookies} cookies");*/

string[] superHeroNameList = { "Sunny", "Moony", "Starman", "MilkyWay" };
bool isMenuRunning = true;

do
{
    string menuItems;

    Console.WriteLine("Hello and welcome to the Superhero application!");
    Console.WriteLine("Select what to do:");
    Console.WriteLine("1 - Show a list of superheroes");
    Console.WriteLine("2 - Show a specific hero");
    Console.WriteLine("3 - Add a superhero");
    Console.WriteLine("4 - Delete a superhero");
    Console.WriteLine("5 - OOP hero");
    Console.WriteLine("6 - Exit this application");
    Console.WriteLine("7 - District info");

    menuItems = Console.ReadLine();
    switch (menuItems)
    {
        case "1":
            Console.WriteLine(".......LIST OF SUPERHEROES.......");
            for (int i = 0; i < superHeroNameList.Length; i++)
            {
                Console.WriteLine($"{i}. {superHeroNameList[i]}");
            }
            Console.WriteLine(".................................");
            break;
        case "2":
            Console.WriteLine("Please choose a superhero by number");
            for (int i = 0; i < superHeroNameList.Length; i++)
            {
                Console.WriteLine($"{i}. {superHeroNameList[i]}");
            }
            int.TryParse(Console.ReadLine(), out int chosenNumber);
            Console.WriteLine($"You have chosen {superHeroNameList[chosenNumber]}");
            Console.WriteLine("Choose what type of info to show");
            Console.WriteLine("1 - GENERAL INFO");
            Console.WriteLine("2 - FINANCIAL INFO");
            string showMenu = Console.ReadLine();
            if (showMenu == "1")
            {
                Console.WriteLine(".........GENERAL INFO.........");
                Console.WriteLine($"Hero: {superHeroNameList[chosenNumber]}");
                Console.WriteLine("Age: " + 30 + " year old");
                Console.WriteLine("Hero powers: \n {0}, \n {1},\n {2}\n", "HeroPower1", "HeroPower2", "HeroPower3");
                Console.WriteLine("................................ \n \n");
            }
            else if (showMenu == "2")
            {
                monthlySalary = 1000;
                deedTimeInHours1 = 2;
                deedTimeInHours2 = 5;
                deedTimeInHours3 = 8;
                totalTime = deedTimeInHours1 + deedTimeInHours2 + deedTimeInHours3;
                averageTime = totalTime / 3;

                cookiesCost = 2;
                boughtCookies = Math.Floor(dailySalary / cookiesCost);
                dailySalary = Math.Round(monthlySalary / 30, 2);

                Console.WriteLine(".........FINANCIAL INFO.........");
                Console.WriteLine($"The hero can buy {boughtCookies}");
                Console.WriteLine($"Our hero earns daily {dailySalary}");
                Console.WriteLine($"Our hero spent {totalTime} hours doing deeds");
                Console.WriteLine($"Our hero on average spent {averageTime} hours per deed");
                Console.WriteLine($"For the deeds our hero got as a reward {rewardMoney} EUR");
            }
            break;
            case "3":
            Console.WriteLine("What is the new superhero name?");
            string superHeroName = Console.ReadLine();
            superHeroNameList = (string[])superHeroNameList.Append(superHeroName);
            Console.WriteLine($"SuperHero {superHeroName} Added!");
            break;
        case "4":
            Console.WriteLine("Which superhero to remove?");
            for (int i = 0; i < superHeroNameList.Length; i++)
            {
                Console.WriteLine($"{i}. {superHeroNameList[i]}");
            }
            int.TryParse(Console.ReadLine(), out int positionToRemove);
            Console.WriteLine($"SuperHero {superHeroNameList[positionToRemove]} Removed!");
            superHeroNameList = superHeroNameList.Remove(positionToRemove);
            break;
        case "5":
            Console.WriteLine($"{defaultHero.Nickname} level is {defaultHero.CalculateLevel()}");
            foreach (Hero heroInDistrict in mezciems.HeroesInTheDistrict)
            {
                if (heroInDistrict.CalculateLevel() > 1)
                {
                    Console.WriteLine($"{heroInDistrict.Nickname} is higher than level 1");
                }
            }
            Console.WriteLine();
            break;
        case "6":
            isMenuRunning = false;
            Console.WriteLine($"Good bye!");
            break;
        default:
            Console.WriteLine("Please choose from the available menu!");
            break;
    }
} while (isMenuRunning);
