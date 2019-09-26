//Aluno : João Victor Luiz De Andrade -- 11811EAU003
using System;

namespace caLAB4
{
    class Program
    {
        static void Main(string[] args)
        {
            double salarioSE, salarioENF,salarioENM,salarioENS;
            Relatorio relatorio1 = new Relatorio();
            salarioSE = relatorio1.getSalarioSE();
            salarioENF = relatorio1.getSalarioENF();
            salarioENM = relatorio1.getSalarioENM();
            salarioENS = relatorio1.getSalarioENS();
            Funcionarios[] empresa = new Funcionarios[10];
            for(int i = 0; i < 10; i++)
            {
                if (i < 2)
                {
                    empresa[i] = new FuncionarioSE();
                    empresa[i].Preencher();
                    salarioSE += empresa[i].getRenda();
                    
                }
                else if (i >= 2 && i <= 5)
                {
                    empresa[i] = new FuncionarioENF();
                    empresa[i].Preencher();
                    empresa[i].BonusSalarial();
                    salarioENF += empresa[i].getRenda();
                }
                else if (i > 5 && i < 8)
                {
                    empresa[i] = new FuncionarioENM();
                    empresa[i].Preencher();
                    empresa[i].BonusSalarial();
                    salarioENM += empresa[i].getRenda();
                }
                else
                {
                    empresa[i] = new FuncionarioENS();
                    empresa[i].Preencher();
                    empresa[i].BonusSalarial();
                    salarioENS += empresa[i].getRenda();
                }
            }
            Console.Clear();
            for(int i = 0; i<10; i++)
            {
                empresa[i].Imprime();
            }
            relatorio1.setSalarioSE(salarioSE);
            relatorio1.setSalarioENF(salarioENF);
            relatorio1.setSalarioENM(salarioENM);
            relatorio1.setSalarioENS(salarioENS);
            relatorio1.imprimir();
        }
    }
}
