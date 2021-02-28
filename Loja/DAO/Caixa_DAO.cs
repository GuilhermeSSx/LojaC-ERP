using Loja.AcessoBancoDados;
using Loja.DTO;
using System;
using System.Data;

namespace Loja.DAO
{
    class Caixa_DAO
    {
        //instanciar = criar um novo objeto baseado em um modelo.
        private AcessoBancoDadosSqlServer acessoBancoDadosSqlServer = new AcessoBancoDadosSqlServer();

        public string reforcoCaixa(Caixa_DTO caixa_DTO)
        {
            try
            {
                acessoBancoDadosSqlServer.LimparParametros();
                acessoBancoDadosSqlServer.AdicionarParametros("@SALDO_REFORCO", caixa_DTO.SALDO_REFORCO);
                acessoBancoDadosSqlServer.AdicionarParametros("@USUARIO", caixa_DTO.USUARIO);
                string SALDO_REFORCO = acessoBancoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspReforcoCaixa").ToString();

                return SALDO_REFORCO;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string sangriaCaixa(Caixa_DTO caixa_DTO)
        {
            try
            {
                acessoBancoDadosSqlServer.LimparParametros();
                acessoBancoDadosSqlServer.AdicionarParametros("@SALDO_SANGRIA", caixa_DTO.SALDO_SANGRIA);
                acessoBancoDadosSqlServer.AdicionarParametros("@USUARIO", caixa_DTO.USUARIO);
                string SALDO_SANGRIA = acessoBancoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspSangriaCaixa").ToString();

                return SALDO_SANGRIA;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string devolucaoDinheiroCliente(Caixa_DTO caixa_DTO)
        {
            try
            {
                acessoBancoDadosSqlServer.LimparParametros();
                acessoBancoDadosSqlServer.AdicionarParametros("@VALOR_DEVOLUCAO", caixa_DTO.VALOR_DEVOLUCAO);
                acessoBancoDadosSqlServer.AdicionarParametros("@NOME_CLIENTE", caixa_DTO.NOME_CLIENTE);
                acessoBancoDadosSqlServer.AdicionarParametros("@USUARIO", caixa_DTO.USUARIO);
                string VALOR_DEVOLUCAO = acessoBancoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspDevolucaoDinheiroCliente").ToString();

                return VALOR_DEVOLUCAO;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


    }
}
