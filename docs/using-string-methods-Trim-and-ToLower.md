# Using String Methods Trim and ToLower

```cs
string question2 = "What is 2 plus 2";
string answer2 = "4";

string question3 = "What color do you get by mixing blue and yellow";
string answer3 = "green";

int score = 0;

Console.WriteLine(question1);
string userAnswer1 = Console.ReadLine();
if (userAnswer1.Trim() == answer1) 👈
{
    Console.WriteLine("Correct");
    score++;
}
else
{
    Console.WriteLine("Wrong, the correct anser is: " + answer1);
}

```

```console
Hello, World!
What is capital in Germany
  Berlin
Correct
What is 2 plus 2
```

- `.Trim()` Method :  
  Removing spaces from start and the end of the string

```cs

string question2 = "What is 2 plus 2";
string answer2 = "4";

string question3 = "What color do you get by mixing blue and yellow";
string answer3 = "green";

int score = 0;

Console.WriteLine(question1);
string userAnswer1 = Console.ReadLine();
if (userAnswer1.Trim().ToLower() == answer1) 👈
{
    Console.WriteLine("Correct");
    score++;
}
else
{
    Console.WriteLine("Wrong, the correct ansser is: " + answer1);
}
```

- `.ToLower()` Method :  
  Make All characters in string to lower case 

- There is also `.ToUpper()` Method 

🔑 By using the `()` We basically execute the Method and then we can apply another Method  
on top of that as well like → ` .Trim().ToLower() `