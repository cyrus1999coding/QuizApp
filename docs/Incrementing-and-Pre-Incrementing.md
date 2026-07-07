# Incrementing and Pre-Incrementing

we're going to see some more operators

```cs
int num = 0;


Console.WriteLine($"Num is{num}");
// Inceremnting of int 
num ++ ;
Console.WriteLine($"Num is{num}");


Console.ReadKey();
```

```console
Num is 0
Num is 1
```

🔑 It does matter if we're incrementing before or after the variable name 

```cs
int num = 0;


Console.WriteLine($"Num is {num}");

// Inceremnting of int 
num ++ ;
Console.WriteLine($"Num is {num}");

// Increment before using the variable
Console.WriteLine("Num is {0}", ++num); 👈


Console.ReadKey();
```

```console
Num is 0
Num is 1
Num is 2 👈
```

```cs
int num = 0;


Console.WriteLine($"Num is {num}");

// Inceremnting of int 
num ++ ;
Console.WriteLine($"Num is {num}");

// Increment before using the variable
Console.WriteLine("Num is {0}", ++num);
Console.WriteLine("Num is {0}", num++);


Console.ReadKey();
```

```console
Num is 0
Num is 1
Num is 2 👈
Num is 2 👈
```

```cs
int num = 0;


Console.WriteLine($"Num is {num}");

// Inceremnting of int 
num ++ ;
Console.WriteLine($"Num is {num}");

// Increment before using the variable
Console.WriteLine("Num is {0}", ++num); 👈
Console.WriteLine("Num is {0}", num++); 👈
Console.WriteLine("Num is {0}", num); 👈


Console.ReadKey();
```


```console
Num is 0
Num is 1
Num is 2 👈
Num is 2 👈
Num is 3 👈
```

- `++num` :  
  Called `Pre-Incrementing`

🔑 Same thing works for De-crementing
  