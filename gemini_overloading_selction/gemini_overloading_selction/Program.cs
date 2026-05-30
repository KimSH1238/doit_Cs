// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;

class Cat
{
    public string Name = null;
    public int Weight = 0;

    // 1. 생성자 1 --> 이름만 받는 생성자.
    public Cat(string name)
    {
        Name = name;
        Console.WriteLine($"[이름 전용 생성자] 고양이 {Name}이 등록되었습니다.");
    }

    // 2. 생성자 2. --> 이름과 체중을 같이 받는 생성자.
    public Cat(string name, int weight)
    {
        Name = name;
        Weight = weight;
        Console.WriteLine($"[이름+체중 생성자] 고양이 {Name},({Weight}kg) 이 등록되었습니다.");
    }
}

class MainClass
{
    public static void Main(string[] args)
    {
        Console.WriteLine("--- 고양이 등록 시스템 ---");

        // 1. 이름은 필수 입력
        Console.Write("고양이 이름을 입력하시오 :");
        string name = Console.ReadLine();
        // 2. 체중은 선택 입력관계
        Console.Write("고양이 체중을 입력하되, 모르면 엔터 입력 :");
        string weightInput = Console.ReadLine();
        // 일단 string으로 입력을 받는다.

        if (weightInput=="")
        {
            Cat myCat = new Cat(name);
            // 사용자가 엔터만 쳤을때, 이름만 넣어서 객체 생성
        }
        else
        {
            int weight = Convert.ToInt32(weightInput);
            Cat myCat = new Cat(name, weight);
        }
    }
}