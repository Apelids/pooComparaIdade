using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pooCalculoMaiorIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa[] pessoas = new Pessoa[3];
            for (int i = 0; i < 3; i++)
            {
                pessoas[i] = new Pessoa();
                Console.WriteLine("Digite o nome da " + (i+1) + " pessoa: ");
                pessoas[i].Nome = Console.ReadLine();
                Console.WriteLine("Digite a idade da " + (i+1) + " pessoa: ");
                pessoas[i].Idade = int.Parse(Console.ReadLine());
            }

            int IndiceMaior = 0;

            for (int i = 0; i < 3; i++)
            {
                if (pessoas[i].Idade > pessoas[IndiceMaior].Idade)
                {
                    IndiceMaior = i;
                }
            }

            
            pessoas[IndiceMaior].exibirDadosMaior();
        }
    }
}
