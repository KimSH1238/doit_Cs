// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("빨강은 1, 파랑은 2, 초록은 3을 입력하시오 : ");
        // 제일 중요한 부분 : 사용자의 입력을 문자열로 받기 (정수형 변수로 받을 필요가 없음)
        string input = Console.ReadLine();
        switch (input)
        {
            case "1":
                Console.WriteLine("빨강");
                break;
            case "2":
                Console.WriteLine("파랑");
                break;
            case "3":
                Console.WriteLine("초록");
                break;
            default:
                Console.WriteLine("입력값이 잘못되었다.");
                break;
        }
    }
}