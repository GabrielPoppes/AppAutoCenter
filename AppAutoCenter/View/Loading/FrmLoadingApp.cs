using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAutoCenter.View.Loading
{
    public partial class FrmLoadingApp : Form
    {
        public FrmLoadingApp()
        {
            InitializeComponent();
        }

        private void FrmLoadingApp_Load(object sender, EventArgs e)
        {
            PanelConectando.Size = new Size(PanelConectando.Size.Width, 30);

        }

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
    }
}
