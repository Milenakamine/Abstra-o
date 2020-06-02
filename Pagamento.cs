using System;

namespace Abstra_o
{
    public class Pagamento
    {
        
public DateTime data { get; set; }  
//DateTime já vem com a data no formato certo

public float valor { get; set; } 

public string pagar(float valorPago){
    return"Valor pago R$"+valorPago;
}

public string cancelar (){
    return "Pagamento cancelado!";
}

//
    }
}