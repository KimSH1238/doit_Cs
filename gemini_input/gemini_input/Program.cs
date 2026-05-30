// See https://aka.ms/new-console-template for more information
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("이름을 입력하시오 :");
        //사용자가 입력한 문자열을 변수에 저장
        string input = Console.ReadLine();

        Console.WriteLine($"입력값을 전달받았습니다. {input}님");
        Console.WriteLine("\nHello, World!\n");
    }
}
,