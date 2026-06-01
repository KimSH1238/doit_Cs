// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.ComponentModel.Design;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("원하는 배열 해당 개수를 입력하시오 : ");
        int b = Convert.ToInt32(Console.ReadLine());
        if (b <= 10 && b > 0)
        {
            int[] a = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int count = 0;
 // 여기서부터 foreach 문을 넣어본다.
            foreach (var item in a)
            {
                if(count>=b)
                {
                    break;
                }
                Console.Write(item);
                count++;
            }
            Console.WriteLine("");
        }
        else
        {
            Console.WriteLine("입력 오류");
        }
    }
}
