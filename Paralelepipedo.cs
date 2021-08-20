using System;
namespace Atividade02__13_08_21
{
    public class Paralelepipedo
    {
        public double Comprimento, Largura, Altura, Volume;

        public Paralelepipedo(double comprimento, double largura, double altura)
        {
            this.Comprimento = comprimento;
            this.Largura = largura;
            this.Altura = altura;
        }
        public Paralelepipedo(){ }

        public double Vol()
        {
            return Volume = Comprimento * Largura * Altura;
        }
    }
}