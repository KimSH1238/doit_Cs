// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("입력하고 싶은 항의 개수를 입력하시오 : ");
        int b = Convert.ToInt32(Console.ReadLine());
        if (b < 10 && b > 0)
        {
            int[] a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            foreach(var item in a.Take(b))
 // a.Take(b) 메서드를 잘 활용한 방안.
            {
                Console.Write(item);
            }
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("입력오류");
        }
    }
}