// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("입력하고 싶은 항의 개수를 입력하시오 : ");
        int b = Convert.ToInt32(Console.ReadLine());
        if (b<10 && b>0)
        {
            int[] a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            for (int i = 0; i < b; i++)
            {
                Console.Write(a[i]);
            }
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("입력오류");
        }
    }
}