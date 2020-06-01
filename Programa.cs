namespace Aula07Encapsulamento
{
    class Programa
    {
        
        static void Main( string [] args)
        {

            Cartao card = new Cartao ();
            card.AprovarCompra();

            MasterCard master = new MasterCard();
            master.parcelas = 3;
            master.CompraComDescontoMasterCard(50F);
        }
    }
}