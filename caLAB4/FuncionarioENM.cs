using System;
using System.Collections.Generic;
using System.Text;

namespace caLAB4
{
    class FuncionarioENM : Funcionarios
    {

        //Atributos
        private String escola;
        //Construtores
        public FuncionarioENM() : base()
        {
            escola = "";
        }
        public FuncionarioENM(String nome, String funcionalidade, double _renda, String _escola) : base(nome, funcionalidade)
        {
            escola = _escola;
        }
        public void setEscola(String _escola)
        {
            escola = _escola;
        }
        public String getEscola()
        {
            return escola;
        }
        public override void BonusSalarial()
        {
            base.BonusSalarial();
            this.rendabase = this.rendabase + 0.5 * this.rendabase;
        }
        public override void Preencher()
        {
            Console.WriteLine("Cadastro");
            Console.WriteLine("Nome: ");
            this.nome = (Console.ReadLine());
            Console.WriteLine("Função: ");
            this.funcionalidade = (Console.ReadLine());
            Console.WriteLine("Escola ensino médio: ");
            this.escola = (Console.ReadLine());
            Console.WriteLine("\n");
        }
        public override void Imprime()
        {
            Console.WriteLine("Nome:" + this.nome);
            Console.WriteLine("Função:" + this.funcionalidade);
            Console.WriteLine("Ensino médio:" + this.escola);
            Console.WriteLine("R$" + this.rendabase);
            Console.WriteLine("\n");
        }
    }
}

