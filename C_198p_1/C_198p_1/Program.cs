// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("두 개의 정수를 입력하시오 : ");
 // 한 줄을 입력받아 공백으로 나누는 코딩
        string[] inputs = Console.ReadLine().Split(" ");

        int a = int.Parse(inputs[0]);
        int b = int.Parse(inputs[1]);

        int c = a / b;
        int d = a % b;
        Console.WriteLine($"몫 : {c}, 나머지 : {d}");
    }
}