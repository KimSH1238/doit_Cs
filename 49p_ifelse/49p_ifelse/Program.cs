// See https://aka.ms/new-console-template for more information
using System;
using System.ComponentModel.Design;

class Mainclass
{
    public static void Main(string[] args)
    {
        int num = 0;
        if (num > 0)
            Console.WriteLine("positive");
        else if (num < 0) 
            Console.WriteLine("negative");
// IExtenderListService
        else
            Console.WriteLine("zero");
    }
}
