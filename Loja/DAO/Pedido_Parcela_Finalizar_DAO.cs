using Loja.AcessoBancoDados;
using Loja.DTO;
using System;
using System.Data;

namespace Loja.DAO
{
    public class Pedido_Parcela_Finalizar_DAO
    {
        //instanciar = criar um novo objeto baseado em um modelo.
        private AcessoBancoDadosSqlServer acessoBancoDadosSqlServer = new AcessoBancoDadosSqlServer();

        public string PedidoParcelaCriar(Pedido_Parcela_Finalizar_DTO pedido_Parcela_Finalizar_DTO)
        {
            try
            {
                acessoBancoDadosSqlServer.LimparParametros();
                acessoBancoDadosSqlServer.AdicionarParametros("@ID_PEDIDO", pedido_Parcela_Finalizar_DTO.ID_PEDIDO);
                acessoBancoDadosSqlServer.AdicionarParametros("@QUANT_PARCELAS", pedido_Parcela_Finalizar_DTO.QUANT_PARCELAS);
                acessoBancoDadosSqlServer.AdicionarParametros("@DATA_PARCELAS", pedido_Parcela_Finalizar_DTO.DATA_PARCELAS);
                acessoBancoDadosSqlServer.AdicionarParametros("@VALOR_PARCELA", pedido_Parcela_Finalizar_DTO.VALOR_PARCELA);

                string ID_PEDIDO = acessoBancoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspPedidoFinalizarParcelado").ToString();

                return ID_PEDIDO;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Pedido_Parcela_Finalizar_Colecao pedidoParcelasConsultar(string ID_PEDIDO)
        {
            try
            {
                //Criar uma coleção nova de pedido parcela (aqui está vazia)
                Pedido_Parcela_Finalizar_Colecao pedido_Parcela_Finalizar_Colecao = new Pedido_Parcela_Finalizar_Colecao();

                acessoBancoDadosSqlServer.LimparParametros();
                acessoBancoDadosSqlServer.AdicionarParametros("@ID_PEDIDO", ID_PEDIDO);

                //Data = Dados e Table=Tabela
                DataTable dataTablePedidoParcelaConsulta = acessoBancoDadosSqlServer.
                    ExecutarConsulta(CommandType.StoredProcedure, "uspPedidoParcelamentoConsultar");

                //Percorrer o DataTable e Transformar em coleção de pedido parcela - Cada Linha do DataTable é um parcela.
                foreach (DataRow linha in dataTablePedidoParcelaConsulta.Rows)
                {
                    //Criar um pedido parcela vazio - Colocar os dados da linha nele - Adicionar ele na coleção
                    Pedido_Parcela_Finalizar_DTO pedido_Parcela_Finalizar_DTO = new Pedido_Parcela_Finalizar_DTO();
                    pedido_Parcela_Finalizar_DTO.ID_PARCELA = Convert.ToInt32(linha["ID_PARCELA"]);
                    pedido_Parcela_Finalizar_DTO.ID_PEDIDO = Convert.ToInt32(linha["ID_PEDIDO"]);
                    pedido_Parcela_Finalizar_DTO.QUANT_PARCELAS = Convert.ToInt32(linha["QUANT_PARCELAS"]);
                    pedido_Parcela_Finalizar_DTO.VALOR_PARCELA = Convert.ToDecimal(linha["VALOR_PARCELA"]);
                    pedido_Parcela_Finalizar_DTO.DATA_PARCELAS = Convert.ToDateTime(linha["DATA_PARCELAS"]);
                    pedido_Parcela_Finalizar_DTO.ID_SITUACAO_PARCELA = Convert.ToInt32(linha["ID_SITUACAO_PARCELA"]);
                    pedido_Parcela_Finalizar_DTO.DESCRICAO = Convert.ToString(linha["DESCRICAO"]);

                    pedido_Parcela_Finalizar_Colecao.Add(pedido_Parcela_Finalizar_DTO);
                }

                return pedido_Parcela_Finalizar_Colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel consultar parcelas do pedido" + ex.Message);
            }
        }

        public string QuitarTodasParcelas(Pedido_Parcela_Finalizar_DTO pedido_Parcela_Finalizar_DTO)
        {
            try
            {
                acessoBancoDadosSqlServer.LimparParametros();
                acessoBancoDadosSqlServer.AdicionarParametros("@ID_PEDIDO", pedido_Parcela_Finalizar_DTO.ID_PEDIDO);
                acessoBancoDadosSqlServer.AdicionarParametros("@USUARIO", pedido_Parcela_Finalizar_DTO.USUARIO);

                string ID_PEDIDO = acessoBancoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspPedidoParceladoQuitarTudo").ToString();

                return ID_PEDIDO;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string QuitarParcela(Pedido_Parcela_Finalizar_DTO pedido_Parcela_Finalizar_DTO)
        {
            try
            {
                acessoBancoDadosSqlServer.LimparParametros();
                acessoBancoDadosSqlServer.AdicionarParametros("@ID_PARCELA", pedido_Parcela_Finalizar_DTO.ID_PARCELA);
                acessoBancoDadosSqlServer.AdicionarParametros("@USUARIO", pedido_Parcela_Finalizar_DTO.USUARIO);

                string ID_PARCELA = acessoBancoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure,
                    "uspPedidoQuitarParcela").ToString();

                return ID_PARCELA;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string PagamentoParcial(Pedido_Parcela_Finalizar_DTO pedido_Parcela_Finalizar_DTO)
        {
            try
            {
                acessoBancoDadosSqlServer.LimparParametros();
                acessoBancoDadosSqlServer.AdicionarParametros("@ID_PARCELA", pedido_Parcela_Finalizar_DTO.ID_PARCELA);
                acessoBancoDadosSqlServer.AdicionarParametros("@VALOR_PARCELA", pedido_Parcela_Finalizar_DTO.VALOR_PARCELA);
                acessoBancoDadosSqlServer.AdicionarParametros("@VALOR_DESCONTADO", pedido_Parcela_Finalizar_DTO.VALOR_DESCONTADO);
                acessoBancoDadosSqlServer.AdicionarParametros("@NOVA_DATA_VENCIMENTO", pedido_Parcela_Finalizar_DTO.NOVA_DATA_VENCIMENTO);
                acessoBancoDadosSqlServer.AdicionarParametros("@USUARIO", pedido_Parcela_Finalizar_DTO.USUARIO);

                string ID_PARCELA = acessoBancoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspPagamentoParcialParcela").ToString();

                return ID_PARCELA;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string valorParcelaResetar(Pedido_Parcela_Finalizar_DTO pedido_Parcela_Finalizar_DTO)
        {
            try
            {
                acessoBancoDadosSqlServer.LimparParametros();
                acessoBancoDadosSqlServer.AdicionarParametros("@ID_PARCELA", pedido_Parcela_Finalizar_DTO.ID_PARCELA);
                acessoBancoDadosSqlServer.AdicionarParametros("@VALOR_PARCELA", pedido_Parcela_Finalizar_DTO.VALOR_PARCELA);

                string ID_PARCELA = acessoBancoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspValorParcelaResetar").ToString();

                return ID_PARCELA;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }



    }
}