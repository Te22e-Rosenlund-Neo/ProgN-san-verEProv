using Hjältar;

Console.WriteLine("Vilken typ av hjälte vill du skapa?");

int Type;
// en lista av möjliga alternativ spelaren kan skriva in
string[] options = { "1", "2" };
string input;
GodHjälte God;
OndHjälte Ond;
//kollar att inputen spelaren givit är 1 eller 2 
do
{
    Console.WriteLine("1 för godhjälte");
    Console.WriteLine("2 för ondhjälte");
    input = Console.ReadLine() ?? "";
} while (!options.Contains(input));

Type = Convert.ToInt32(input);

Console.WriteLine("Vilket namn ska din hjälte ha?");
//kollar inputen och skapar en karaktär beroende på vilken man valt
if (Type == 1)
{
    God = new GodHjälte(Console.ReadLine(), Random.Shared.Next(1, 4), Random.Shared.Next(1, 4));
    God.Information();
}
else if (Type == 2)
{
    Ond = new OndHjälte(Console.ReadLine(), Random.Shared.Next(1, 4), Random.Shared.Next(1, 4));
    Ond.Information();
}

Console.ReadLine();


