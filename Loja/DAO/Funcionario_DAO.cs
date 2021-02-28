using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Loja.AcessoBancoDados;
using Loja.DTO;

namespace Loja.DAO
{
    public class Funcionario_DAO
    {
        //instanciar = criar um novo objeto baseado em um modelo.
        private AcessoBancoDadosSqlServer acessoBancoDadosSqlServer = new AcessoBancoDadosSqlServer();


        public string CadastrarFuncionario(Funcionario_DTO funcionario_DTO)
        {
            try
            {
                acessoBancoDadosSqlServer.LimparParametros();
                acessoBancoDadosSqlServer.AdicionarParametros("@NOME_USUARIO", funcionario_DTO.NOME_USUARIO);
                acessoBancoDadosSqlServer.AdicionarParametros("@SENHA_USUARIO", funcionario_DTO.SENHA_USUARIO);
                string ID_USUARIO = acessoBancoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspCriarFuncionarios").ToString();

                return ID_USUARIO;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }


        public string AlterarFuncionario(Funcionario_DTO funcionario_DTO)
        {
            try
            {
                acessoBancoDadosSqlServer.LimparParametros();
                acessoBancoDadosSqlServer.AdicionarParametros("@ID_USUARIO", funcionario_DTO.ID_USUARIO);
                acessoBancoDadosSqlServer.AdicionarParametros("@NOME_USUARIO", funcionario_DTO.NOME_USUARIO);
                acessoBancoDadosSqlServer.AdicionarParametros("@SENHA_USUARIO", funcionario_DTO.SENHA_USUARIO);
                string ID_USUARIO = acessoBancoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspFuncionarioAlterar").ToString();

                return ID_USUARIO;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }









        public string ExcluirFuncionario(Funcionario_DTO funcionario_DTO)
        {
            try
            {
                acessoBancoDadosSqlServer.LimparParametros();
                acessoBancoDadosSqlServer.AdicionarParametros("@ID_USUARIO", funcionario_DTO.ID_USUARIO);
                string ID_USUARIO = acessoBancoDadosSqlServer.ExecutarManipulacao(CommandType.StoredProcedure, "uspFuncionarioExcluir").ToString();

                return ID_USUARIO;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }



        public Funcionario_Colecao carregarFuncionarios()
        {
            try
            {
                Funcionario_Colecao funcionario_Colecao = new Funcionario_Colecao();

                acessoBancoDadosSqlServer.LimparParametros();

                //Data = Dados e Table=Tabela
                DataTable dataTableFuncionarios = acessoBancoDadosSqlServer.ExecutarConsulta(CommandType.Text,
                    "SELECT ID_USUARIO, NOME_USUARIO, SENHA_USUARIO FROM USUARIO WHERE NIVEL_ACESSO = '3'");

                foreach (DataRow linha in dataTableFuncionarios.Rows)
                {
                    Funcionario_DTO funcionario_DTO = new Funcionario_DTO();
                    funcionario_DTO.ID_USUARIO = Convert.ToInt32(linha["ID_USUARIO"]);
                    funcionario_DTO.NOME_USUARIO = Convert.ToString(linha["NOME_USUARIO"]);
                    funcionario_DTO.SENHA_USUARIO = Convert.ToString(linha["SENHA_USUARIO"]);

                    funcionario_Colecao.Add(funcionario_DTO);
                }

                return funcionario_Colecao;
            }
            catch (Exception ex)
            {
                throw new Exception("Não foi possivel carregar a lista de funcionarios" + ex.Message);
            }
        }




    }
}
