// See https://aka.ms/new-console-template for more information
using System;

class Cat
{
    public string Name = null;
    public int Weight = 0;

    public Cat(string name)
    {
        Name = name;
        Console.WriteLine("고양이의 이름은 :\n" + Name + "입니다.");

        Console.WriteLine("\nHello, World!\n");
    }
    public Cat(string name, int weight)
    {
        Name = name;
        Weight = weight;
        Console.WriteLine("고양이의 이름은 :n" + Name + "이며,\n체중은 :" + Weight + "입니다.");

        Console.WriteLine("\nHello, World!\n");
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        Cat coco = new Cat("코코");
        Cat moly = new Cat("몰리", 3);
    }
}
