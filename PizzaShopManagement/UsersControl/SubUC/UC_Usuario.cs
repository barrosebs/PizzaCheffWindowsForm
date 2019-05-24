using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaShopManagement.UsersControl.SubUC
{
    public partial class UC_Usuario : UserControl
    {
        public UC_Usuario()
        {
            InitializeComponent();
            dateAtualiza();
        }


        private void textBox3_Leave(object sender, EventArgs e)
        {

            bool valida = txtUEmail.Text.Contains("@") && txtUEmail.Text.Contains(".com");
            if (valida == false)
            {
                MessageBox.Show("Favor verificar campo Email", e.ToString());
            }

        }

        private void dateAtualiza()
        {
            string Dia = DateTime.Now.Day.ToString("d2");
            string Mes = DateTime.Now.Month.ToString("d2");
            double Ano = DateTime.Now.Year;

            mtxtUDtCadastro.Text = Dia + Mes + Ano.ToString();
        }

        private void picFotoUser_DragDrop(object sender, DragEventArgs e)
        {
            MessageBox.Show("IMagem inserido no servidor com sucesso!!");
        }
    }
}
