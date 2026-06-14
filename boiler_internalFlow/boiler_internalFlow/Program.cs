// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
using System.Runtime.InteropServices;
class BoilerConvectionProgram
{
    static void Main(string[] args)
    {
        Console.WriteLine("기준 유입온도 20도씨, 유출온도 80도씨");

        const double D = 0.05;
        const double T_s = 100;
        const double T_f = 50;
        // 50도 물의 물성치 데이터
        const double RHO = 988.1;
        const double MU = 5.47e-4;
        const double K = 6.44;
        const double Pr = 3.55;
        const double Cp = 4181;

        // 필요한 수치 입력받는 항
        Console.WriteLine("\n보일러 관의 길이를 m단위로 입력하시오 : ");
        double L = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("관 내 유속을 입력하시오 : ");
        double velo = Convert.ToDouble(Console.ReadLine());

        double Re = (RHO * velo * D / MU);
        if (Re < 4000)
        {
            Console.WriteLine("입력 물성치 오류");
        }
        else
        {
            double prTerm = Math.Pow(1.0 + Math.Pow(0.492 / Pr, 9.0 / 16.0), 4.0 / 9.0);
            double reTerm = 0.023 * Math.Pow(Re, 0.8) * Math.Pow(Pr, 0.4);
            // 점성 보정항 0.14제곱은 사용하지 않는다 
            double NuL = 0.023 * Math.Pow(2320.0, 0.8) * Math.Pow(Pr, 0.4);
            double Nu = Math.Pow(Math.Pow(NuL, 10.0) + Math.Pow(reTerm / prTerm, 10.0),1/10.0);
            double h = (Nu * K) / D;

            double surfaceArea = Math.PI * D * L;
            double net = h * surfaceArea * (T_s - T_f);
            Console.WriteLine($"Re 수는 {Re} 와 같다.");
            Console.WriteLine($"열전달량은 {net}W/m^2 과 같다.");
        }
    }
}