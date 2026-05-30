// See https://aka.ms/new-console-template for more information

using System;

class Cat
{
    public string Name = null;
    
    // 생성자 : 고양이가 만들어질때 이름을 지정한다.
    public Cat(string name)
    {
        Name = name;
        Console.WriteLine("고양이의 이름은 " + name + " 이다.");
    }
}

class Mainclass
{
    public static void Main(string[] args)
    {
        Console.Write("첫번째 고양이의 이름을 지정하시오 :\n");
        string firstName = Console.ReadLine();
        Cat cat1 = new Cat(first[pppppppppppName);

        // 줄바꿈을 위한 빈, 한줄 출력
        Console.WriteLine();

        Console.Write("두번째 고양이의 이름을 지정하시오 :\n");
        string secondName = Console.ReadLine();
        Cat cat2 = new Cat(secondName);

        Console.WriteLine("\nHello World\n");
    }
}
