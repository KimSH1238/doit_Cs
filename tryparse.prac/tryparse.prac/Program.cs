// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("(윤년 계산 프로그램 중 TryParse), 연도를 입력하시오 : ");
        string input = Console.ReadLine();

        if (int.TryParse(input, out int year)) 
        {
            // 변환 성공, 기존의 로직을 사용하면 된다.
            bool result = ((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0);
            Console.WriteLine($"result = {result}");
        }
        else
        {
            Console.WriteLine("입력 오류"); 
        }
    }
}