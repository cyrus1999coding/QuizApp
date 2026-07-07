Random random = new Random();

int randomNumber = random.Next(1, 11);

Console.WriteLine("Guess the number !");

int num1 = 0;

string userInput = Console.ReadLine();

bool isNumber = int.TryParse(userInput, out num1);

if (isNumber)
{
    if (num1 == randomNumber)
    {
        Console.WriteLine("You guesses right congratulations");
    }
    else
    {
        Console.WriteLine("You guess wrong try again ");
    }
}
else
{
    Console.WriteLine("Heh yu trolled, You should've entered a number");

}

Console.ReadKey();