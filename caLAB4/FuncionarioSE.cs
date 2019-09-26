using System;
using System.Collections.Generic;
using System.Text;

namespace caLAB4
{
    class FuncionarioSE : Funcionarios
    {
        //Construtores
        public FuncionarioSE() : base()
        {
        }
        public FuncionarioSE(String nome, String funcionalidade) : base(nome, funcionalidade)
        {
        }
        public override void BonusSalarial()
        {
            base.BonusSalarial();
        }
        public override void Preencher()
        {
            Console.WriteLine("Cadastro");
            Console.WriteLine("Nome: ");
            this.nome = (Console.ReadLine());
            Console.WriteLine("Função: ");
            this.funcionalidade = (Console.ReadLine());
            Console.WriteLine("\n");
        }
        public override void Imprime()
        {
            Console.WriteLine("Nome:" + this.nome);
            Console.WriteLine("Função:" + this.funcionalidade);
            Console.WriteLine("R$" + this.rendabase);
            Console.WriteLine("\n");
        }
    }
}
