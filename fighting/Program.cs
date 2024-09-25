int hp1 = Random.Shared.Next(80, 100);
int hp2 = Random.Shared.Next(80, 100);

string name1;
string name2;

Console.WriteLine("Skriv namn på player 1 och player 2");
name1 = Console.ReadLine();
name2 = Console.ReadLine();

Console.WriteLine($"{name1} vs {name2} ");
Console.ReadLine();


while(hp1 > 0 || hp2 > 0)
{
Console.WriteLine($"{name1}: {hp1}");
int damage1 = Random.Shared.Next(4, 10);
hp1 -= damage1;
Console.WriteLine($"{name2} did {damage1} damage to {name1}");
  Thread.Sleep(1000);  
Console.WriteLine($"{name1}: {hp1}");
Console.WriteLine($"{name2}: {hp2}");
int damage2 = Random.Shared.Next(4, 10);
hp2 -= damage2;
Console.WriteLine($"{name1} did {damage2} damage to {name2}");
Thread.Sleep(1000);  
Console.WriteLine($"{name2}: {hp2}"); 
}
Console.ReadLine();



