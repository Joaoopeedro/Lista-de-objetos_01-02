using System;
using exemplo__dado__em__aula.Classes;

namespace exemplo__dado__em__aula
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa de conversão de moeda.");
            Console.WriteLine($@"
QUAL VOCÊ QUE CONVERTER??

1- REAL PARA DOLAR
2- DOLAR PARA REAL
");

            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Console.Write("  Digite o valor em reais: ");
                float ValorEmReais = float.Parse(Console.ReadLine());

                Console.Write("  Valor em US: ");
                Console.WriteLine(Conversor.RealParaDolar(ValorEmReais).ToString("N2"));

            }
            else if (opcao == 2)
            {
                Console.Write("  Digite o valor em dolar: ");
                float ValorEmReais = float.Parse(Console.ReadLine());

                Console.Write("  Valor em Real: ");
                Console.WriteLine(Conversor.DolarParaReal(ValorEmReais).ToString("C2"));
            }


        }
    }
}
