// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Linq;
using System.Threading.Tasks;
class Program
{
    static void Main(string[] args)
    {
        var heavyQuery = Enumerable.Range(0, 10).Where(c =>
        {
            Task.Delay(400).Wait();
            // 실제 업무에서는 무거운 처리를 하고 있다.
            return true;
        });

        var start = DateTime.Now;
        foreach(var item in heavyQuery)
        {
            Console.Write(item);
        }
        Console.WriteLine("\n소요시간 : {0}", DateTime.Now - start);
// 해당 코딩을 실제로 range 값을 입력받아서 바꾸는 거로 변경할 필요가 있다.
    }
}