using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularIMC
{
    internal class Program
    {
        static void Main(string[] args) { 
            Pessoa aluno = new Pessoa();
            aluno.Cadastrar();
          
            Console.WriteLine("Valor do Imc:{0}\n" ,aluno.CalcularImc());
            aluno.ExibirNome();
            aluno.ExibirImc();
        }
    }
}
