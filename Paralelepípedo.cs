using System;
namespace Atividade02__13_08_21
{
    public class Paralelepípedo
    {
        public double Comprimento, Largura, Altura, Volume;

        public Paralelepípedo(double comprimento, double largura, double altura)
        {
            this.Comprimento = comprimento;
            this.Largura = largura;
            this.Altura = altura;
        }
        public Paralelepípedo(){ }

        public double Vol()
        {
            return Volume = Comprimento * Largura * Altura;
        }
    }
}