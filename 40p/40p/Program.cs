// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
class Program
{
    static void Main(string[] args)
    {
        int a = 1;
        while (a==1)
        {
            int b = a * 2;
            if (b > 0)
                break;
            Console.WriteLine(b);
            break;
        }
        Console.WriteLine("All done");
    }
}