/*Escreva uma classe para conter três atributos do tipo int chamados hora, min, seg e
chame-a de Tempo.
a) Crie um construtor que inicialize os dados com zero.
b) Crie um método(ou função membro da classe) para solicitar a hora, os minutos e os
segundos para o usuário, via teclado(investigue a classe ReadLine() do C#).
c) Crie os getters() e os setters().
d) Crie um método para imprimir a hora no formato hh:mm:ss.
e) Crie um método para adicionar dois objetos da classe Tempo, gerando um terceiro objeto
da classe Tempo.Este método deve conter apenas um objeto da classe Tempo que será
adicionado ao objeto que chama o referido método.
f) Crie um método para subtrair dois objetos da classe Tempo, gerando um terceiro objeto
da classe Tempo.Este método deve conter apenas um objeto da classe Tempo que será
adicionado ao objeto que chama o referido método.*/

using System;
using System.Collections.Generic;
using System.Text;

namespace caLAB2
{
    class Tempo
    {
        //Atributos
        private int hora, min, seg;
        //construtores
        public Tempo()
        {
            hora = 0;
            min = 0;
            seg = 0;
        }
        public Tempo(int h, int m, int s)
        {
            hora = h;
            min = m;
            seg = s;
        }
        //setters()
        public void setH(int newH)
        {
            hora = newH;
        }
        public void setM(int newM)
        {
            min = newM;
        }
        public void setS(int newS)
        {
            seg = newS;
        }
        //getters()
        public int getH()
        {
            return hora;
        }
        public int getM()
        {
            return min;
        }
        public int getS()
        {
            return seg;
        }
        public void NovoHorario()
        {
            bool flag;
            String aux;
            do
            {
                Console.WriteLine("Digite a hora desejada: ");
                flag = false;
                aux = Console.ReadLine();
                hora = 0;
                foreach (var c in aux)
                {
                    if(!Char.IsDigit(c))
                    {
                        flag = true;
                    }

                }
                if (flag)
                {
                    Console.WriteLine("Somente números são aceitos");
                }
                else
                {
                    hora = Convert.ToInt32(aux);
                    if (hora > 24 || hora < 0)
                    {
                        Console.WriteLine("Valor inválido");
                    }
                }
            } while (hora > 24 ||hora < 0);
            Console.Clear();
            do
            {
                Console.WriteLine("Digite os minutos desejados: ");
                flag = false;
                aux = Console.ReadLine();
                min = 0;
                foreach (var c in aux)
                {
                    if (!Char.IsDigit(c))
                    {
                        flag = true;
                    }

                }
                if (flag)
                {
                    Console.WriteLine("Somente números são aceitos");
                }
                else
                {
                    min = Convert.ToInt32(aux);
                    if (min > 60 || min < 0)
                    {
                        Console.WriteLine("Valor inválido");
                    }
                }
            } while (min > 60 || min < 0);
            Console.Clear();
            do
            {
                Console.WriteLine("Digite os segundos desejados: ");
                flag = false;
                aux = Console.ReadLine();
                seg = 0;
                foreach (var c in aux)
                {
                    if (!Char.IsDigit(c))
                    {
                        flag = true;
                    }

                }
                if (flag)
                {
                    Console.WriteLine("Somente números são aceitos");
                }
                else
                { 
                    seg = Convert.ToInt32(aux);
                    if (seg > 60 || seg < 0)
                    {
                        Console.WriteLine("Valor inválido");
                    }
                }
            } while (seg > 60 || seg < 0);
            Console.Clear();
        }
        public void Imprime()
        {
            Console.WriteLine(hora + ":" + min + ":" + seg);
        }
        public Tempo Soma(Tempo t1,Tempo t2)
        {
            int h, m, s;
            h = t1.hora + t2.hora;
            m = t1.min + t2.min;
            s = t1.seg + t2.seg;
            if (s >= 60)
            {
                s -= 60;
                m++;
            }
            if(m >= 60)
            {
                s -= 60;
                h++;
            }
            if(h >= 24)
            {
                h -= 24;
            }
            Tempo t3 = new Tempo(h, m, s);
            return t3;
        }
        public Tempo Sub(Tempo t1, Tempo t2)
        {
            int h, m, s;
            h = t1.hora - t2.hora;
            m = t1.min - t2.min;
            s = t1.seg - t2.seg;
            if (s < 0)
                s = s * (-1);
            if (m < 0)
                m = m * (-1);
            if (h < 0)
                h = h * (-1);

            Tempo t3 = new Tempo(h, m, s);
            return t3;
        }
        public float modulo(Tempo t1)
        {
            return t1.hora + (t1.seg/3600) + (t1.min/60);
        }
    }
}
