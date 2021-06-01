using System;
using System.Collections.Generic;
using Lista_de_objetos.Classes;

namespace Lista_de_objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> produtos = new List<Produto>();

            // CRUD - creat, read, Update, Delete

            // Creat 
            // Adcionamdo usando o metodo construtor de Produtos 
            produtos.Add(new Produto(1, "Apple Watch", 3522.56f));
            produtos.Add(new Produto(2, "Xiaomi Watch", 1522.45f));
            produtos.Add(new Produto(3, "Zenfone ASUS", 2522.87f));
            produtos.Add(new Produto(4, "Sansung S21", 4500.90f));
            produtos.Add(new Produto(5, "Motorola G8", 2522.56f));

            Produto iphone = new Produto();
            iphone.Codigo = 6;
            iphone.Nome = "Iphone 12";
            iphone.Preco = 10200.34f;

            produtos.Add(iphone);

            // Read
            // Exibir conteudo da lista 
            foreach (var item in produtos)
            {
                Console.WriteLine($"{item.Nome} - R${item.Preco}");
            }
            Console.WriteLine("");

            // Delete
            // Remove o item do indice(posiçao)
            produtos.RemoveAt(5);
            // remover por expressão lambida e o RemoveAll
            produtos.RemoveAll(item => item.Nome == "Apple Watch");
            foreach (var item in produtos)
            {
                Console.WriteLine($"{item.Nome} - R${item.Preco}");
            }
            Console.WriteLine("");


            // Update 
            // Encontro produto atualizar 
            Produto atualizar = produtos.Find(item => item.Codigo == 4);
            // Modo o valor do produto
            atualizar.Preco = 1200.45f;
            // Remove o item antigo
            produtos.RemoveAll(item => item.Codigo == 4);
            // Inserir o item atualizado
            produtos.Insert(2, atualizar);
            foreach (var item in produtos)
            {
                Console.WriteLine($" {item.Nome} - R${item.Preco}");
            }



        }
    }
}
