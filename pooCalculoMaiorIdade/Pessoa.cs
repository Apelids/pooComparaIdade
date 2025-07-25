using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooCalculoMaiorIdade
{
	class Pessoa
	{
		public Pessoa() { nome = "";idade = 0; }
		public Pessoa(string nome, int idade)
        {
            this.nome = nome;
           this.idade = idade;
        }
        private int idade;

		public int Idade
		{
			get { return idade; }
			set { idade = value; }
		}

		private string nome;

		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}

		public void exibirDadosMaior() { Console.WriteLine( Nome + " é o mais velho(a) " + "com a idade de " + idade + " anos"); }
        

    }
}
