namespace Loja.DTO
{
    public class Pedido_Produtos_DTO
    {
        public int ID_PEDIDO { get; set; }
        public int ID_PRODUTO { get; set; }
        public int QUANT_PROD { get; set; }

        //Declarar os campos para Receber no SELECT JOIN
        public string NOME_PRODUTO { get; set; }

        public string TAMANHO { get; set; }
        public decimal VALOR_PRODUTO { get; set; }

        //nome usuario
        public string USUARIO { get; set; }
    }
}