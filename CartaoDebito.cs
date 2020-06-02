namespace Abstra_o
{
    public class CartaoDebito : Cartao
    {
public float saldo { get; set; }

public string Transferir(){
    return "Transferência efetuada com sucesso!";
}
public string PagarTitulo(){
    return "Título pago!";
}
    }
}