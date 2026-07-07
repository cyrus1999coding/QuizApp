Console.Write("Give me a number ");
string inputString = Console.ReadLine();

int num1;

bool isNumber = int.TryParse(inputString, out num1);

if (isNumber)
{
    Console.WriteLine("Well done you entered a number");
}
else
{
    Console.WriteLine("HAHA you trolled you should've entered a numbe");
}

num1++;
Console.WriteLine("User entered number +1 " + num1);

Console.ReadKey();