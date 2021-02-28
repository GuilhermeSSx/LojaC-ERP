using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loja.DTO
{
    public class Funcionario_DTO
    {
        public int ID_USUARIO { get; set; }
        public string NOME_USUARIO { get; set; }
        public string SENHA_USUARIO { get; set; }
        public int NIVEL_ACESSO { get; set; }
    }
}
