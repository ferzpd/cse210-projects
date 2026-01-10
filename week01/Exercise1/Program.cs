using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What si your first name? ");
        string first = Console.ReadLine();

        Console.Write("what is yout last name? ");
        string last = Console.ReadLine();

        Console.writeLine($"Your name is {last}, {first} {last}.");
    }
}