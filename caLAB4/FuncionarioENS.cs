using System;
using System.Collections.Generic;
using System.Text;

namespace caLAB4
{
    class FuncionarioENS : Funcionarios
    {

        //Atributos
        private String faculdade, curso;
        //Construtores
        public FuncionarioENS() : base()
        {
            faculdade = "";
        }
        public FuncionarioENS(String nome, String funcionalidade, double _renda, String _faculdade, String _curso) : base(nome, funcionalidade)
        {

            faculdade = _faculdade;
            curso = _curso;
        }
        public void setFaculdade(String _faculdade)
        {
            faculdade = _faculdade;
        }
        public String getFaculdade()
        {
            return faculdade;
        }
        public void setCurso(String _curso)
        {
            curso = _curso;
        }
        public String getCurso()
        {
            return curso;
        }
        public override void BonusSalarial()
        {
            base.BonusSalarial();
            this.rendabase = this.rendabase + this.rendabase;
        }
        public override void Preencher()
        {
            Console.WriteLine("Cadastro");
            Console.WriteLine("Nome: ");
            this.nome = (Console.ReadLine());
            Console.WriteLine("Função: ");
            this.funcionalidade = (Console.ReadLine());
            Console.WriteLine("Instituição de ensino superior: ");
            this.faculdade = (Console.ReadLine());
            Console.WriteLine("Curso: ");
            this.curso = (Console.ReadLine());
            Console.WriteLine("\n");
        }
        public override void Imprime()
        {
            Console.WriteLine("Nome:" + this.nome);
            Console.WriteLine("Função:" + this.funcionalidade);
            Console.WriteLine("Ensino superior:" + this.faculdade);
            Console.WriteLine("Curso: ");
            Console.WriteLine("R$" + this.rendabase);
            Console.WriteLine("\n");
        }
    }
}

