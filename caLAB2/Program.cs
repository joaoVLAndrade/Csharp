//João Victor Luiz De Andrade 11811EAU003
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace caLAB2
{
    class Program
    {
        static void Main(string[] args)
        {
            float preço;
            //teste classe tempo
            Tempo tempo1 = new Tempo();
            Tempo tempo2 = new Tempo();
            Tempo tempo3 = new Tempo();
            Tempo tempo4 = new Tempo();
            tempo1.NovoHorario();
            tempo2.NovoHorario();
            tempo3 = tempo1.Soma(tempo1, tempo2);
            tempo4 = tempo1.Sub(tempo1, tempo2);
            tempo1.Imprime();
            tempo2.Imprime();
            tempo3.Imprime();
            tempo4.Imprime();
            //teste classe estacionamento

            Estacionamento veic1 = new Estacionamento();

            veic1.cadastro();
            veic1.mostrar();
            veic1.preço();
            //teste matriz
            Console.Write("\n Cadastrar matriz de 5 carros\n");
            List<Estacionamento> listaCarro = new List<Estacionamento>();
            for (int i = 0; i < 5; i++)
            {
                Estacionamento car = new Estacionamento();
                Console.WriteLine("Carro " + (i + 1) + ":\n");
                car.cadastro();
                listaCarro.Add(car);
            }
            for (int i = 0; i < listaCarro.Count; i++)
            {
                Estacionamento aux = (Estacionamento)listaCarro[i];
                Console.WriteLine("\nCarro " + (i + 1) + ":\n");
                aux.mostrar();
                preço = aux.preço();
                Console.WriteLine("RS" + preço);
            }
        }
    }
}
