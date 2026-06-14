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
            Console.WriteLine(a--);
            first = false;
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("시작할 정수를 입력하시오 : ");
        int inputNumber = Convert.ToInt32(Console.ReadLine());

        sample(inputNumber);
        sample(-1);
        Console.WriteLine();
    }
}