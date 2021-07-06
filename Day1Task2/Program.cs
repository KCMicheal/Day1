using System;
public class Day1Task2
{
    public static void Main()
    {
        int num, rem;
        Console.Write("\n\n");
        Console.Write("Check whether a number is even or odd :\n");
        Console.Write("---------------------------------------");
        Console.Write("\n\n");
        Console.Write("Input an integer : ");
        num = Convert.ToInt32(Console.ReadLine());
        rem = num % 2;
        if (rem == 0)
            Console.WriteLine("\n{0} is an even integer.\n", num);
        else
            Console.WriteLine("\n{0} is an odd integer.\n", num);
    }
}