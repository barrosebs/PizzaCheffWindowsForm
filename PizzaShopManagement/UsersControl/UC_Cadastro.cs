using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzaShopManagement.UsersControl.SubUC;

namespace PizzaShopManagement.UsersControl
{
    public partial class UC_Cadastro : UserControl
    {
        public UC_Cadastro()
        {
            InitializeComponent();
        }

        public void moveSidePanel(Control btn)
        {
            pCadastro.Top = btn.Top;
            pCadastro.Height = btn.Height;
        }

        public void AddControlsToPanel(Control c)
        {
            c.Dock = DockStyle.Fill;
            pCadastro.Controls.Clear();
            pCadastro.Controls.Add(c);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnUsuario);
            UC_Usuario uch = new UC_Usuario();
            AddControlsToPanel(uch);
        }
    }
}
