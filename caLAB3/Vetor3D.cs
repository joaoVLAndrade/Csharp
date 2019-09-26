using System;
using System.Collections.Generic;
using System.Text;

namespace caLAB3
{
    class Vetor3D : Vetor2D
    {
        //Atributos
        public double z;
        //Construtores
        public Vetor3D() : base()
        {
            this.z = 0;
        }
        public Vetor3D(double x, double y, double z) : base(  x,  y)
        {
            this.z = z;
        }

        public double getZ()
        {
            return z;
        }
        public void setZ(double novoZ)
        {
            z = novoZ;
        }
        public void preencher()
        {
            Console.WriteLine("Digite a coordenada x do vetor: ");
            this.x = (Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Digite a coordenada y do vetor: ");
            this.y =(Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Digite a coordenada z do vetor: ");
            this.z = (Convert.ToDouble(Console.ReadLine()));
            Console.Clear();
        }
        public  double Modulo()
        {
            double mod;
            mod = Math.Sqrt(Math.Pow(this.x, 2) + Math.Pow(this.y, 2) + Math.Pow(this.z, 2));
            return mod;
        }
        public Vetor3D Produtovet( Vetor3D v2)
        {
            Vetor3D v3 = new Vetor3D();
            v3.setX(this.getY() * v2.getZ() - this.getZ() * v2.getY());
            v3.setY(this.getZ() * v2.getX() - this.getX() * v2.getZ());
            v3.setZ(this.getX() * v2.getY() - this.getY() * v2.getX());
            return v3;
        }
        public void mostrar()
        {
            Console.Write("(" + getX() + "," + getY() + "," + getZ() +")");
        }
    }
}
