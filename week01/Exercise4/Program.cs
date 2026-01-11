using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int input = -1;

        Console.WriteLine("Enter a list of numbers type 0 when finished.");
        while (input != 0)
        {
            Console.Write("Enter numbeer: ");
            input = int.Parse(Console.ReadLine());
            if (input != 0)
            {
                numbers.Add(input);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        double average = (double)sum / numbers.Count;
        int max = int.MinValue;
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The sum iis: {sum}");
        Console.WriteLine($"the average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}
