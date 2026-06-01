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
            Task.Delay(300).Wait();
 // 실제 업무에서는 무거운 처리를 하고 있다.
            return true;
        });
        var start = DateTime.Now;
        var enumerator = heavyQuery.GetEnumerator();
        for(; enumerator.MoveNext(); )
 // 좌 우를 빼고, 가운데 만으로 for문을 구성할 수 있다.
        {
            Console.Write(enumerator.Current);
        }
        Console.WriteLine("\n소요시간 : {0}", DateTime.Now - start);
    }
}