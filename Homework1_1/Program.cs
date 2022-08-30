// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
{
int numberA, numberB;

Console.WriteLine ("Enter two numbers in separate lines:");

 numberA = Convert.ToInt32(Console.ReadLine());
 
        numberB = Convert.ToInt32(Console.ReadLine());
 
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
  
     Console.ReadLine();
 
    }