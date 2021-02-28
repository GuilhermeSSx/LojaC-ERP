using Loja.AcessoBancoDados;
using Loja.DTO;
using System;
using System.Data;

namespace Loja.DAO
{
    public class Produto_DAO
    {
        //instanciar = criar um novo objeto baseado em um modelo.
        private AcessoBancoDadosSqlServer acessoBancoDadosSqlServer = new AcessoBancoDadosSqlServer();

        public string CadastrarProduto(Produto_DTO produto_DTO)
        {
            try
            {
                acessoBancoDadosSqlServer.LimparParametros();
                acessoBancoDadosSqlServer.AdicionarParametros("@NOME_PRODUTO", produto_DTO.NOME_PRODUTO);
                acessoBancoDadosSqlServer.AdicionarParametros("@TAMANHO", produto_DTO.TAMANHO);
                acessoBancoDadosSqlServer.AdicionarParametros("@QUANT_PROD", produto_DTO.QUANT_PROD);
                acessoBancoDadosSqlServer.AdicionarParametros("@VALOR_COMPRA", produto_DTO.VALOR_COMPRA);
                acessoBancoDadosSqlServer.AdicionarParametros("@VALOR_PRODUTO", produto_DTO.VALOR_PRODUTO);
                acessoBancoDadosSqlServer.AdicionarParametros("@DATA_ENTRADA", produto_DTO.DATA_ENTRADA);
                acessoBancoDadosSqlServer.AdicionarParametros("@USUARIO", produto_DTO.USUARIO);
                string ID_PRODUTO = acessoBancoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspProdutoInserir").ToString();

                return ID_PRODUTO;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string alterarProduto(Produto_DTO produto_DTO)
        {
            try
            {
                acessoBancoDadosSqlServer.LimparParametros();
                acessoBancoDadosSqlServer.AdicionarParametros("@ID_PRODUTO", produto_DTO.ID_PRODUTO);
                acessoBancoDadosSqlServer.AdicionarParametros("@NOME_PRODUTO", produto_DTO.NOME_PRODUTO);
                acessoBancoDadosSqlServer.AdicionarParametros("@TAMANHO", produto_DTO.TAMANHO);
                acessoBancoDadosSqlServer.AdicionarParametros("@VALOR_COMPRA", produto_DTO.VALOR_COMPRA);
                acessoBancoDadosSqlServer.AdicionarParametros("@VALOR_PRODUTO", produto_DTO.VALOR_PRODUTO);
                acessoBancoDadosSqlServer.AdicionarParametros("@DATA_ENTRADA", produto_DTO.DATA_ENTRADA);
                string ID_PRODUTO = acessoBancoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspProdutoAlterar").ToString();

                return ID_PRODUTO;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string AumentarDiminuirEstoque(Produto_DTO produto_DTO)
        {
            try
            {
                acessoBancoDadosSqlServer.LimparParametros();
                acessoBancoDadosSqlServer.AdicionarParametros("@ID_PRODUTO", produto_DTO.ID_PRODUTO);
                acessoBancoDadosSqlServer.AdicionarParametros("@NOME_PRODUTO", produto_DTO.NOME_PRODUTO);
                acessoBancoDadosSqlServer.AdicionarParametros("@QUANT_PROD", produto_DTO.QUANT_PROD);
                acessoBancoDadosSqlServer.AdicionarParametros("@VALOR_COMPRA", produto_DTO.VALOR_COMPRA);
                acessoBancoDadosSqlServer.AdicionarParametros("@USUARIO", produto_DTO.USUARIO);
                string ID_PRODUTO = acessoBancoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspProdutoAumentarDiminuir").ToString();

                return ID_PRODUTO;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }





        public string ExcluirProduto(Produto_DTO produto_DTO, string USUARIO)
        {
            try
            {
                acessoBancoDadosSqlServer.LimparParametros();
                acessoBancoDadosSqlServer.AdicionarParametros("@ID_PRODUTO", produto_DTO.ID_PRODUTO);
                acessoBancoDadosSqlServer.AdicionarParametros("@USUARIO", USUARIO);
                string ID_PRODUTO = acessoBancoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspProdutoExcluir").ToString();

                return ID_PRODUTO;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Produto_Colecao ConsultarPorNome(string NOME)
        {
            try
            {
                //Criar uma coleção nova de clientes (aqui está vazia)
                Produto_Colecao produto_Colecao = new Produto_Colecao();

                acessoBancoDadosSqlServer.LimparParametros();
                acessoBancoDadosSqlServer.AdicionarParametros("@NOME_PRODUTO", NOME);

                //Data = Dados e Table=Tabela
                DataTable dataTableProduto = acessoBancoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspProdutoConsultarPorNome");

                //Percorrer o DataTable e Transformar em coleção de cliente - Cada Linha do DataTable é um cliente.
                foreach (DataRow linha in dataTableProduto.Rows)
                {
                    //Criar um produto vazio - Colocar os dados da linha nele - Adicionar ele na coleção
                    Produto_DTO produto_DTO = new Produto_DTO();
                    produto_DTO.ID_PRODUTO = Convert.ToInt32(linha["ID_PRODUTO"]);
                    produto_DTO.NOME_PRODUTO = Convert.ToString(linha["NOME_PRODUTO"]);
                    produto_DTO.TAMANHO = Convert.ToString(linha["TAMANHO"]);
                    produto_DTO.QUANT_PROD = Convert.ToInt32(linha["QUANT_PROD"]);
                    produto_DTO.VALOR_COMPRA = Convert.ToDecimal(linha["VALOR_COMPRA"]);
                    produto_DTO.VALOR_PRODUTO = Convert.ToDecimal(linha["VALOR_PRODUTO"]);
                    produto_DTO.DATA_ENTRADA = Convert.ToDateTime(linha["DATA_ENTRADA"]);

                    produto_Colecao.Add(produto_DTO);
                }

                return produto_Colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel consultar o produto por nome." + ex.Message);
            }
        }

        public Produto_Colecao CarregarQuantidadeProduto(string ID_PRODUTO)
        {
            try
            {
                //Criar uma coleção nova de clientes (aqui está vazia)
                Produto_Colecao produto_Colecao = new Produto_Colecao();

                acessoBancoDadosSqlServer.LimparParametros();
                acessoBancoDadosSqlServer.AdicionarParametros("@ID_PRODUTO", ID_PRODUTO);

                //Data = Dados e Table=Tabela
                DataTable dataTableProduto = acessoBancoDadosSqlServer.ExecutarConsulta(CommandType.Text,
                    "SELECT QUANT_PROD FROM ESTOQUE_PRODUTOS WHERE ID_PRODUTO = @ID_PRODUTO");

                //Percorrer o DataTable e Transformar em coleção de cliente - Cada Linha do DataTable é um cliente.
                foreach (DataRow linha in dataTableProduto.Rows)
                {
                    //Criar um produto vazio - Colocar os dados da linha nele - Adicionar ele na coleção
                    Produto_DTO produto_DTO = new Produto_DTO();
                    produto_DTO.QUANT_PROD = Convert.ToInt32(linha["QUANT_PROD"]);

                    produto_Colecao.Add(produto_DTO);
                }

                return produto_Colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel carregar quantidade do produto." + ex.Message);
            }
        }

        public Produto_Colecao listarIdsProdutos()
        {
            try
            {
                //Criar uma coleção nova de clientes (aqui está vazia)
                Produto_Colecao produto_Colecao = new Produto_Colecao();

                acessoBancoDadosSqlServer.LimparParametros();

                //Data = Dados e Table=Tabela
                DataTable dataTableProduto = acessoBancoDadosSqlServer.ExecutarConsulta(CommandType.Text,
                    "SELECT ID_PRODUTO FROM ESTOQUE_PRODUTOS");

                //Percorrer o DataTable e Transformar em coleção de cliente - Cada Linha do DataTable é um cliente.
                foreach (DataRow linha in dataTableProduto.Rows)
                {
                    //Criar um produto vazio - Colocar os dados da linha nele - Adicionar ele na coleção
                    Produto_DTO produto_DTO = new Produto_DTO();
                    produto_DTO.ID_PRODUTO = Convert.ToInt32(linha["ID_PRODUTO"]);

                    produto_Colecao.Add(produto_DTO);
                }

                return produto_Colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel listar todos ids dos produtos." + ex.Message);
            }
        }

        public Produto_Colecao listarNomesProdutos()
        {
            try
            {
                //Criar uma coleção nova de clientes (aqui está vazia)
                Produto_Colecao produto_Colecao = new Produto_Colecao();

                acessoBancoDadosSqlServer.LimparParametros();

                //Data = Dados e Table=Tabela
                DataTable dataTableProduto = acessoBancoDadosSqlServer.ExecutarConsulta(CommandType.Text,
                    "SELECT NOME_PRODUTO FROM ESTOQUE_PRODUTOS");

                //Percorrer o DataTable e Transformar em coleção de cliente - Cada Linha do DataTable é um cliente.
                foreach (DataRow linha in dataTableProduto.Rows)
                {
                    //Criar um produto vazio - Colocar os dados da linha nele - Adicionar ele na coleção
                    Produto_DTO produto_DTO = new Produto_DTO();
                    produto_DTO.NOME_PRODUTO = Convert.ToString(linha["NOME_PRODUTO"]);

                    produto_Colecao.Add(produto_DTO);
                }

                return produto_Colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel listar todos nomes dos produtos." + ex.Message);
            }
        }
    }
}