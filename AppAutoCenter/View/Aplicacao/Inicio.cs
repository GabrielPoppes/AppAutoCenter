using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppAutoCenter.View.Aplicacao
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            EsconderSubMenu();
        }

        #region Método para esconder os sub menus do MENU - Quando a aplicação inicia
        private void EsconderSubMenu()
        {
            panelVeiculos.Visible = false;
            panelVendas.Visible = false;
            PanelCliente.Visible = false;
            panel4.Visible = false;
        }
        #endregion

        #region Método para esconder os MENUS (caso estejam abertos)
        private void EsconderSubMenuClick()
        {
            if (panelVeiculos.Visible == true)
                panelVeiculos.Visible = false;

            if (panelVendas.Visible == true)
                panelVendas.Visible = false;

            if (PanelCliente.Visible == true)
                PanelCliente.Visible = false;

            if (panel4.Visible == true)
                panel4.Visible = false;
        }
        #endregion

        #region Método para exibir os MENUs
        private void ExibirSubMenuClick(Panel subMenu)
        {
            if(subMenu.Visible == false)
            {
                EsconderSubMenu();
                subMenu.Visible = true;
            }

            else
            {
                subMenu.Visible = false;
            }
        }
        #endregion

        #region Click no MENU Veículos
        private void BtnVeiculos_Click(object sender, EventArgs e)
        {
            ExibirSubMenuClick(panelVeiculos);
        }
        #endregion

        #region Click no MENU Cliente
        private void BtnCliente_Click(object sender, EventArgs e)
        {
            ExibirSubMenuClick(PanelCliente);
        }
        #endregion

        #region Click no MENU Vendas

        private void BtnVendas_Click(object sender, EventArgs e)
        {
            ExibirSubMenuClick(panelVendas);

        }
        #endregion

        #region Click no MENU Relatorio

        private void BtnRelatorio_Click(object sender, EventArgs e)
        {
            ExibirSubMenuClick(panel4);
        }
        #endregion
    }
}
