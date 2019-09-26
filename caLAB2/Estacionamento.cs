/*02. Escreva uma classe para armazenar dados de um Estacionamento. Ela deve ser capaz de
armazenar o número da chapa do carro(String), a marca(String), a hora de entrada e a hora
de saída do estacionamento.Para tanto, use a classe Tempo, definida no exercício anterior,
para as horas de entrada e de saída.
a) Crie uma função para solicitar os dados de um carro para o usuário(utilize as funções da
classe Tempo para pedir a hora de entrada e a saída).
b) Crie uma função membro(ou método) para imprimir os dados de um carro.
c) Admita que o estacionamento cobre R$ 7,00 a hora.Escreva uma função membro que
imprima o valor cobrado. Utilize a função que subtrai duas horas da classe Tempo.
d) Escreva um programa que crie uma matriz de cinco objetos da classe anterior, solicite os
dados dos carros para o usuário e imprima um relatório dos dados e do valor cobrado.*/
using System;
using System.Collections.Generic;
using System.Text;

namespace caLAB2
{
    class Estacionamento
    {
        private String chapa, placa;
        private Tempo entrada, saida;
        //construtores
        public Estacionamento()
        {
            chapa = null;
            placa = null;
            entrada = new Tempo();
            saida = new Tempo();
        }
        //setters()
        public void  setChapa(String chp)
        {
            chapa = chp;
        }
        public void setPlaca(String plc)
        {
            placa = plc;
        }
        //getters()
        public String getChapa()
        {
            return chapa;
        }
        public String getPlaca()
        {
            return placa;
        }
        public Estacionamento cadastro()
        {
            Estacionamento aux = new Estacionamento();

            Console.WriteLine("Digite a chapa do carro: ");
            chapa = Console.ReadLine();

            Console.WriteLine("Digite a placa do carro: ");
            placa = Console.ReadLine();

            Console.WriteLine("Digite o horário de entrada: ");
            entrada.NovoHorario();

            Console.WriteLine("Digite o horário de saída: ");
            saida.NovoHorario();

            return aux;
        }

        public void mostrar()
        {
            Console.WriteLine("Chapa do carro: " + chapa);
            Console.WriteLine("Placa: " + placa);
            Console.WriteLine("Horário de Entrada: ");
            entrada.Imprime();
            Console.WriteLine("Horário de Saída: ");
            saida.Imprime();

        }

        public float preço()
        {
            float preço;
            Tempo t = saida.Sub(saida, entrada);
            float s = t.modulo(t);
            preço = (s * 7);
            return preço;
        }
    }
}
