using System;
using Clientes.Classes;
namespace Clientes
{
    class Program
    {
        static void Main()
        {
            Cliente client = new Cliente("Vinicius Brito Costa", "07-12-1996", TipoCliente.PF, 000000000);
            Console.WriteLine(client.ToString());
        }
    }
}
