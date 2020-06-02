namespace Abstra_o
{
    public class Cartao : Pagamento

    {
   protected string token = "9879879879uyuy8kjkjh79yggjhhgjh87987987987987";

   public string titular { get; set; }

   public int numero { get; set; }

   public string cvv { get; set; }  

   public string bandeira { get; set; } 

   public bool ValidarToken(){
       if(token !=null){
           return true;
       }
       return false;
   }
    }
}