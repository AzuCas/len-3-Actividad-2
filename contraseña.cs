using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace len_3_Actividad_2
{
    public partial class contrasena : Form
    {
        public contrasena()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            if (txtcontrasena.Text == "")
            {
                MessageBox.Show("Debe de ingreasar contraseña");

            }

            else if (txtcontrasena.Text == "12345")
            {
                FormMenu formPrincipal = new FormMenu();
                formPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(" Contraseña incorrecta");
                txtcontrasena.Clear();
            }
        }
    }
}
