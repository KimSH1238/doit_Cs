// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
class Program
{
    private static void sample(int a)
    {
        bool first = true;
        while (a >= 0 || first)
        {
            Console.Write(a--);
            first = false;
        }
    }
    static void Main(string[] args)
    {
        sample(10);
        sample(-1);
        Console.WriteLine();
    }
}