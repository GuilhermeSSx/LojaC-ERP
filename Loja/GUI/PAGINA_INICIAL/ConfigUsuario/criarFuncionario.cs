﻿using Loja.DAO;
using Loja.DTO;
using System;
using System.Windows.Forms;

namespace Loja.GUI.PAGINA_INICIAL.Configuracoes
{
    public partial class crudFuncionario : Form
    {

        public crudFuncionario()
        {
            InitializeComponent();
        }

        private void crudFuncionario_Load(object sender, EventArgs e)
        {
            tbNomeFuncionario.Select();
        }

        private void ibtnSalvarUsuario_Click(object sender, EventArgs e)
        {
            if (tbNomeFuncionario.TextLength < 5)
            {
                MessageBox.Show("Digite um nome de funcionario maior que 5 caracteres");
            }
            else
            {
                if (tbSenhaFuncionario.TextLength < 6)
                {
                    MessageBox.Show("Digite uma senha maior que 6 caracteres");
                }
                else
                {
                    Funcionario_DTO funcionario_DTO = new Funcionario_DTO();

                    funcionario_DTO.NOME_USUARIO = tbNomeFuncionario.Text;
                    funcionario_DTO.SENHA_USUARIO = tbSenhaFuncionario.Text;

                    Funcionario_DAO funcionario_DAO = new Funcionario_DAO();
                    string retorno = funcionario_DAO.CadastrarFuncionario(funcionario_DTO);

                    try
                    {
                        int id_usuario = Convert.ToInt32(retorno);

                        DialogResult resultado = MessageBox.Show("Criado Funcionário: " + tbNomeFuncionario.Text);
                        this.DialogResult = DialogResult.Yes;
                    }
                    catch
                    {
                        MessageBox.Show("Não foi possivel criar funcionario" + retorno, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        this.DialogResult = DialogResult.No;
                    }
                }
            }


        }

        private void tbNomeFuncionario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void tbNomeFuncionario_KeyDown(object sender, KeyEventArgs e)
        {
            //Validando se o usuario aperto no teclado Ctrl + V
            if (e.Control && e.KeyValue == 86)
            {
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void tbNomeFuncionario_MouseDown(object sender, MouseEventArgs e)
        {
            //Verificando se usuario clicou com botão direito sobre o textBox
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Botão direito sobre a caixa desabilitado");
            }
        }
    }
}
