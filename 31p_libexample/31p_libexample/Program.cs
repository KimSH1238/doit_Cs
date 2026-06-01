// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// gemini 를 따라가지 않고, 책의 코딩만 따라가 본다.
using System;
using System.Linq;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        var heavyQuery = Enumerable.Range(0, 10).Where(c =>
        {
            Task.Delay(1000).Wait();
            return true;
        });

        var start = DateTime.Now;
        for (int i = 0; i < heavyQuery.Count(); i++)
        {
            Console.WriteLine(heavyQuery.ElementAt(i));
        }
        Console.WriteLine("소요시간 :{0}", DateTime.Now - start);
    }
}