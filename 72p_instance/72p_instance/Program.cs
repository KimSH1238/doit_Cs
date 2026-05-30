// See https://aka.ms/new-console-template for more information
using System;

class Person
{
    public string Name = null;
    public string Birthday = null;
    public string Gender = null;

    public void Eat()
    {
        Console.WriteLine(Name + "이 아침을 먹습니다.");
    }
    public void Walk()
    {
        Console.WriteLine(Name + "이 거리를 걷습니다.");
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        Person p1;
        p1 = new Person();
        p1.Name = "ksh";

        p1.Eat();
        p1.Walk();

        Console.WriteLine("\nHello, World!\n");
    }
}