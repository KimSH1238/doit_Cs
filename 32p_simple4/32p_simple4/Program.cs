// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("원하는 배열 해당 개수를 입력하시오 : ");
        int b = Convert.ToInt32(Console.ReadLine());
// 오류항을 미리 받는 구조로 짜는 방법. (4방법)
        if (!(b >= 1 && b <= 10))
        {
            Console.WriteLine("입력 오류");
            return;
// 메서드를 여기서 직접 종료합니다.
        }
// 여기서는 오류항에 해당하지 않는 부분을 직접 쳐주는 로직
        int[] a = { 00, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int count = 0;

        foreach (var item in a)
        {
            if(count>=b)
            {
                break;
            }
            else
            {
                Console.Write(item);
                count++;
            }
        }
        Console.WriteLine("");
    }
}