using System;

namespace Abstra_o
{
    public class Boleto : Pagamento
    {
       public DateTime dataVencimento { get; set; } 
       public string bancoEmissor { get; set; }

       public string codDeBarras { get; set; }

       public string Registrar(){
           return"Boleto registrado com sucesso!";
       }
    }
}