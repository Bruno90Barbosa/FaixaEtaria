using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DESCUBRA A SUA FAIXA ETÁRIA");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Digite o seu nome: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Agora, digite a sua idade: ");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("-------------------------------------");
            Console.WriteLine(nome + ", o seu resultado está pronto.");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine();

            if (idade <= 11)
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Você é uma Criança");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("De acordo com o Estatuto da Criança e do Adolescente, o famoso ECA, criança é a pessoa com até 12 anos de idade incompletos.");
            }
            else if (idade >= 12 && idade <= 29)
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Você é um Adolescente ou Jovem");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Nos termos do ECA, adolescente é a pessoa com idade que varia dos 12 anos completos até os 18 anos incompletos.");
                Console.WriteLine("A lei que dispõe sobre o conceito de jovem é o Estatuto da Juventude (Lei nº 12.852/13).\r\nDe acordo com a referida lei, jovem é a pessoa com idade entre 15 e 29 anos de idade.\r\nAssim, uma pessoa com idade entre 15 e 18 anos incompletos é considerada um(a) jovem");
            }
            else if (idade >= 30 && idade <= 59)
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Você é um Adulto");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Por exclusão (ausência de lei conceituando), temos que adulto é a pessoa com idade entre 30 e 59 anos.");
            }
            else
            {
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Você é um Idoso");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("O conceito jurídico de idoso está na Lei nº 10.741/03 (Estatuto do Idoso). Segundo a lei, idoso é a pessoa com idade igual ou superior a 60 anos.");
            }



            Console.ReadLine();
        }
    }
}
