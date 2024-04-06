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
    public partial class FormSaludo : Form
    {
        public FormSaludo()
        {
            InitializeComponent();
        }

        private void button1saludar_Click(object sender, EventArgs e)
        {
            string nombre = textBoxnombre.Text;
            MessageBox.Show(" Hola " + nombre + " ¿qué tal tu día?");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form regresar = new FormMenu();
            regresar.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
