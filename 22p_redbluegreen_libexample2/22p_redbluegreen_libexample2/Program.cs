// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("red, green, blue 중 하나를 1,2,3 중 하나로 입력하시오 : ");
        string input = Console.ReadLine();
        convert(ref input);
        Console.WriteLine(input);
    }
    static void convert(ref string color)
    // 이 부분이 검토가 필요한 부분
    {
        if (color == "1")
            color = "빨강";
        else if (color == "2")
            color = "파랑";
        else if (color == "3")
            color = "초록";
        else
            color = "입력값이 잘못되었다.";
    }
}