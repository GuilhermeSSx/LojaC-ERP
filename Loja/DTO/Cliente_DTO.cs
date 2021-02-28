using System;

namespace Loja.DTO
{
    public class Cliente_DTO
    {
        public int ID_CLIENTE { get; set; }
        public string NOME_CLIENTE { get; set; }
        public string ENDERECO { get; set; }
        public string BAIRRO { get; set; }
        public int NUMERO { get; set; }
        public string CPF { get; set; }
        public long CELULAR { get; set; }
        public int RG { get; set; }

        //--- JOIN CONTAS A RECEBER CLIENTE
        public decimal VALOR_PARCELA { get; set; }

        public DateTime DATA_PARCELAS { get; set; }
    }
}