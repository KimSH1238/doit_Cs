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
    ~Cat()
    {
        Console.WriteLine(Name + "가 사라집니다.");
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
 // 블록을 만들어, 고양이 속성들의 수명을 제한합니다. --> 실행 오류
 // 블록을 만들어, 고양이 속성들의 수명을 제한합니다. --> 실행 오류
        {
            Cat coco = new Cat("코코");
            Cat moly = new Cat("몰리");
        }
    }
//        GC.Collect();
//        GC.WaitForPendingFinalizers();
}