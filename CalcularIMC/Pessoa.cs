using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularIMC
{
    internal class Pessoa
    {
        private string nome;
        public double peso;
        private double altura;
        public double imc;

        public void PedirPeso()
        {
            Console.WriteLine("Digite seu peso:");
            peso = double.Parse(Console.ReadLine());

        }
        public void ExibirImc()
        {
            //Console.WriteLine("Valor do Imc:"+imc);
            if (imc <= 18.5)
            {
                Console.WriteLine("Magreza");
            }
            else if (imc > 18.5 && imc <= 24.9)
            {
                Console.WriteLine("Normal");
            }
        }

        public double CalcularImc()
        {
            imc = peso / Math.Pow(altura, 2);
            return imc;
        }

        public void PedirAltura()
        {

            Console.WriteLine("Digite sua altura");
            altura = double.Parse(Console.ReadLine());
            while (altura < 0.20)
            {
                Console.WriteLine("alturaInvalida:");
                Console.WriteLine("Digite sua altura");
                altura = double.Parse(Console.ReadLine());
            }
        }

        public void PedirNome()
        {
            Console.WriteLine("Digite seu nome:");
            nome = Console.ReadLine();
        }
        public void ExibirNome()
        {
            Console.WriteLine("Nome:{0}\n", nome);
        }

        public void Cadastrar()
        {
            PedirNome();
            PedirPeso();
            PedirAltura();
        }
    }
}
