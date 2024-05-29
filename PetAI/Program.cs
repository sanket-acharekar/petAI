// See https://aka.ms/new-console-template for more information


String typePrompt = "Select your favorite pet type using numbers below:\n";


String petTypeStr = "";
do
{
    Console.WriteLine(typePrompt + "1. Cat \n2. Dog \n3. Rabbit");
    int petType = int.Parse(Console.ReadLine());
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
        default:
            Console.WriteLine("Please select a valid pet type");
            break;
}
Console.WriteLine("\nUser input: " + petTypeStr);
} while (petTypeStr == "");

Console.WriteLine("\nWhat would you like to name your " +petTypeStr+ "?");
string petName = Console.ReadLine();
Console.WriteLine("\nUser input: " + petName);

Console.WriteLine("\nYou have chosen a " + petTypeStr +". Welcome " + petName + " to pet AI program.");

int hunger = 5;
int happiness = 5;
int health = 5;

int mainMenuSelection = 1;

do
{
    if(mainMenuSelection > 0 && mainMenuSelection < 6)
{
    Console.WriteLine("\nMain Menu \n" +
        "1. Feed " + petName + "\n" +
        "2. Play with " + petName + "\n" +
        "3. Let " + petName + " rest \n" +
        "4. Check " + petName + "'s status \n" +
        "5. Exit \n" +
        "Please select a menu");
    }
    mainMenuSelection = int.Parse(Console.ReadLine());
    Console.WriteLine("\nUser input: " + mainMenuSelection);

    switch (mainMenuSelection)
    {
        case 1:
            hunger = hunger - 2;
            health = health + 1;
            Console.WriteLine("\nYou fed " + petName + ". " + petName + "'s Hunger Decreases and health slightly increases.");
            break;

        case 2:
            if(hunger > 7)
            {
                Console.WriteLine(petName + " is hungry and refusing to play. Please feed it");
            } else
            {
            happiness = happiness + 2;
            hunger = hunger + 1;
            Console.WriteLine("\nYou played with " + petName + ". " + petName + "'s Happiness increases and hunger slightly increases");
            }
            break;

        case 3:
            health = health + 2;
            happiness = happiness - 1;
            hunger = hunger + 1;
            Console.WriteLine("\n"+ petName + " has rested. " + petName + "'s health is improved but " + petName + " is a bit gloomy.");
            break;

        case 4:
            hunger = hunger + 1;
            happiness = happiness - 1;
            Console.WriteLine("\n"+ petName + " status : \n Health : " + health + "" +
                "\n Happiness : " + happiness + "" +
                "\n Hunger : " + hunger);
            break;

        case 5:
            break;
        default:
            Console.WriteLine("Entered selection is not supported. Please select an action from above given list");
            break;
    }

    if (hunger > 10) hunger = 10;
    if (hunger < 1) hunger = 1;

    if (happiness > 10) happiness = 10;
    if (happiness < 1) happiness = 1;

    if (health > 10) health = 10;
    if (health < 1) health = 1;

    if(health < 3)
    {
        Console.WriteLine("\n***** " + petName + "'s health is deteriorating. Please take care of your pet *****");
    }
    if (happiness <= 3)
    {
        Console.WriteLine("\n***** " + petName + " is getting sad. Please play with it. *****");
    }
    if (hunger > 8)
    {
        Console.WriteLine("\n***** " + petName + " is hungry. Please feed it. *****");
    }
    if(health > 7 && hunger < 3 && happiness > 7)
    {
        Console.WriteLine("\n ***** You are taking good care of " + petName + ". Good job!!! *****");
    }

    //Console.WriteLine("\n"+ hunger +" " + happiness +" "+ health);
} while (mainMenuSelection != 5);