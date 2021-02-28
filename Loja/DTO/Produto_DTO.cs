using System;

namespace Loja.DTO
{
    public class Produto_DTO
    {
        public int ID_PRODUTO { get; set; }
        public string NOME_PRODUTO { get; set; }
        public string TAMANHO { get; set; }
        public int QUANT_PROD { get; set; }
        public decimal VALOR_COMPRA { get; set; }
        public decimal VALOR_PRODUTO { get; set; }
        public DateTime DATA_ENTRADA { get; set; }
        //usuario
        public string USUARIO { get; set; }
    }
}