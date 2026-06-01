// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// 복사전열량을 계산하기 위한 프로그램
using System;
class Program
{
    static void Main()
    {
        const double SIGMA = 5.67e-8;
        double emi = 0.9;
// 1번 온도 입력받기
        Console.WriteLine("셀시우스 섭씨 온도를 입력하시오 : ");
        if (!double.TryParse(Console.ReadLine(), out double celsius1))
        {
            Console.WriteLine("입력값 오류");
        }
 // 2번 온도 입력받기
        Console.WriteLine("반대편 셀시우스 섭씨 온도를 입력하시오 : ");
        if (!double.TryParse(Console.ReadLine(), out double celsius2))
        {
            Console.WriteLine("입력값 오류");
        }
        double kelvin1 = celsius1 + 273.15;
        double kelvin2 = celsius2 + 273.15;

        double net = SIGMA * emi * (Math.Pow(kelvin1, 4) - Math.Pow(kelvin2, 4));
        // 결과 출력
        Console.WriteLine($"정미 전열량은 {net:F2}W/m^2 이다.");
    }
}