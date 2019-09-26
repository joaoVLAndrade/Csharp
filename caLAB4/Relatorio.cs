using System;
using System.Collections.Generic;
using System.Text;

namespace caLAB4
{
    class Relatorio
    {
        //Atributos
        private double salarioSE,salarioENF,salarioENM,salarioENS;
        //Construtores
        public Relatorio()
        {
            salarioSE  = 0.0;
            salarioENF = 0.0;
            salarioENM = 0.0;
            salarioENS = 0.0;
        }
        public double getSalarioSE()
        {
            return salarioSE;
        }
        public double getSalarioENF()
        {
            return salarioENF;
        }
        public double getSalarioENM()
        {
            return salarioENM;
        }
        public double getSalarioENS()
        {
            return salarioENS;
        }
        public void setSalarioSE(double _salarioSE)
        {
            salarioSE = _salarioSE;
        }
        public void setSalarioENF(double _salarioENF)
        {
            salarioENF = _salarioENF;
        }
        public void setSalarioENM(double _salarioENM)
        {
            salarioENM = _salarioENM;
        }
        public void setSalarioENS(double _salarioENS)
        {
            salarioENS = _salarioENS;
        }
        public void imprimir()
        {
            Console.WriteLine("\nRelatório de custos\n");
            Console.WriteLine("Gastos totais funcionarios sem grau de escolaridade:R$" + this.salarioSE);
            Console.WriteLine("Gastos totais funcionarios com ensino básico:R$" + this.salarioENF);
            Console.WriteLine("Gastos totais funcionarios com ensino médio:R$" + this.salarioENM);
            Console.WriteLine("Gastos totais funcionarios com ensino súperior:R$" + this.salarioENS);
        }
    }
}
