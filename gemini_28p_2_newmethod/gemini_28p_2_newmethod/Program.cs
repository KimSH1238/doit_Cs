// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Security.Cryptography.X509Certificates;
class Program
{
    static void convert(ref string color)
    {
        // switch 를 변수 우측에 두고, 조건에 따라 값을 바로 대입한다.
        color = color switch
        {
            // 람다식 => 과 String.Equals 를 조합하여, 대소문자를 무시한다.
            string s when string.Equals(s, "Red", StringComparison.OrdinalIgnoreCase) => "빨강",
            string s when string.Equals(s, "Blue", StringComparison.OrdinalIgnoreCase) => "파랑",
            string s when string.Equals(s, "Green", StringComparison.OrdinalIgnoreCase) => "초록",
            _ => "알 수 없는 색"
        };
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Red, Blue, Green 중 하나를 입력하시오 : ");
 // 사용자가 아무것도 누르지 않을 경우를 대비해, 널 허용 및 초기값 지정 방법
        string s = Console.ReadLine() ?? " ";
        convert(ref s);

        Console.WriteLine($"변환된 결과 : {s}");
    }
}