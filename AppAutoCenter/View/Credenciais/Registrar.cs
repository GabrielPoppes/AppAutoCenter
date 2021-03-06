using AppAutoCenter.DAL;
using AppAutoCenter.Models;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace AppAutoCenter.View.Credenciais
{
    public partial class Registrar : Form
    {
        public string caminhoFoto = "";
        private Funcionario funcionario = new Funcionario();
        private FuncionarioDAL funcionarioDal = new FuncionarioDAL();
        public Registrar()
        {
            InitializeComponent();
            lblFotoSelecionada.Hide(); // Escondendo a label "Foto selecionada" - Só aparece após selecionar uma foto
        }

        #region Evento click do botão voltar - Retorna para a form Entrar
        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Entrar frmEntrar = new Entrar();
            frmEntrar.Show();
            this.Close();
        }
        #endregion

        #region Evento TextChanged do campo senha (colocar o asterisco quando a senha é digitada)
        private void TxbSenha_TextChanged(object sender, EventArgs e)
        {
            TxbSenha.PasswordChar = '*';
        }
        #endregion

        #region Evento TextChanged do campo confirmar senha (colocar o asterisco quando a senha é digitada)
        private void TxbConfirmarSenha_TextChanged(object sender, EventArgs e)
        {
            TxbConfirmarSenha.PasswordChar = '*';
        }
        #endregion

        #region Evento Clicked no botão Registrar
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            Regex rgEmail = new Regex(@"^[A-Za-z0-9](([_\.\-]?[a-zA-Z0-9]+)*)@([A-Za-z0-9]+)(([\.\-]?[a-zA-Z0-9]+)*)\.([A-Za-z]{2,})$");
            Regex rgCelular = new Regex(@"^(\([0-9]{2}\))\s([9]{1})?([0-9]{4})-([0-9]{4})$");
            if (rgEmail.IsMatch(TxbEmail.Text)) // Checando se o e-mail digitado é válido através do regex
            {
                Match match = rgCelular.Match(TxbCelular.Text);
                if (match.Success) // Checando se o celular informado é válido
                {
                    if (TxbNome.Text != "")
                    {
                        if (TxbSenha.Text != "")
                        {
                            if (TxbSenha.Text == TxbConfirmarSenha.Text)
                            {
                                // Passou por todas as condições - Colocar o código de registro aqui
                                funcionario.Nome = TxbNome.Text;
                                funcionario.Email = TxbEmail.Text;
                                funcionario.Celular = TxbCelular.Text;
                                funcionario.Senha = TxbSenha.Text;
                                funcionario.CaminhoFoto = caminhoFoto;
                                funcionarioDal.Salvar(funcionario);
                                MessageBox.Show("Funcionário cadastrado com sucesso!");
                                LimparCampos();
                            }
                            else
                            {
                                MessageBox.Show("As senhas informadas devem ser iguais!", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            MessageBox.Show("Digite uma senha!", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        }
                    }
                    else
                    {
                        MessageBox.Show("Digite seu nome!", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("O celular digitado é inválido!", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            else
            {
                MessageBox.Show("O e-mail digitado é inválido!", "Mensagem de erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        #region Método para limpar todos os campos após a finalização do registro
        private void LimparCampos()
        {
            TxbNome.Clear();
            TxbEmail.Clear();
            TxbCelular.Clear();
            TxbSenha.Clear();
            TxbConfirmarSenha.Clear();
            lblFotoSelecionada.Hide();
            PicFotoSelecionada.Hide();
        }
        #endregion

        #region Evento do click no botão "Selecionar foto" - onde seleciona a imagem do perfil
        private void BtnSelecionarFotoPerfil_Click(object sender, EventArgs e)
        {
            var openFile = new OpenFileDialog();
            openFile.Filter = "Arquivos de imagens jpg e png *.jpg | *.png";
            openFile.Multiselect = false;

            if (openFile.ShowDialog() == DialogResult.OK)
                caminhoFoto = openFile.FileName;

            if (caminhoFoto != "")
            {
                PicFotoSelecionada.Load(caminhoFoto);
                lblFotoSelecionada.Show();
                PicFotoSelecionada.Show();
            }
        }
        #endregion
    }
}
