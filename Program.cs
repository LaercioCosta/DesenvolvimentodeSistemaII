using System;

namespace Calculadora_Ponderada
{
class Program
    {
        static void Main(string[] args)
        {
            double nota, 
                peso, 
                pesoTotal=0,
                notaPeso, total=0, 
                mediaPonderada ; 

            int quantidadeNotas = 1;
            
            

            while(quantidadeNotas <= 3)
            {
                Console.WriteLine("Coloque a nota {0} do aluno: ",quantidadeNotas);
                nota = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Coloque digite o peso da nota: ");
                peso = Convert.ToDouble(Console.ReadLine());
                
                notaPeso = peso * nota;

                total = total + notaPeso;

                pesoTotal =  pesoTotal + peso;
                 
                quantidadeNotas = quantidadeNotas + 1;
                
            }

            mediaPonderada = total / pesoTotal;

            Console.WriteLine("A media ponderada do aluno foi: {0}", mediaPonderada);
        }
    }
}
