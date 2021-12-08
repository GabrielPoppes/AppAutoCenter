using AppAutoCenter.View.Loading;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAutoCenter.View.Credenciais
{
    public partial class Entrar : Form
    {
        public Entrar()
        {
            InitializeComponent();
            this.ActiveControl = PicLogoAutoCenter; // Quando a aplicação inicia, o foco vai para o logo (inicialmente, estava no TextBox e-mail, então quando iniciava a aplicação, o foco já ia para ele)
        }

        #region Evento Click (quando o usuário clica no campo senha)
        private void TxbSenha_Click(object sender, EventArgs e)
        {
            TxbSenha.Clear();
        }
        #endregion

        #region Evento Click (quando o usuário clica no campo E-mail)
        private void TxbEmail_Click(object sender, EventArgs e)
        {
            TxbEmail.Clear();
        }
        #endregion

        #region Evento TextChanged do campo senha (colocar o asterisco quando a senha é digitada)
        private void TxbSenha_TextChanged(object sender, EventArgs e)
        {
            TxbSenha.PasswordChar = '*';
        }
        #endregion
    }
}
