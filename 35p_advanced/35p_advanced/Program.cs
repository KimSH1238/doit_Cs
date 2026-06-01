// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Linq;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("몇번 실행할지 결정하시오 : (번)");
        int maxNum = Convert.ToInt32(Console.ReadLine());
        if (maxNum < 0)
        {
            Console.WriteLine("입력 오류");
            return;
        }

        var heavyQuery = Enumerable.Range(0, maxNum + 1).Where(c =>
        {
            Task.Delay(450).Wait();
            return true;
        });
        var start = DateTime.Now;

        foreach (var item in heavyQuery)
        {
            Console.Write(item + "");
        }
        Console.WriteLine("\n소요시간 : {0}", DateTime.Now - start);
    }
}