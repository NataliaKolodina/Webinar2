// Напишите программу, которая выводит на экран числа от 1 до 100. 
// При этом вместо чисел, кратных трем, программа должна выводить слово «Fizz», 
// а вместо чисел, кратных пяти — слово «Buzz». 
// Если число кратно и 3, и 5, то программа должна выводить слово «FizzBuzz».

Console.Clear();

int count = 1;
while (count <= 100)
{
    if ((count % 3 == 0) & (count % 5 == 0))
    {
        Console.BackgroundColor = ConsoleColor.Blue;
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("FizzBuzz");
    }
    else if (count % 3 == 0)
    {
        Console.BackgroundColor = ConsoleColor.Red;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("Fizz");
    }
    else if (count % 5 == 0)
    {
        Console.BackgroundColor = ConsoleColor.Green;
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("Buzz");
    }
    else
    {
        Console.Write(count);
    }
    Console.ResetColor();
    if (count == 100)
    {
        Console.Write(".");
    }
    else
    {
        Console.Write(", ");
    }
    count++;
}