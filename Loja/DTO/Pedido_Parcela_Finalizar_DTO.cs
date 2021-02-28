using System;

namespace Loja.DTO
{
    public class Pedido_Parcela_Finalizar_DTO
    {
        public int ID_PARCELA { get; set; }
        public int ID_PEDIDO { get; set; }
        public int QUANT_PARCELAS { get; set; }
        public DateTime DATA_PARCELAS { get; set; }
        public decimal VALOR_PARCELA { get; set; }
        public int ID_SITUACAO_PARCELA { get; set; }

        //valor descontado
        public decimal VALOR_DESCONTADO { get; set; }

        //JOIN COM TABELA SITUAÇÃO DA PARCELA
        public string DESCRICAO { get; set; }

        //nova data de vencimento parcela
        public DateTime NOVA_DATA_VENCIMENTO { get; set; }

        //Usuario
        public string USUARIO { get; set; }
    }
}