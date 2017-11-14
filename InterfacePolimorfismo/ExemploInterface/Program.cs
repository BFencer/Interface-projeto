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

            Console.WriteLine("\n");

            Endereco endereco = new Endereco();
            endereco.Logradouro = "Rua Nova Esperança";
            endereco.Numero = "27";
            endereco.Bairro = "Jardim sei lá";

            PF PF = new PF(10, "Helena", "2356", "helena@gmail.com", "6553", endereco);

            Console.WriteLine(PF.Cadastro());
        }
    }
}
