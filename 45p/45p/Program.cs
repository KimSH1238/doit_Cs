// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
class Program
{
    private static void sample(int a)
    {
        while (a >= 0)
        {
            Console.Write(a--);
        }
    }
    static void Main(string[] args)
    {
        sample(10);
        sample(-1);
        Console.WriteLine();
    }
}