// See https://aka.ms/new-console-template for more information
using System.Diagnostics.Contracts;

using System;

class Cat
{
    public string Name = null;

    public Cat(string name)
    {
        Name = name;
        Console.WriteLine("고양이의 이름은 " + Name + "이다.");
    }
}

class MainClass
{ 
    public static void Main(string[] args)
    {
        Cat coco = new Cat("코코");
        Cat moly = new Cat("몰리");

        Console.WriteLine("\nHello, World!\n");
    }
}