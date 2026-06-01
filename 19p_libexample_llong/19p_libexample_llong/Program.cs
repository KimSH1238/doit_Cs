// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Action<TextWriter>> dic = new Dictionary<string, Action<TextWriter>>();
        // 현재 줄이 var을 사용하던 코드
        dic.Add("sample1", (writer) => { writer.WriteLine("I'm sample1!"); });
        dic.Add("sample2", (writer) => { writer.WriteLine("I'm sample2!"); });
        foreach (var item in dic.Values)
        {
            item(Console.Out);
        }
    }
}