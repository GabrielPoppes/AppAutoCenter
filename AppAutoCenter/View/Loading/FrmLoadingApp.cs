using AppAutoCenter.View.Credenciais;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace AppAutoCenter.View.Loading
{
    public partial class FrmLoadingApp : Form
    {
        public FrmLoadingApp()
        {
            InitializeComponent();
        }

        #region Evento Load da form
        private void FrmLoadingApp_Load(object sender, EventArgs e)
        {
            PanelConectando.Size = new Size(PanelConectando.Size.Width, 30);

        }
        #endregion

        #region Evento Timer
        int panelConectando_y = 30;
        int waiter = 0;
        private void TimerLoading_Tick(object sender, EventArgs e)
        {
            waiter++;
            if (waiter > 150)
            {
                LblConectando.Hide();
                panelConectando_y += 6;
                PanelConectando.Size = new Size(PanelConectando.Size.Width, panelConectando_y);
                if (panelConectando_y > 450)
                {
                    PanelAutoCenter.Hide();
                    TimerLoading.Enabled = false;
                }
            }
        }
        #endregion

        #region Evento click na imagem do carro (abre a form de login)
        private void PicCar_Click(object sender, EventArgs e)
        {
            Entrar frmEntrar = new Entrar();
            frmEntrar.Show();
            this.Hide();
        }
        #endregion

        #region Evento click na label Abrir App (abre a form de login)
        private void LblAbrirApp_Click(object sender, EventArgs e)
        {
            Entrar frmEntrar = new Entrar();
            frmEntrar.Show();
            this.Hide();
        }
        #endregion
    }
}
