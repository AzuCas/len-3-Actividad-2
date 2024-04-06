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
    public partial class FormOperaciones : Form
    {
        public FormOperaciones()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtno1.Clear();
            txtno2.Clear();
        }
        double no1, no2;

        private void btnsuma_Click(object sender, EventArgs e)
        {
            double suma;
            no1 = Convert.ToDouble(txtno1.Text);
            no2 = Convert.ToDouble(txtno2.Text);

            suma = no1 + no2;

            MessageBox.Show(" La suma de tus números es: " + suma);
        }

        private void btnresta_Click(object sender, EventArgs e)
        {
            double resta;
            no1 = Convert.ToDouble(txtno1.Text);
            no2 = Convert.ToDouble(txtno2.Text);

            resta = no1 - no2;

            MessageBox.Show(" La resta de tus números es: " + resta);
        }

        private void btnmultiplicar_Click(object sender, EventArgs e)
        {
            double multiplicacion;
            no1 = Convert.ToDouble(txtno1.Text);
            no2 = Convert.ToDouble(txtno2.Text);

            multiplicacion = no1 * no2;

            MessageBox.Show(" La multiplicación de tus números es: " + multiplicacion);
        }

        private void btndividir_Click(object sender, EventArgs e)
        {
            double division;
            no1 = Convert.ToDouble(txtno1.Text);
            no2 = Convert.ToDouble(txtno2.Text);

            division = no1 / no2;

            MessageBox.Show(" La división de tus números es: " + division);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form regresar = new FormMenu();
            regresar.Show();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
