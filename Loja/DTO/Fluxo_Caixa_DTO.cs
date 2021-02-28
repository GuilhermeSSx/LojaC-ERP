using System;

namespace Loja.DTO
{
    public class Fluxo_Caixa_DTO
    {
        public int ID_FLUXO_CAIXA { get; set; }
        public string OPERACAO { get; set; }
        public string PRODUTO_PEDIDO { get; set; }
        public decimal VALOR { get; set; }
        public DateTime DATA_HORA { get; set; }
        public string USUARIO { get; set; }
    }
}