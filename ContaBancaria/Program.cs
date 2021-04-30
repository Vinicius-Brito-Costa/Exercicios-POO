using System;
using Guanabara.Classes;
using Guanabara.Enums;
namespace ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBanco conta = new ContaBanco(1, TipoConta.ContaCorrente, "Vinicius Brito");
            conta.Depositar(50.1f);
            conta.abrirConta(1);
            conta.Depositar(50.1f);
            Console.WriteLine($"Seu saldo é R${conta.getSaldo()}");
            Console.WriteLine(conta.ToString());
        }
    }
}
