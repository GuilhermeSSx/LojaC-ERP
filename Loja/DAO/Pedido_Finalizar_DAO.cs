using Loja.AcessoBancoDados;
using Loja.DTO;
using System;
using System.Data;

namespace Loja.DAO
{
    public class Pedido_Finalizar_DAO
    {
        //instanciar = criar um novo objeto baseado em um modelo.
        private AcessoBancoDadosSqlServer acessoBancoDadosSqlServer = new AcessoBancoDadosSqlServer();

        public string PedidoFinalizar(Pedido_Finalizar_DTO pedido_Finalizar_DTO)
        {
            try
            {
                acessoBancoDadosSqlServer.LimparParametros();
                acessoBancoDadosSqlServer.AdicionarParametros("@ID_PEDIDO", pedido_Finalizar_DTO.ID_PEDIDO);
                acessoBancoDadosSqlServer.AdicionarParametros("@VALOR_DESCONTO", pedido_Finalizar_DTO.VALOR_DESCONTO);
                acessoBancoDadosSqlServer.AdicionarParametros("@QUANT_PARCELAS", pedido_Finalizar_DTO.QUANT_PARCELAS);
                acessoBancoDadosSqlServer.AdicionarParametros("@DATA_PARCELAS", pedido_Finalizar_DTO.DATA_PARCELAS);
                acessoBancoDadosSqlServer.AdicionarParametros("@VALOR_TOTAL", pedido_Finalizar_DTO.VALOR_TOTAL);
                acessoBancoDadosSqlServer.AdicionarParametros("@FORMA_PAGAMENTO", pedido_Finalizar_DTO.FORMA_PAGAMENTO);
                acessoBancoDadosSqlServer.AdicionarParametros("@USUARIO", pedido_Finalizar_DTO.USUARIO);

                string ID_PEDIDO = acessoBancoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspPedidoFinalizar").ToString();

                return ID_PEDIDO;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}