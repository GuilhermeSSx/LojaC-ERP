using System;

namespace Loja.DTO
{
    public class Pedido_Finalizar_DTO
    {
        public int ID_PEDIDO { get; set; }
        public decimal VALOR_DESCONTO { get; set; }
        public byte QUANT_PARCELAS { get; set; }
        public DateTime DATA_PARCELAS { get; set; }
        public decimal VALOR_TOTAL { get; set; }
        //forma pagamento
        public string FORMA_PAGAMENTO { get; set; }
        //usuario
        public string USUARIO { get; set; }
    }
}