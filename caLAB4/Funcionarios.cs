using System;
using System.Collections.Generic;
using System.Text;

namespace caLAB4
{
    class Funcionarios
    {
        //Atributos
        protected String nome, funcionalidade;
        protected Double rendabase;
        //Construtores
        public Funcionarios()
        {
            nome = "";
            funcionalidade = "";
            rendabase = 1000.0;
        }
        public Funcionarios(String _nome, String _funcionalidade)
        {
            nome = _nome;
            funcionalidade = _funcionalidade;
        }
        public void SetNome(String Nome)
        {
            nome = Nome;
        }
        public void SetFuncionalidade(String Funcionalidade)
        {
            funcionalidade = Funcionalidade;
        }
        public void SetRenda(double Renda)
        {
            rendabase = Renda;
        }
        public String getNome()
        {
            return nome;
        }
        public String getFuncionalidade()
        {
            return funcionalidade;
        }
        public double getRenda()
        {
            return rendabase;
        }
        public virtual void BonusSalarial() { }
        public virtual void Preencher() { }
        public virtual void Imprime() { }
    }
}
