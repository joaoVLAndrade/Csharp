using System;

namespace caLAB1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vetor2D V1 = new Vetor2D();
            Vetor2D V2 = new Vetor2D();
            Console.WriteLine("Digite a coordenada x do v1: ");
            V1.setX(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Digite a coordenada y do v1: ");
            V1.setY(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Digite a coordenada x do v2: ");
            V2.setX(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Digite a coordenada y do v2: ");
            V2.setY(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Vetor 1: (" + V1.getX() + "," + V1.getY() + ")");
            Console.WriteLine("Vetor 2: (" + V2.getX() + "," + V2.getY() + ")");
            V1.produtoInterno(V1, V2);
            V1.modulo(V1, V2);
            V1.angulo();
            V1.projecao(V1,V2);
        }
    }
}
