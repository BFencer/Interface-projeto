using System;
using ClasseInterface;

namespace ExemploInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto pr = new Produto(30, "Sabao", "Em pó", 30);
            Console.WriteLine(pr.Cadastro());
        }
    }
}
