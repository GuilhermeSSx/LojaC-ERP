namespace Loja.DTO
{
    public class Caixa_DTO
    {
        public int ID_CAIXA { get; set; }
        public decimal SALDO_CAIXA { get; set; }
        //saldo reforco
        public decimal SALDO_REFORCO { get; set; }
        //saldo sangria
        public decimal SALDO_SANGRIA { get; set; }
        //valor devolucao e nome Cliente
        public decimal VALOR_DEVOLUCAO { get; set; }
        public string NOME_CLIENTE { get; set; }
        //usuario
        public string USUARIO { get; set; }
    }
}
