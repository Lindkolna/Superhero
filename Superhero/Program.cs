// See https://aka.ms/new-console-template for more information
String name = ("Fluffy");
int age = 30;
string HeroPower1, HeroPower2, HeroPower3;
HeroPower1 = "can freeze you with a look";
HeroPower2 = "can make fluffy clouds appear";
HeroPower3 = "can make you tell only truth";

Console.WriteLine(".......POWERS..........");
Console.WriteLine($"Hero: {name}");
Console.WriteLine($"Age: {age}");
Console.WriteLine($"Powers: {HeroPower1}, {HeroPower2}, {HeroPower3}");

int deedTimeInHours1, deedTimeInHours2, deedTimeInHours3;
deedTimeInHours1 = 2;
deedTimeInHours2 = 5;
deedTimeInHours3 = 8;
double totalTime = deedTimeInHours1 + deedTimeInHours2 + deedTimeInHours3;
var averageTime = totalTime / 3;
double cookiesPerHour = 5;

double monthlySalary = 1000;
double dailySalary = Math.Round(monthlySalary/30);
bool isEvil = false;
double cookiesCost = 1.50;

Console.WriteLine("........Financial Info.....");
Console.WriteLine($"The hero can buy {monthlySalary/cookiesCost}");
Console.WriteLine($"The hero earns {monthlySalary}");
Console.WriteLine($"The average time the hero spends {averageTime}");
Console.WriteLine($"The hero is evil {isEvil}");


