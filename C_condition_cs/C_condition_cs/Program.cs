// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("두 수를 차례대로 입력하시오 : (한 줄에 공백으로 구분)");
// 한 줄에 공백으로 구분을 하는 코딩이 따로 있다.
        string[] inputs = Console.ReadLine().Split(' ');
// 메서드를 대문자로 시작하는 것을 잊으면 안된다.
        int x = int.Parse(inputs[0]);
        int y = int.Parse(inputs[1]);

        if (x > y)
        {
            Console.WriteLine($"큰 수 : {x}, 작은 수 : {y}\n");
        }
        else
        {
            Console.WriteLine($"큰 수 : {y}, 작은 수 : {x}\n");
        }
    } 
}