// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// 더 단순한 방법으로 리드라인을 받는게 목적.
using System;
using System.Runtime.InteropServices;
class Program
{
    static void Main()
    {
        const double SIGMA = 5.67e-8;
        double emi = 0.9;

        Console.WriteLine("셀시우스 섭씨 온도를 입력하시오 : ");
        double celsius1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("반대편 셀시우스 섭씨 온도를 입력하시오 : ");
        double celsius2 = Convert.ToDouble(Console.ReadLine());

        double kelvin1 = celsius1 + 273.15;
        double kelvin2 = celsius2 + 273.14;

        double net = SIGMA * emi * (Math.Pow(kelvin1, 4) - Math.Pow(kelvin2, 4));
        Console.WriteLine($"정미 전열량은 {net:F2}W/m^2 입니다.");
    }
}