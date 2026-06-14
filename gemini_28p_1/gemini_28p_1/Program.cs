// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
class Program
{
    static void convert(ref string color)
    {
        if (string.Equals(color, "Red", StringComparison.OrdinalIgnoreCase))
            color = "빨강";
        else if (string.Equals(color, "Green", StringComparison.OrdinalIgnoreCase))
            color = "초록";
        else if (string.Equals(color, "Blue", StringComparison.OrdinalIgnoreCase))
            color = "파랑";
        else
            color = "알 수 없는 색";
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Red, Green, Blue 중 하나를 입력하시오 : ");
 // 사용자가 아무것도 입력하지 않고 엔터를 누를 경우를 대비해, 널 허용 처리나 기본값 지정을 해준다.
        string s = Console.ReadLine() ?? " ";
        convert(ref s);

        Console.WriteLine($"변환된 결과 : {s}");
    }
}