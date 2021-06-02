using System;
using exemplo_MetodoConstrutor.Classes;

namespace exemplo_MetodoConstrutor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exemplo metodos construtores:");

            Produto p = new Produto();
            Console.WriteLine($"Segundo produto (construtor sem argumento)");
            Console.WriteLine($"Codigo: {p.Codigo}\nNome: {p.Nome}\nDescrição: {p.Descrisao}\nNumero de itens no estoque: {p.Estoque}");

            Produto p2 = new Produto(456);
            Console.WriteLine($"Segundo produto (construtor com 1 argumento)");
            Console.WriteLine($"Codigo: {p2.Codigo}\nNome: {p2.Nome}\nDescrição: {p2.Descrisao}\nNumero de itens no estoque: {p2.Estoque}");

            Produto p3 = new Produto(678, "Maça", "Maça bonita sem agrotoxicos", 3);
            Console.WriteLine($"Segundo produto (construtor com 4 argumentos)");
            Console.WriteLine($"Codigo: {p3.Codigo}\nNome: {p3.Nome}\nDescrição: {p3.Descrisao}\nNumero de itens no estoque: {p3.Estoque}");

        }
    }
}
