// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
class Cat
{
    public string Name = null;
    public Cat(string name)
    {
        Name = name;
        Console.WriteLine("고양이의 이름은 " + Name + " 이다.");
    }
}
class MainClass
{
    public static void Main(string[] args)
    {
        Cat coco = new Cat("코코");
// 1번 항 검토
        coco.Name = "몰리";
// 2번 항 검토 --> 1번 항 coco에 몰리를 대입.
        Console.WriteLine("고양이의 이름은 " + coco.Name + " 이다.");
    }
}