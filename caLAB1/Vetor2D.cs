using System;
using System.Collections.Generic;
using System.Text;

namespace caLAB1
{
    class Vetor2D
    {
        //Atributos
        private double mod1, mod2, escalar, ang;
        private double x;
        private double y;
        //Construtor
        public Vetor2D()
        {
            x = 0.0;
            y = 0.0;
        }
        public void setX(double novoX)
        {
            x = novoX;
        }
        public void setY(double novoY)
        {
            y = novoY;
        }
        public double getX()
        {
            return x;
        }
        public double getY()
        {
            return y;
        }
        public void produtoInterno(Vetor2D v1,Vetor2D v2)
        {
            //Produto interno entre vetores --> <u,v> = x1*x2+y1*y2
            escalar = v1.getX() * v2.getX() + v1.getY() * v2.getY();
            Console.WriteLine("O produto escalar entre V1 e V2 é: " + escalar);
        }
        public void modulo(Vetor2D v1,Vetor2D v2)
        {
            //Módulo de um vetor = (x² + y²)^(1/2)
            mod1 = Math.Sqrt((Math.Pow(v1.getX(), 2) + Math.Pow(v1.getY(), 2)));
            mod2 = Math.Sqrt((Math.Pow(v2.getX(), 2) + Math.Pow(v2.getY(), 2)));
            Console.WriteLine("O módulo do V1 é: " + mod1 + " e o módulo do V2 é: " + mod2);
        }
        public void angulo()
        {
            //Angulo entre os dois vetores ---> (<u.v>/||u||*||v||)
            ang = (Math.Acos(escalar/(mod1*mod2)));
            Console.WriteLine("O angulo entre os vetores é: " + ang * 180 / Math.PI + " graus");
        }
        public void projecao(Vetor2D v1, Vetor2D v2)
        {       
            //projeção de v1 em v2
            double X1 = (escalar / (mod2*mod2)) * v2.getX();
            double Y1 = (escalar / (mod2*mod2)) * v2.getY();
            //projeção de v2 em v1
            double X2 = (escalar / (mod1 * mod1)) * v1.getX();
            double Y2 = (escalar / (mod1 * mod1)) * v1.getY();
            Console.WriteLine("O vetor resultante da projeção de V1 em V2 é: (" + X1 + "," + Y1 + ")");
            Console.WriteLine("O vetor resultante da projeção de V2 em V1 é: (" + X2 + "," + Y2 + ")");
        }
    }
}
