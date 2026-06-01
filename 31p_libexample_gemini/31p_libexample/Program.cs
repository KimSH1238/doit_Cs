// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var heavyQuery = Enumerable.Range(0, 10).Where(c =>{
 // 람다 화살표 암기할것
            Task.Delay(1000).Wait();
 // 실제 업무에서는 무거운 처리를 하고 있을것
            return true;
        } ).ToList();

        var start = DateTime.Now;
        for (int i = 0; i < heavyQuery.Count; i++)
        {
            Console.WriteLine(heavyQuery[i].ToString());
        }
        Console.WriteLine("소요시간 :{0}", DateTime.Now - start);
    }
}