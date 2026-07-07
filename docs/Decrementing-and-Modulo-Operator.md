# Decrementing and Modulo Operator

We saw `incrementing` earlier and now let's look at `De-crementing`  
Basically the same concept but now we use the `-` .

```cs
int num = 0;


Console.WriteLine($"Num is {num}");

// Inceremnting of int 
num ++ ;
Console.WriteLine($"Num is {num}");

// Increment before using the variable ( Pre-Incrementing)
Console.WriteLine("Num is {0}", ++num);

Console.WriteLine("Num is {0}", num++);
Console.WriteLine("Num is {0}", num);

// De-crementing
num-- ;
Console.WriteLine("Num is {0}, De-crementing", num);

// Pre De-crementing
Console.WriteLine("Num is {0} Pre De-crementing", --num);
Console.WriteLine("Num is {0}", num--);
Console.WriteLine("Num is {0}", num);


Console.ReadKey();
```

```console
Num is 0
Num is 1
Num is 2
Num is 2
Num is 3
Num is 2, De-crementing
Num is 1 Pre De-crementing
Num is 1
Num is 0
```

🔑 `Modulo` Operator ( `%` ) ↓  

```cs
int num1 = 10;
int num2 = 3;

int result = num1 % num2;
Console.WriteLine(result)
```

```console
1
```

- Devide and give us the `reminder` 