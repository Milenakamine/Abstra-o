using System;

namespace Abstra_o
{
    class Program
    {
        static void Main(string[] args)
        {
            CartaoCredito visa = new CartaoCredito();
            visa.limite= 30000000f;

            Console.WriteLine("Deseja fazer alteração no limite? Quanto deseja a mais no limite?");
            float acrescimo = float.Parse (Console.ReadLine());

            visa.AumentarLimite(acrescimo);
            Console.WriteLine("Novo limite de R$" +visa.limite);

            System.Console.WriteLine("Digite a data do pagamento!");
            visa.data = DateTime.Parse (Console.ReadLine());
            System.Console.WriteLine("Data: " +visa.data);
        }

    }
}
