// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine ("Enter two numbers in separate lines:");

 int numberA = Convert.ToInt32(Console.ReadLine());
 int numberB = Convert.ToInt32(Console.ReadLine());
 
    if (numberA > numberB)
    {
 
        Console.WriteLine(numberA + " is larger than " + numberB);
 
    }
 
    else
 
    {
        if (numberA < numberB)
        Console.WriteLine(numberA + " is smaller than " + numberB);
        else 
        Console.WriteLine(numberA + " is equal to " + numberB);
    }
  