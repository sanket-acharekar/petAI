// See https://aka.ms/new-console-template for more information


String typePrompt = "Select your favorite pet type using numbers below:\n";


Console.WriteLine(typePrompt + "1. Cat \n2. Dog \n3. Rabbit");
int petType = int.Parse(Console.ReadLine());
Console.WriteLine("\nUser input: " + petType);
String petTypeStr = "";
switch (petType)
{
    case 1:
        petTypeStr = "cat";
        break;
    case 2:
        petTypeStr = "dog";
        break;
    case 3:
        petTypeStr = "rabbit";
        break;
}

Console.WriteLine("\nWhat would you like to name your " +petTypeStr+ "?");
string petName = Console.ReadLine();
Console.WriteLine("\nUser input: " + petName);

Console.WriteLine("\nYou have chosen a " + petTypeStr +". Welcome " + petName + " to pet AI program.");
