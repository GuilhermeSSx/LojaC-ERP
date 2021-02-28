using Loja.AcessoBancoDados;
using Loja.DTO;
using System;
using System.Data;

namespace Loja.DAO
{
    public class Pedido_DAO
    {
        //instanciar = criar um novo objeto baseado em um modelo.
        private AcessoBancoDadosSqlServer acessoBancoDadosSqlServer = new AcessoBancoDadosSqlServer();

        public string CriarPedido(Pedido_DTO pedido_DTO)
        {
            try
            {
                acessoBancoDadosSqlServer.LimparParametros();
                acessoBancoDadosSqlServer.AdicionarParametros("@ID_CLIENTE", pedido_DTO.ID_CLIENTE);
                acessoBancoDadosSqlServer.AdicionarParametros("@USUARIO", pedido_DTO.USUARIO);

                string ID_PEDIDO = acessoBancoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspPedidoCriar").ToString();

                return ID_PEDIDO;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string ResetarPedido(Pedido_DTO pedido_DTO)
        {
            try
            {
                acessoBancoDadosSqlServer.LimparParametros();
                acessoBancoDadosSqlServer.AdicionarParametros("@ID_PEDIDO", pedido_DTO.ID_PEDIDO);
                string ID_PEDIDO = acessoBancoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspPedidoResetar").ToString();

                return ID_PEDIDO;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Pedido_Colecao PedidoConsultar(string ID_CLIENTE)
        {
            try
            {
                //Criar uma coleção nova de pedido produtos (aqui está vazia)
                Pedido_Colecao pedido_Colecao = new Pedido_Colecao();

                acessoBancoDadosSqlServer.LimparParametros();
                acessoBancoDadosSqlServer.AdicionarParametros("@ID_CLIENTE", ID_CLIENTE);

                //Data = Dados e Table=Tabela
                DataTable dataTablePedidoConsulta = acessoBancoDadosSqlServer.
                    ExecutarConsulta(CommandType.StoredProcedure, "uspPedidoSelecionar");

                //Percorrer o DataTable e Transformar em coleção de pedido - Cada Linha do DataTable é um pedido.
                foreach (DataRow linha in dataTablePedidoConsulta.Rows)
                {
                    //Criar um pedido vazio - Colocar os dados da linha nele - Adicionar ele na coleção
                    Pedido_DTO pedido_DTO = new Pedido_DTO();
                    pedido_DTO.ID_PEDIDO = Convert.ToInt32(linha["ID_PEDIDO"]);
                    pedido_DTO.ID_PEDIDO_FINALIZAR = Convert.ToInt32(linha["ID_PEDIDO"]);
                    pedido_DTO.QUANT_PARCELAS = Convert.ToByte(linha["QUANT_PARCELAS"]);
                    pedido_DTO.VALOR_TOTAL = Convert.ToDecimal(linha["VALOR_TOTAL"]);
                    pedido_DTO.ID_SITUACAO_PEDIDO = Convert.ToInt32(linha["ID_SITUACAO_PEDIDO"]);
                    pedido_DTO.DESCRICAO = Convert.ToString(linha["DESCRICAO"]);
                    pedido_DTO.DATA_PEDIDO = Convert.ToDateTime(linha["DATA_PEDIDO"]);

                    pedido_Colecao.Add(pedido_DTO);
                }

                return pedido_Colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel consultar os produtos do pedido" + ex.Message);
            }
        }

        public Pedido_Colecao consultarTotalDebitosCliente(string ID_CLIENTE)
        {
            try
            {
                //Criar uma coleção nova de pedido parcela (aqui está vazia)
                Pedido_Colecao pedido_Colecao = new Pedido_Colecao();

                acessoBancoDadosSqlServer.LimparParametros();
                acessoBancoDadosSqlServer.AdicionarParametros("@ID_CLIENTE", ID_CLIENTE);

                //Data = Dados e Table=Tabela
                DataTable dataTableTotalDebitosCliente = acessoBancoDadosSqlServer.
                    ExecutarConsulta(CommandType.StoredProcedure, "uspTotalDebitosCliente");

                //Percorrer o DataTable e Transformar em coleção de pedido parcela - Cada Linha do DataTable é um parcela.
                foreach (DataRow linha in dataTableTotalDebitosCliente.Rows)
                {
                    //Criar um pedido parcela vazio - Colocar os dados da linha nele - Adicionar ele na coleção
                    Pedido_DTO pedido_DTO = new Pedido_DTO();
                    pedido_DTO.ID_PARCELA = Convert.ToInt32(linha["ID_PARCELA"]);
                    pedido_DTO.VALOR_PARCELA = Convert.ToDecimal(linha["VALOR_PARCELA"]);
                    pedido_DTO.ID_SITUACAO_PARCELA = Convert.ToInt32(linha["ID_SITUACAO_PARCELA"]);

                    pedido_Colecao.Add(pedido_DTO);
                }

                return pedido_Colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel consultar total de debitos do cliente" + ex.Message);
            }
        }

        public string QuitarPedido(Pedido_DTO pedido_DTO)
        {
            try
            {
                acessoBancoDadosSqlServer.LimparParametros();
                acessoBancoDadosSqlServer.AdicionarParametros("@ID_PEDIDO", pedido_DTO.ID_PEDIDO);

                string ID_PEDIDO = acessoBancoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspPedidoQuitar").ToString();

                return ID_PEDIDO;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string RemoverPedido(Pedido_DTO pedido_DTO)
        {
            try
            {
                acessoBancoDadosSqlServer.LimparParametros();
                acessoBancoDadosSqlServer.AdicionarParametros("@ID_PEDIDO", pedido_DTO.ID_PEDIDO);
                acessoBancoDadosSqlServer.AdicionarParametros("@VALOR_PAGO", pedido_DTO.VALOR_PAGO);
                acessoBancoDadosSqlServer.AdicionarParametros("@USUARIO", pedido_DTO.USUARIO);
                string ID_PEDIDO = acessoBancoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspRemoverPedido").ToString();

                return ID_PEDIDO;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Pedido_Colecao TodosClientesPedidos()
        {
            try
            {
                Pedido_Colecao pedido_Colecao = new Pedido_Colecao();

                acessoBancoDadosSqlServer.LimparParametros();

                //Data = Dados e Table=Tabela
                DataTable dataTableTodosClientesPedidos = acessoBancoDadosSqlServer.
                    ExecutarConsulta(CommandType.Text, "SELECT ID_CLIENTE FROM PEDIDOS GROUP BY ID_CLIENTE");

                foreach (DataRow linha in dataTableTodosClientesPedidos.Rows)
                {
                    Pedido_DTO pedido_DTO = new Pedido_DTO();
                    pedido_DTO.ID_CLIENTE = Convert.ToInt32(linha["ID_CLIENTE"]);

                    pedido_Colecao.Add(pedido_DTO);
                }

                return pedido_Colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel carregar todos Clientes que tem pedido" + ex.Message);
            }
        }



        public Pedido_Colecao carregarHistoricoVendas(DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                //Criar uma coleção nova de pedido parcela (aqui está vazia)
                Pedido_Colecao pedido_Colecao = new Pedido_Colecao();

                acessoBancoDadosSqlServer.LimparParametros();
                acessoBancoDadosSqlServer.AdicionarParametros("@DATA_INICIAL", dataInicial);
                acessoBancoDadosSqlServer.AdicionarParametros("@DATA_FINAL", dataFinal);

                //Data = Dados e Table=Tabela
                DataTable dataTableHistoricoVendas = acessoBancoDadosSqlServer.
                    ExecutarConsulta(CommandType.StoredProcedure, "uspCarregarHistoricoVendas");

                //Percorrer o DataTable e Transformar em coleção de pedido parcela - Cada Linha do DataTable é um parcela.
                foreach (DataRow linha in dataTableHistoricoVendas.Rows)
                {
                    //Criar um pedido parcela vazio - Colocar os dados da linha nele - Adicionar ele na coleção
                    Pedido_DTO pedido_DTO = new Pedido_DTO();

                    pedido_DTO.ID_PEDIDO = Convert.ToInt32(linha["ID_PEDIDO"]);
                    pedido_DTO.NOME_CLIENTE = Convert.ToString(linha["NOME_CLIENTE"]);
                    pedido_DTO.VALOR_TOTAL = Convert.ToDecimal(linha["VALOR_TOTAL"]);
                    pedido_DTO.FORMA_PAGAMENTO = Convert.ToString(linha["FORMA_PAGAMENTO"]);
                    pedido_DTO.DATA_PEDIDO = Convert.ToDateTime(linha["DATA_PEDIDO"]);
                    pedido_DTO.USUARIO = Convert.ToString(linha["USUARIO"]);

                    pedido_Colecao.Add(pedido_DTO);
                }

                return pedido_Colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel carregar o Historico de Vendas." + ex.Message);
            }
        }



    }
}