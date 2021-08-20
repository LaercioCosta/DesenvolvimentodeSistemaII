using System;

namespace Atividade02__13_08_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Paralelepipedo p1 = new Paralelepipedo();

            Console.WriteLine("Volume do Paralelepípedo");

            Console.WriteLine("Digite o comprimento do Paralelepípedo:");
            p1.Comprimento = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a largura do Paralelepípedo:");           
            p1.Largura = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Digite a altura do Paralelepípedo:");
            p1.Altura = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine($"O volume do Paralelepípedo é: {p1.Vol()} cm");
             
        }
    }
}
