# How to generate a random number  

We wanna see how we can create a random number

```cs
Random random = new Random();

Console.ReadKey();
```
- `Random random = new Random()` :  
  🔑 We're creating an `Instance` of a `Class` .  

General idea is inside the entire .Net Framework we have bunch of differnet classes that we can use  
And we are already uses on of those classes all the time → `Console` **Class** .

`Console` `Class` has bunch of `methods` that we can work with it,  
`By default` we don't need to create an `Instance` of the `Console` in order to work with it .  
Otherswise we weould have to ↓  
```cs
Console myConsole = new Console();
```

But with other `Class`es such as `Random` we need to create an `Instance` .

```cs
Random random = new Random();

int randomNumber = random.Next(1, 11);

Console.ReadKey();
```
- `random.Next(1, 11)` :
 This will give us a random number between 1 and 10


```cs
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
```

🔑 For running through this application again, and have a second try the 🔑`Loops` will coming handy .  
Which we do that later .