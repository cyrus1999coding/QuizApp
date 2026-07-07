# How to use try parse

🔑 `TryParse` is a **Method** that allows us to work around the problem of the user entrting something that is not a number when we;re actually asking the User for a number .

```cs
Console.Write("Give me a number ");
string inputString = Console.ReadLine();

int num1 = int.Parse(inputString);
num1++;
Console.WriteLine("User entered number +1 " + num1);

Console.ReadKey();
```

```console
Give me a number 15
User entered number +1 16
```

What i we don't enter a number ❔  
💥 :  
```cs
Console.Write("Give me a number ");
string inputString = Console.ReadLine();

int num1 = int.Parse(inputString); ❌
num1++;
Console.WriteLine("User entered number +1 " + num1);

Console.ReadKey();
```

```console
Give me a number ko
```
- ❌ System.FormatException: 'The input string 'ko' was not in a correct format.'

💡 There is a `TryParse` :  
- In neeed to have `inputString`
- It need to know `where` to store the result of that `conversion`

```cs
Console.Write("Give me a number ");
string inputString = Console.ReadLine();

int num1;

int.TryParse(inputString, out num1);

num1++;
Console.WriteLine("User entered number +1 " + num1);

Console.ReadKey();
```

```console
Give me a number 15
User entered number +1 16
```

```console
Give me a number
User entered number +1 1
```

🔑 ↓

```console
Give me a number ko
User entered number +1 1
```

- `int.TryParse(inputString, out num1);` :  
  It will get the User Input and it will try to `.Parse()` it and if it worked it will store the result in `num1` .  
  And if it not work

Now how can we use this in order to figure out if the User has entered a right number or not ❔
💡 :  
We can use something like `If statement`s  ↓

```cs
Console.Write("Give me a number ");
string inputString = Console.ReadLine();

int num1;

bool isNumber = int.TryParse(inputString, out num1); 👈

num1++;
Console.WriteLine("User entered number +1 " + num1);

Console.ReadKey();
```

- `bool isNumber = int.TryParse(inputString, out num1)` :   
  🔑 This `int.TryParse()` returns a `bool` .

So we can ↓  

```cs
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
    Console.WriteLine("HAHA you trolled you should've entered a number");
}

num1++;
Console.WriteLine("User entered number +1 " + num1);

Console.ReadKey();
```

```console
Give me a number ko
HAHA you trolled you should've entered a number
User entered number +1 1
```

- 🔑 GPT :  
  ```cs
  int.TryParse("ko", out num1);
  ```
  It fails:
  ```cs
  isNumber = false
  ```
  and because it failed, C# sets the `out variable` to the 🔑 `default value` of int:
  ```cs
  num1 = 0;
  ```
  Then your code continues:
  ```cs
  num1++;
  ```
  Now: 
  ```cs
  0 + 1 = 1
  ```
  so you get:
  ```cs
  User entered number +1 1
  ```

- 🔑 GPT :
  The `method` puts the `value` directly into your variable → ( `out` ).

So we the `.TryParse()` in order to convert a `string` into a `integer` number and if does work then we  
get a number `out` .  
And if it doesn't work we won't get a number `out` .