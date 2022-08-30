//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine ("Enter three numbers in separate lines:");

int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = Convert.ToInt32(Console.ReadLine());
int numberC = Convert.ToInt32(Console.ReadLine());
 
int maximal = Math.Max(Math.Max(numberA, numberB), numberC);
int minimal = Math.Min(Math.Min(numberA, numberB), numberC);
 
Console.WriteLine("{0} < {1} < {2}",
minimal,
numberA + numberB + numberC - maximal - minimal,
maximal);