namespace len_3_Actividad_2
{
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void buttonSaludar_Click(object sender, EventArgs e)
        {
            Form saludar = new FormSaludo();
            saludar.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form datos = new FormDatos();
            datos.Show();
        }

        private void btnoperaciones_Click(object sender, EventArgs e)
        {
            Form operaciones = new FormOperaciones();
            operaciones.Show();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
