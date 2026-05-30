// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
class Robot
{
    public void Move()
    {
        Console.WriteLine("로봇이 움직입니다.");
    }
}
class CleanRobot : Robot
{
    public void Clean()
    {
        Console.WriteLine("청소를 시작합니다.");
    }
}
class MainClass
{
    public static void Main(string[] args)
    {
        CleanRobot cleanRobot = new CleanRobot();
        cleanRobot.Move();
 // CleanRobot 을 호출했는데, 상속으로 Robot 까지 호출된 모습
        cleanRobot.Clean();
    }
}