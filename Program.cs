Console.WriteLine("Hello, World!");

string question1 = "What is capital in Germany";
string answer1 = "Berlin";

string question2 = "What is 2 plus 2";
string answer2 = "4";

string question3 = "What color do you get by mixing blue and yellow";
string answer3 = "green";

int score = 0;

Console.WriteLine(question1);
string userAnswer1 = Console.ReadLine();
if (userAnswer1 == answer1)
{
    Console.WriteLine("Correct");
    score++;
}
else
{
    Console.WriteLine("Wrong, the correct anser is: " + answer1);
}

Console.WriteLine(question2);
string userAnswer2 = Console.ReadLine();
if (userAnswer2 == answer2)
{
    Console.WriteLine("Correct");
    score++;
}
else
{
    Console.WriteLine("Wrong, the correct anser is: " + answer2);
}
Console.WriteLine(question3);
string userAnswer3 = Console.ReadLine();
if (userAnswer3 == answer3)
{
    Console.WriteLine("Correct");
    score++;
}
else
{
    Console.WriteLine("Wrong, the correct anser is: " + answer3);
}

if (score == 3)
{
    Console.WriteLine("You guessed all Right congratulations !");
}
else if (score > 0)
{

    Console.WriteLine("Try again and see if see get some answer right next time");
}
else
{
    Console.WriteLine("Damn you are retarded");
}

Console.ReadKey();