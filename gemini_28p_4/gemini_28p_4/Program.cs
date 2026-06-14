// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Drawing;
class Program
{
    static void convert(ref string color)
    {
        switch (color)
        {
            // color 의 변수를 s에 임시로 담고, when 뒤의 조건을 검사하는 코딩
            case string s when string.Equals(s, "Red", StringComparison.OrdinalIgnoreCase):
                color = "빨강";
                break;
            case string s when string.Equals(s, "Blue", StringComparison.OrdinalIgnoreCase):
                color = "파랑";
                break;
            case string s when string.Equals(s, "Green", StringComparison.OrdinalIgnoreCase):
                color = "초록";
                break;
            default:
                color = "알 수 없는 색";
                break;
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Red, Green, Blue 중 하나를 입력하시오 : ");
        string s = Console.ReadLine() ?? " ";
        convert(ref s);

            Console.WriteLine($"변환된 결과 : {s}");
    }
}