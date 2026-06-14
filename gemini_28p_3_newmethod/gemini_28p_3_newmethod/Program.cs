// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
class Program
{
    static void convert(ref string color)
    {
        switch(color.ToLower())
        {
            case "red":
                color = "빨강";
                break;
            case "blue":
                color = "파랑";
                break;
            case "green":
                color = "초록";
                break;
            default:
                color = "알 수 없는 색";
                break;
        }
    }
// 입력된 문자열을 소문자로 바꿔서 넣음으로서 해결   
    static void Main(string[] args)
    {
        Console.WriteLine("Red, Blue, Green 중 하나를 입력하시오 : ");
// 사용자가 엔터만 누를 경우를 대비해, 널값 허용 및 초기값 지정이 필요하다.        
        string s = Console.ReadLine() ?? " ";
        convert(ref s);

        Console.WriteLine($"변환된 결과 : {s}");
    }
}