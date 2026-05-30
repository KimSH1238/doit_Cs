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
        coco.Name = "몰리";
// 또 하나는, 메인 클래스에서 선언한 인스턴스를 이용해, 직접 접근합니다.
        Console.WriteLine("고양이의 이름은 " + coco.Name + " 이다.");
// 무슨 차이가 있는지 잘 이해하지 못하였음.
    }
}