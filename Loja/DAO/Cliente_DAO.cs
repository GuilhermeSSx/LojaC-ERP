using Loja.AcessoBancoDados;
using Loja.DTO;
using System;
using System.Data;

namespace Loja.DAO
{
    public class Cliente_DAO
    {
        //instanciar = criar um novo objeto baseado em um modelo.
        private AcessoBancoDadosSqlServer acessoBancoDadosSqlServer = new AcessoBancoDadosSqlServer();

        public string CadastrarCliente(Cliente_DTO cliente_DTO)
        {
            try
            {
                acessoBancoDadosSqlServer.LimparParametros();
                acessoBancoDadosSqlServer.AdicionarParametros("@NOME_CLIENTE", cliente_DTO.NOME_CLIENTE);
                acessoBancoDadosSqlServer.AdicionarParametros("@ENDERECO", cliente_DTO.ENDERECO);
                acessoBancoDadosSqlServer.AdicionarParametros("@BAIRRO", cliente_DTO.BAIRRO);
                acessoBancoDadosSqlServer.AdicionarParametros("@NUMERO", cliente_DTO.NUMERO);
                acessoBancoDadosSqlServer.AdicionarParametros("@CPF", cliente_DTO.CPF);
                acessoBancoDadosSqlServer.AdicionarParametros("@CELULAR", cliente_DTO.CELULAR);
                acessoBancoDadosSqlServer.AdicionarParametros("@RG", cliente_DTO.RG);
                string ID_CLIENTE = acessoBancoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspClienteInserir").ToString();

                return ID_CLIENTE;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string AlterarCliente(Cliente_DTO cliente_DTO)
        {
            try
            {
                acessoBancoDadosSqlServer.LimparParametros();
                acessoBancoDadosSqlServer.AdicionarParametros("@ID_CLIENTE", cliente_DTO.ID_CLIENTE);
                acessoBancoDadosSqlServer.AdicionarParametros("@NOME_CLIENTE", cliente_DTO.NOME_CLIENTE);
                acessoBancoDadosSqlServer.AdicionarParametros("@ENDERECO", cliente_DTO.ENDERECO);
                acessoBancoDadosSqlServer.AdicionarParametros("@BAIRRO", cliente_DTO.BAIRRO);
                acessoBancoDadosSqlServer.AdicionarParametros("@NUMERO", cliente_DTO.NUMERO);
                acessoBancoDadosSqlServer.AdicionarParametros("@CPF", cliente_DTO.CPF);
                acessoBancoDadosSqlServer.AdicionarParametros("@CELULAR", cliente_DTO.CELULAR);
                acessoBancoDadosSqlServer.AdicionarParametros("@RG", cliente_DTO.RG);
                string ID_CLIENTE = acessoBancoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspClienteAlterar").ToString();

                return ID_CLIENTE;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string ExcluirCliente(Cliente_DTO cliente_DTO)
        {
            try
            {
                acessoBancoDadosSqlServer.LimparParametros();
                acessoBancoDadosSqlServer.AdicionarParametros("@ID_CLIENTE", cliente_DTO.ID_CLIENTE);
                string ID_CLIENTE = acessoBancoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspClienteExcluir").ToString();

                return ID_CLIENTE;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Cliente_Colecao ConsultarPorNome(string NOME)
        {
            try
            {
                //Criar uma coleção nova de clientes (aqui está vazia)
                Cliente_Colecao cliente_Colecao = new Cliente_Colecao();

                acessoBancoDadosSqlServer.LimparParametros();
                acessoBancoDadosSqlServer.AdicionarParametros("@NOME_CLIENTE", NOME);

                //Data = Dados e Table=Tabela
                DataTable dataTableCliente = acessoBancoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspClienteConsultarPorNome");

                //Percorrer o DataTable e Transformar em coleção de cliente - Cada Linha do DataTable é um cliente.
                foreach (DataRow linha in dataTableCliente.Rows)
                {
                    //Criar um cliente vazio - Colocar os dados da linha nele - Adicionar ele na coleção
                    Cliente_DTO cliente_DTO = new Cliente_DTO();
                    cliente_DTO.ID_CLIENTE = Convert.ToInt32(linha["ID_CLIENTE"]);
                    cliente_DTO.NOME_CLIENTE = Convert.ToString(linha["NOME_CLIENTE"]);
                    cliente_DTO.ENDERECO = Convert.ToString(linha["ENDERECO"]);
                    cliente_DTO.BAIRRO = Convert.ToString(linha["BAIRRO"]);
                    cliente_DTO.NUMERO = Convert.ToInt32(linha["NUMERO"]);
                    cliente_DTO.CPF = Convert.ToString(linha["CPF"]);
                    cliente_DTO.CELULAR = Convert.ToInt64(linha["CELULAR"]);
                    cliente_DTO.RG = Convert.ToInt32(linha["RG"]);

                    cliente_Colecao.Add(cliente_DTO);
                }

                return cliente_Colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel consultar o cliente por nome." + ex.Message);
            }
        }

        public Cliente_Colecao ContasReceberMes(string DATA_MES_ANO)
        {
            try
            {
                //Criar uma coleção nova de clientes (aqui está vazia)
                Cliente_Colecao cliente_Colecao = new Cliente_Colecao();

                acessoBancoDadosSqlServer.LimparParametros();
                acessoBancoDadosSqlServer.AdicionarParametros("@DATA_MES_ANO", DATA_MES_ANO);

                //Data = Dados e Table=Tabela
                DataTable dataTableCliente = acessoBancoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspContasReceberMes");

                //Percorrer o DataTable e Transformar em coleção de cliente - Cada Linha do DataTable é um cliente.
                foreach (DataRow linha in dataTableCliente.Rows)
                {
                    //Criar um cliente vazio - Colocar os dados da linha nele - Adicionar ele na coleção
                    Cliente_DTO cliente_DTO = new Cliente_DTO();
                    cliente_DTO.NOME_CLIENTE = Convert.ToString(linha["NOME_CLIENTE"]);
                    cliente_DTO.VALOR_PARCELA = Convert.ToDecimal(linha["VALOR_PARCELA"]);
                    cliente_DTO.DATA_PARCELAS = Convert.ToDateTime(linha["DATA_PARCELAS"]);

                    cliente_Colecao.Add(cliente_DTO);
                }

                return cliente_Colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel carregar os dados dos clientes." + ex.Message);
            }
        }

        public Cliente_Colecao ContasVencidas(string DATA_ATUAL)
        {
            try
            {
                //Criar uma coleção nova de clientes (aqui está vazia)
                Cliente_Colecao cliente_Colecao = new Cliente_Colecao();

                acessoBancoDadosSqlServer.LimparParametros();
                acessoBancoDadosSqlServer.AdicionarParametros("@DATA_ATUAL", DATA_ATUAL);

                //Data = Dados e Table=Tabela
                DataTable dataTableCliente = acessoBancoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure, "uspContasVencidas");

                //Percorrer o DataTable e Transformar em coleção de cliente - Cada Linha do DataTable é um cliente.
                foreach (DataRow linha in dataTableCliente.Rows)
                {
                    //Criar um cliente vazio - Colocar os dados da linha nele - Adicionar ele na coleção
                    Cliente_DTO cliente_DTO = new Cliente_DTO();
                    cliente_DTO.NOME_CLIENTE = Convert.ToString(linha["NOME_CLIENTE"]);
                    cliente_DTO.VALOR_PARCELA = Convert.ToDecimal(linha["VALOR_PARCELA"]);
                    cliente_DTO.DATA_PARCELAS = Convert.ToDateTime(linha["DATA_PARCELAS"]);

                    cliente_Colecao.Add(cliente_DTO);
                }

                return cliente_Colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel carregar os dados dos clientes." + ex.Message);
            }
        }
    }
}