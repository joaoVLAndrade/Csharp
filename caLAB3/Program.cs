using System;

namespace caLAB3
{
    class Program
    {
        static void Main(string[] args)
        {
            Vetor3D V1 = new Vetor3D();
            Vetor3D V2 = new Vetor3D();
            V1.preencher();
            V2.preencher();
            Console.Write("Vetor1: ");
            V1.mostrar();
            Console.Write(" Vetor2: ");
            V2.mostrar();
            Console.WriteLine(" ");
            Vetor3D V3 = V1.Produtovet(V2);
            Console.WriteLine("O módulo do vetor 1 é: " + V1.Modulo());
            Console.WriteLine("O módulo do vetor 2 é: " + V2.Modulo());
            Console.Write("O produto vetorial entre o vetor 1 e vetor o 2 é: ");
            V3.mostrar();
        }
    }
}
