// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
// C# 으로도 동일한 프로그램을 순서대로 반복해본다.

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("(윤년 계산 프로그램) 연도를 입력하시오 : ");
 // 입력받은 문자열을 정수로 변환
        int year = int.Parse(Console.ReadLine());

        bool result = ((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0);
        string resultC;

        if (result == true)
        {
            resultC = "True";
        }
        else
        {
            resultC = "False";
        }
 // $문자열을 사용하여 가독성있게 출력하는 방법
        Console.WriteLine($"result = {resultC}");
 // int.TryParse 구문은 별도의 연습이 필요한 부분
    }
}