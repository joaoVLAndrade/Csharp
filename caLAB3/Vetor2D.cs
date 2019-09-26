using System;
using System.Collections.Generic;
using System.Text;

namespace caLAB3
{
    class Vetor2D
    {
        //Atributos
        protected double x; 
        protected double y;
        //Construtor
        public Vetor2D()
        {
            x = 0.0;
            y = 0.0;
        }
        public Vetor2D(double x , double y)
        {
            this.x = x;
            this.y = y;
        }
        public void setX(double novoX)
        {
            this.x = novoX;
        }
        public void setY(double novoY)
        {
            this.y = novoY;
        }
        public double getX()
        {
            return x;
        }
        public double getY()
        {
            return y;
        }
    }
}
