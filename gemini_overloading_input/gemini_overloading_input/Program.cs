// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

class Cat
{
    public string Name = null;
    public int Weight = 0;

    // 생성자 1: 이름만 받는 생성자.
    public Cat(string name)
    {
        Name = name;
        Console.WriteLine($"고양이의 이름은 {Name} 입니다.");
    }

    // 생성자 2 : 이름과 체중을 같이 받는 생성자.
    public Cat(string name, int weight)
    {
        Name = name;
        Weight = weight;
        Console.WriteLine($"고양이의 이름은 {Name} 이며, 체중은 {Weight}kg 입니다.");
    }
}

// 메인클래스를 하나는 호출
class MainClass
{
    public static void Main(string[] args)
    {
        // 1. 첫번째 고양이
        Console.WriteLine("첫번째 고양이 등록");
        Console.WriteLine("고양이의 이름을 입력하시오 :");
        string name1 = Console.ReadLine();

        Console.WriteLine("---------------------");

        // 2. 두번째 고양이는 체중도 받아서 호출
        Console.WriteLine("두번째 고양이 등록");
        Console.WriteLine("고양이의 이름을 입력하시오 :");
        string name2 = Console.ReadLine();

        Console.Write("고양이 몸무게를 (숫자만) 입력하시오 :");
        // 주의 : Console,ReadLine 은 모든 입력을 string 으로 받는다.
        // 숫자로 바꾸기 위해서는, Convert.ToInt32() 을 사용해야 한다.

        int weight2 = Convert.ToInt32(Console.ReadLine());

        // 입력받은 이름과 몸무게로, 객체 생성
        // 그러하면, 생성자 2번이 알아서 실행됨.
        Cat moly = new Cat(name2, weight2);
    }
}