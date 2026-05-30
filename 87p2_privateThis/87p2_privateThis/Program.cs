// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
class Cat
{
    private string name = null;
    public void SetName(string name)
    {
        this.name = name;
    }
    public string GetName()
    {
        return this.name;
    }
}
class MainClass
{
    public static void Main(string[] args)
    {
        Cat coco = new Cat();
        coco.SetName("코코");
        Console.WriteLine("고양이의 이름은 "+coco.GetName()+" 이다.");
    }
}