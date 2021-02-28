using System;

namespace Loja.DTO
{
    public class Movimento_Estoque_DTO
    {
        public int ID_ESTOQUE_MOVIMENTADO { get; set; }
        public int ID_PEDIDO { get; set; }
        public int ID_PRODUTO { get; set; }
        public int QUANT_PROD { get; set; }
        public DateTime DATA_HORA { get; set; }
        public string ENTROU_SAIU { get; set; }
        public string USUARIO { get; set; }
        //JOIN TABELA ESTOQUE PRODUTOS
        public string NOME_PRODUTO { get; set; }
        //CALCULO TOP 10
        public decimal CALCULO_PRODUTO { get; set; }
    }
}
