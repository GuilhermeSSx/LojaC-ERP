using Loja.AcessoBancoDados;
using Loja.DTO;
using System;
using System.Data;

namespace Loja.DAO
{
    public class Pedido_Produtos_DAO
    {
        //instanciar = criar um novo objeto baseado em um modelo.
        private AcessoBancoDadosSqlServer acessoBancoDadosSqlServer = new AcessoBancoDadosSqlServer();

        public string InserirProdutos(Pedido_Produtos_DTO pedido_Produtos_DTO)
        {
            try
            {
                acessoBancoDadosSqlServer.LimparParametros();
                acessoBancoDadosSqlServer.AdicionarParametros("@ID_PEDIDO", pedido_Produtos_DTO.ID_PEDIDO);
                acessoBancoDadosSqlServer.AdicionarParametros("@ID_PRODUTO", pedido_Produtos_DTO.ID_PRODUTO);
                acessoBancoDadosSqlServer.AdicionarParametros("@QUANT_PROD", pedido_Produtos_DTO.QUANT_PROD);
                acessoBancoDadosSqlServer.AdicionarParametros("@USUARIO", pedido_Produtos_DTO.USUARIO);

                string ID_PEDIDO = acessoBancoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspPedidoAdicionarProduto").ToString();

                return ID_PEDIDO;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string RemoverProduto(Pedido_Produtos_DTO pedido_Produtos_DTO)
        {
            try
            {
                acessoBancoDadosSqlServer.LimparParametros();
                acessoBancoDadosSqlServer.AdicionarParametros("@ID_PRODUTO", pedido_Produtos_DTO.ID_PRODUTO);
                acessoBancoDadosSqlServer.AdicionarParametros("@ID_PEDIDO", pedido_Produtos_DTO.ID_PEDIDO);
                string ID_PEDIDO = acessoBancoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspPedidoRemoverProduto").ToString();

                return ID_PEDIDO;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Pedido_Produtos_Colecao PedidoConsultarProdutos(string ID_PEDIDO)
        {
            try
            {
                //Criar uma coleção nova de pedido produtos (aqui está vazia)
                Pedido_Produtos_Colecao pedido_Produtos_Colecao = new Pedido_Produtos_Colecao();

                acessoBancoDadosSqlServer.LimparParametros();
                acessoBancoDadosSqlServer.AdicionarParametros("@ID_PEDIDO", ID_PEDIDO);

                //Data = Dados e Table=Tabela
                DataTable dataTablePedidoConsultaProduto = acessoBancoDadosSqlServer.
                    ExecutarConsulta(CommandType.StoredProcedure, "uspPedidoConsultarProdutos");

                //Percorrer o DataTable e Transformar em coleção de pedido produtos - Cada Linha do DataTable é um pedido produto.
                foreach (DataRow linha in dataTablePedidoConsultaProduto.Rows)
                {
                    //Criar um pedido produto vazio - Colocar os dados da linha nele - Adicionar ele na coleção
                    Pedido_Produtos_DTO pedido_Produtos_DTO = new Pedido_Produtos_DTO();
                    pedido_Produtos_DTO.ID_PEDIDO = Convert.ToInt32(linha["ID_PEDIDO"]);
                    pedido_Produtos_DTO.ID_PRODUTO = Convert.ToInt32(linha["ID_PRODUTO"]);
                    pedido_Produtos_DTO.QUANT_PROD = Convert.ToInt32(linha["QUANT_PROD"]);
                    pedido_Produtos_DTO.NOME_PRODUTO = Convert.ToString(linha["NOME_PRODUTO"]);
                    pedido_Produtos_DTO.TAMANHO = Convert.ToString(linha["TAMANHO"]);
                    pedido_Produtos_DTO.VALOR_PRODUTO = Convert.ToDecimal(linha["VALOR_PRODUTO"]);

                    pedido_Produtos_Colecao.Add(pedido_Produtos_DTO);
                }

                return pedido_Produtos_Colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel consultar os produtos do pedido" + ex.Message);
            }
        }
    }
}