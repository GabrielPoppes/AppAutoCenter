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
            FrmLoading frmLoading = new FrmLoading();

            frmLoading.Close();
        }
    }
}
