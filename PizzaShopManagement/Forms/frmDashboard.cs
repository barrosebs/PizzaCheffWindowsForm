using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaShopManagement.Forms
{
    public partial class frmDashboard : Form
    {
        int PanelWidth;
        bool isCollapsed;

        public frmDashboard()
        {
            InitializeComponent();
            timerTimer.Start();
            PanelWidth = panelLeft.Width;
            isCollapsed = false;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (isCollapsed)
            {
                panelLeft.Width = panelLeft.Width + 10;
                if (panelLeft.Width >= PanelWidth)
                {
                    timer1.Stop();
                    isCollapsed = false;
                    this.Refresh();
                }
            }
            else
            {
                panelLeft.Width = panelLeft.Width - 10;
                if (panelLeft.Width <= 70)
                {
                    timer1.Stop();
                    isCollapsed = true;
                    this.Refresh();
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void moveSidePanel(Control btn)
        {
            panelSide.Top = btn.Top;
            panelSide.Height = btn.Height;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnHome);
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnCadastro);

        }

        private void btnVendas_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnVendas);

        }

        private void btnRelatorios_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnRelatorios);

        }

        private void btnFerramentas_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnFerramentas);

        }

        private void timerTimer_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblTime.Text = dt.ToString("HH:MM:ss");
        }
    }
}
