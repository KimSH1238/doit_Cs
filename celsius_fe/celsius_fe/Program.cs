// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("화씨 온도를 입력하시오 : ");
        // 입력받은 문자열을 double 실수형으로 변환
        double f_temp = double.Parse(Console.ReadLine());

        double c_temp = (f_temp - 32.0) * (5.0 / 9.0);

        Console.WriteLine($"섭씨 온도는 {c_temp:F2} 입니다.");
    }
}