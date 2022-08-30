//  Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine ("Enter number :");

 int numberA = Convert.ToInt32(Console.ReadLine());

    if (numberA % 2==1) 

    {

        Console.WriteLine(numberA + " is an odd number"); 
    
    }

    else 

    {
        
        Console.WriteLine (numberA + " is an even number");

    }
