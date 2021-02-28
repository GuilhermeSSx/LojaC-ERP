using Loja.AcessoBancoDados;
using Loja.DTO;
using System;
using System.Data;

namespace Loja.DAO
{
    internal class Fluxo_Caixa_DAO
    {
        //instanciar = criar um novo objeto baseado em um modelo.
        private AcessoBancoDadosSqlServer acessoBancoDadosSqlServer = new AcessoBancoDadosSqlServer();

        public Fluxo_Caixa_Colecao consultarFluxoCaixa(DateTime dataInicial, DateTime dataFinal)
        {
            try
            {
                Fluxo_Caixa_Colecao fluxo_Caixa_Colecao = new Fluxo_Caixa_Colecao();

                acessoBancoDadosSqlServer.LimparParametros();
                acessoBancoDadosSqlServer.AdicionarParametros("@DATA_INICIAL", dataInicial);
                acessoBancoDadosSqlServer.AdicionarParametros("@DATA_FINAL", dataFinal);

                //Data = Dados e Table=Tabela
                DataTable dataTableFluxoCaixa = acessoBancoDadosSqlServer.ExecutarConsulta(CommandType.StoredProcedure,
                    "uspFluxoCaixaPorData");

                foreach (DataRow linha in dataTableFluxoCaixa.Rows)
                {
                    Fluxo_Caixa_DTO fluxo_Caixa_DTO = new Fluxo_Caixa_DTO();
                    fluxo_Caixa_DTO.OPERACAO = Convert.ToString(linha["OPERACAO"]);
                    fluxo_Caixa_DTO.PRODUTO_PEDIDO = Convert.ToString(linha["PRODUTO_PEDIDO"]);
                    fluxo_Caixa_DTO.VALOR = Convert.ToDecimal(linha["VALOR"]);
                    fluxo_Caixa_DTO.DATA_HORA = Convert.ToDateTime(linha["DATA_HORA"]);
                    fluxo_Caixa_DTO.USUARIO = Convert.ToString(linha["USUARIO"]);

                    fluxo_Caixa_Colecao.Add(fluxo_Caixa_DTO);
                }

                return fluxo_Caixa_Colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel listar o Fluxo de Caixa." + ex.Message);
            }
        }
    }
}