using Loja.AcessoBancoDados;
using Loja.DTO;
using System;
using System.Data;

namespace Loja.DAO
{
    internal class Movimento_Estoque_DAO
    {
        //instanciar = criar um novo objeto baseado em um modelo.
        private AcessoBancoDadosSqlServer acessoBancoDadosSqlServer = new AcessoBancoDadosSqlServer();

        public Movimento_Estoque_Colecao consultarMovimentoEstoque(DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                Movimento_Estoque_Colecao movimento_Estoque_Colecao = new Movimento_Estoque_Colecao();

                acessoBancoDadosSqlServer.LimparParametros();
                acessoBancoDadosSqlServer.AdicionarParametros("@DATA_INICIAL", dataInicial);
                acessoBancoDadosSqlServer.AdicionarParametros("@DATA_FINAL", dataFinal);

                //Data = Dados e Table=Tabela
                DataTable dataTableEstoqueMovimentado = acessoBancoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspMovimentoEstoque");

                foreach (DataRow linha in dataTableEstoqueMovimentado.Rows)
                {
                    Movimento_Estoque_DTO movimento_Estoque_DTO = new Movimento_Estoque_DTO();
                    movimento_Estoque_DTO.ID_PEDIDO = Convert.ToInt32(linha["ID_PEDIDO"]);
                    movimento_Estoque_DTO.NOME_PRODUTO = Convert.ToString(linha["NOME_PRODUTO"]);
                    movimento_Estoque_DTO.QUANT_PROD = Convert.ToInt32(linha["QUANT_PROD"]);
                    movimento_Estoque_DTO.DATA_HORA = Convert.ToDateTime(linha["DATA_HORA"]);
                    movimento_Estoque_DTO.ENTROU_SAIU = Convert.ToString(linha["ENTROU_SAIU"]);
                    movimento_Estoque_DTO.USUARIO = Convert.ToString(linha["USUARIO"]);

                    movimento_Estoque_Colecao.Add(movimento_Estoque_DTO);
                }

                return movimento_Estoque_Colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel listar o movimento de estoque" + ex.Message);
            }
        }

        public Movimento_Estoque_Colecao MEidprodutos()
        {
            try
            {
                Movimento_Estoque_Colecao movimento_Estoque_Colecao = new Movimento_Estoque_Colecao();

                acessoBancoDadosSqlServer.LimparParametros();

                //Data = Dados e Table=Tabela
                DataTable dataTableEstoqueMovimentado = acessoBancoDadosSqlServer.ExecutarConsulta(CommandType.Text,
                    "SELECT ID_PRODUTO FROM ESTOQUE_MOVIMENTADO WHERE ENTROU_SAIU = 'SAÍDA' AND ID_PEDIDO != 0 GROUP BY ID_PRODUTO");

                foreach (DataRow linha in dataTableEstoqueMovimentado.Rows)
                {
                    Movimento_Estoque_DTO movimento_Estoque_DTO = new Movimento_Estoque_DTO();
                    movimento_Estoque_DTO.ID_PRODUTO = Convert.ToInt32(linha["ID_PRODUTO"]);

                    movimento_Estoque_Colecao.Add(movimento_Estoque_DTO);
                }

                return movimento_Estoque_Colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel listar os ids produto ME" + ex.Message);
            }
        }

        public Movimento_Estoque_Colecao CalculoTop10Produto(string ID_PRODUTO)
        {
            try
            {
                Movimento_Estoque_Colecao movimento_Estoque_Colecao = new Movimento_Estoque_Colecao();

                acessoBancoDadosSqlServer.LimparParametros();
                acessoBancoDadosSqlServer.AdicionarParametros("@ID_PRODUTO", ID_PRODUTO);

                //Data = Dados e Table=Tabela
                DataTable dataTableEstoqueMovimentado = acessoBancoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspTop10Produtos");

                foreach (DataRow linha in dataTableEstoqueMovimentado.Rows)
                {
                    Movimento_Estoque_DTO movimento_Estoque_DTO = new Movimento_Estoque_DTO();
                    movimento_Estoque_DTO.CALCULO_PRODUTO = Convert.ToDecimal(linha["@Retorno"]);

                    movimento_Estoque_Colecao.Add(movimento_Estoque_DTO);
                }

                return movimento_Estoque_Colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel calcular o produto" + ex.Message);
            }
        }

        public Movimento_Estoque_Colecao MEidprodutosComprados()
        {
            try
            {
                Movimento_Estoque_Colecao movimento_Estoque_Colecao = new Movimento_Estoque_Colecao();

                acessoBancoDadosSqlServer.LimparParametros();

                //Data = Dados e Table=Tabela
                DataTable dataTableEstoqueMovimentado = acessoBancoDadosSqlServer.ExecutarConsulta(CommandType.Text,
                    "SELECT ID_PRODUTO FROM ESTOQUE_MOVIMENTADO WHERE ENTROU_SAIU = 'ENTRADA' GROUP BY ID_PRODUTO");

                foreach (DataRow linha in dataTableEstoqueMovimentado.Rows)
                {
                    Movimento_Estoque_DTO movimento_Estoque_DTO = new Movimento_Estoque_DTO();
                    movimento_Estoque_DTO.ID_PRODUTO = Convert.ToInt32(linha["ID_PRODUTO"]);

                    movimento_Estoque_Colecao.Add(movimento_Estoque_DTO);
                }

                return movimento_Estoque_Colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel listar os ids produto ME Comprados" + ex.Message);
            }
        }







    }
}