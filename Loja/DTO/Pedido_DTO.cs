using System;

namespace Loja.DTO
{
    public class Pedido_DTO
    {
        public int ID_PEDIDO { get; set; }
        public int ID_CLIENTE { get; set; }
        public DateTime DATA_PEDIDO { get; set; }
        public int ID_SITUACAO_PEDIDO { get; set; }
        public string USUARIO { get; set; }

        /// SELECT JOIN COM PEDIDO_FINALIZAR
        public int ID_PEDIDO_FINALIZAR { get; set; }

        public byte QUANT_PARCELAS { get; set; }
        public decimal VALOR_TOTAL { get; set; }
        public string DESCRICAO { get; set; }

        //// SELECT JOIN COM PEDIDO PARCELA FINALIZAR
        public int ID_PARCELA { get; set; }

        public decimal VALOR_PARCELA { get; set; }
        public int ID_SITUACAO_PARCELA { get; set; }

        //SELECT JOIN HISTORICO DE VENDAS
        public string NOME_CLIENTE { get; set; }
        public string FORMA_PAGAMENTO { get; set; }

        //valor pago pedido
        public decimal VALOR_PAGO { get; set; }

    }
}