// See https://aka.ms/new-console-template for more information\
int age;
int food;
bool hunger;

Console.Write("What is your name: ");
string name = Console.ReadLine();

while (string.IsNullOrEmpty(name))
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Please enter a name: ");
    Console.ResetColor();
    name = Console.ReadLine();
}
Console.Write("What is your age: ");
while (int.TryParse(Console.ReadLine(), out age) == false || age == 0)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.Write("Please enter a valid age: ");
    Console.ResetColor();
}
Gender();
Console.Clear();


Aging();

Console.Clear();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("*You have died");
Console.ResetColor();






void Gender()
{
    while (true)
    {
        Console.Write("What is your gender? (Male/Female): ");
        string gender = Console.ReadLine();




        if (gender == "Male")
        {
            break;
        }
        else if (gender == "Female")
        {
            break;
        }
        else
        {

        }
    }
}
void Aging()
{
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Press enter to age");
        Console.WriteLine("Your current age is " + age);
        Console.ReadLine();
        age++;

        if (age == 100)
        {
            break;

        }

        if (age % 10 == 0)
        {
            Food();

            if (food == 4)
            {
                break;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("*You have died");
                Console.ResetColor();
            }




        }

    }

}
void Food()
{
    

    

    Console.WriteLine("Pick an option (1-4)");

    Console.Write("(1) Pizza"); Console.Write(" (2) Hotdog"); Console.Write(" (3) Burger");
    Console.Write(" (4)"); Console.ForegroundColor = ConsoleColor.Red; Console.Write(" If you don't eat, you will die lol"); Console.ResetColor();

    Console.Write("\n");

    while (int.TryParse(Console.ReadLine(), out food) == false || food > 4 || food < 1)
    {
        Console.Write("Pick a valid number (1-3): ");
    }



    if (food == 1)
    {
       
    }
    else if (food == 2)
    {
       
    }
    else if (food == 3)
    {
       
    }
    


}
