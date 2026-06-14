// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
class Program
{
    static void convert(ref string color)
    {
        switch (color)
        {
            case "Red": color = "빨강";
                break;
            case "Green": color = "초록";
                break;
            case "Blue": color = "파랑";
                break;
            default: color = "알 수 없는 색";
                break;
        }
    }
    static void Main(string[] args)
    {
        string s = "Red";
 // 원래 여기서 입력을 받아야 하는 부분
        convert(ref s);
        Console.WriteLine(s);
    }
}