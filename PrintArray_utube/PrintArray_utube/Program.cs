// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

namespace PrintingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n = new int[30];
            for (int i=0; i<n.Length; i++)
            {
                n[i] = i + 1;
            }
            Printarray(n);
        }
        static void Printarray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
        }
    }
}