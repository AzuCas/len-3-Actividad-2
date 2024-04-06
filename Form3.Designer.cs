namespace len_3_Actividad_2
{
    partial class FormDatos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDatos));
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btndatos = new Button();
            label6 = new Label();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            dateTimePicker1 = new DateTimePicker();
            textBox1 = new TextBox();
            label3 = new Label();
            txtbdireccion = new TextBox();
            label2 = new Label();
            txtbapellido = new TextBox();
            txtbnombre = new TextBox();
            label1 = new Label();
            lb1nombre = new Label();
            tabPage2 = new TabPage();
            btnclinicos = new Button();
            radioButton12 = new RadioButton();
            radioButton11 = new RadioButton();
            label13 = new Label();
            textBox5 = new TextBox();
            label12 = new Label();
            label11 = new Label();
            radioButton10 = new RadioButton();
            radioButton9 = new RadioButton();
            label10 = new Label();
            textBox4 = new TextBox();
            radioButton8 = new RadioButton();
            radioButton7 = new RadioButton();
            label9 = new Label();
            textBox3 = new TextBox();
            comboBox3 = new ComboBox();
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            textBox2 = new TextBox();
            comboBox2 = new ComboBox();
            label8 = new Label();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            label7 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Font = new Font("Segoe Print", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.Location = new Point(28, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(585, 426);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btndatos);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(radioButton2);
            tabPage1.Controls.Add(radioButton1);
            tabPage1.Controls.Add(comboBox1);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(dateTimePicker1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtbdireccion);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtbapellido);
            tabPage1.Controls.Add(txtbnombre);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(lb1nombre);
            tabPage1.Location = new Point(4, 32);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(577, 390);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Datos personales";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btndatos
            // 
            btndatos.BackColor = Color.FromArgb(255, 192, 255);
            btndatos.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btndatos.Location = new Point(420, 337);
            btndatos.Name = "btndatos";
            btndatos.Size = new Size(109, 40);
            btndatos.TabIndex = 15;
            btndatos.Text = "regresar";
            btndatos.UseVisualStyleBackColor = false;
            btndatos.Click += btndatos_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(36, 354);
            label6.Name = "label6";
            label6.Size = new Size(39, 23);
            label6.TabIndex = 14;
            label6.Text = "Sexo";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(120, 362);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(67, 27);
            radioButton2.TabIndex = 13;
            radioButton2.TabStop = true;
            radioButton2.Text = "mujer";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(120, 337);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(78, 27);
            radioButton1.TabIndex = 12;
            radioButton1.TabStop = true;
            radioButton1.Text = "hombre";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.AllowDrop = true;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "soltera(o)", "casada(o)", "divorciada(o)", "viuda(o)", "unión libre" });
            comboBox1.Location = new Point(15, 296);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 31);
            comboBox1.TabIndex = 11;
            comboBox1.Text = "Estado civil";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(19, 299);
            label5.Name = "label5";
            label5.Size = new Size(0, 23);
            label5.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(15, 232);
            label4.Name = "label4";
            label4.Size = new Size(148, 23);
            label4.TabIndex = 9;
            label4.Text = "Fecha de nacimiento";
            label4.Click += label4_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(15, 260);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 30);
            dateTimePicker1.TabIndex = 8;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(15, 192);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 30);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(17, 164);
            label3.Name = "label3";
            label3.Size = new Size(57, 23);
            label3.TabIndex = 6;
            label3.Text = "Ciudad";
            // 
            // txtbdireccion
            // 
            txtbdireccion.Location = new Point(15, 129);
            txtbdireccion.Name = "txtbdireccion";
            txtbdireccion.Size = new Size(416, 30);
            txtbdireccion.TabIndex = 5;
            txtbdireccion.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 111);
            label2.Name = "label2";
            label2.Size = new Size(72, 23);
            label2.TabIndex = 4;
            label2.Text = "Dirección";
            // 
            // txtbapellido
            // 
            txtbapellido.Location = new Point(15, 74);
            txtbapellido.Name = "txtbapellido";
            txtbapellido.Size = new Size(175, 30);
            txtbapellido.TabIndex = 3;
            // 
            // txtbnombre
            // 
            txtbnombre.Location = new Point(15, 21);
            txtbnombre.Name = "txtbnombre";
            txtbnombre.Size = new Size(200, 30);
            txtbnombre.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 56);
            label1.Name = "label1";
            label1.Size = new Size(63, 23);
            label1.TabIndex = 1;
            label1.Text = "Apellido";
            // 
            // lb1nombre
            // 
            lb1nombre.AutoSize = true;
            lb1nombre.Location = new Point(15, 3);
            lb1nombre.Name = "lb1nombre";
            lb1nombre.Size = new Size(62, 23);
            lb1nombre.TabIndex = 0;
            lb1nombre.Text = "Nombre";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnclinicos);
            tabPage2.Controls.Add(radioButton12);
            tabPage2.Controls.Add(radioButton11);
            tabPage2.Controls.Add(label13);
            tabPage2.Controls.Add(textBox5);
            tabPage2.Controls.Add(label12);
            tabPage2.Controls.Add(label11);
            tabPage2.Controls.Add(radioButton10);
            tabPage2.Controls.Add(radioButton9);
            tabPage2.Controls.Add(label10);
            tabPage2.Controls.Add(textBox4);
            tabPage2.Controls.Add(radioButton8);
            tabPage2.Controls.Add(radioButton7);
            tabPage2.Controls.Add(label9);
            tabPage2.Controls.Add(textBox3);
            tabPage2.Controls.Add(comboBox3);
            tabPage2.Controls.Add(radioButton6);
            tabPage2.Controls.Add(radioButton5);
            tabPage2.Controls.Add(textBox2);
            tabPage2.Controls.Add(comboBox2);
            tabPage2.Controls.Add(label8);
            tabPage2.Controls.Add(radioButton4);
            tabPage2.Controls.Add(radioButton3);
            tabPage2.Controls.Add(label7);
            tabPage2.Location = new Point(4, 32);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(577, 390);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Datos clínicos";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnclinicos
            // 
            btnclinicos.BackColor = Color.FromArgb(128, 128, 255);
            btnclinicos.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnclinicos.Location = new Point(367, 341);
            btnclinicos.Name = "btnclinicos";
            btnclinicos.Size = new Size(118, 34);
            btnclinicos.TabIndex = 23;
            btnclinicos.Text = "regresar";
            btnclinicos.UseVisualStyleBackColor = false;
            btnclinicos.Click += button2_Click;
            // 
            // radioButton12
            // 
            radioButton12.AutoSize = true;
            radioButton12.Location = new Point(64, 323);
            radioButton12.Name = "radioButton12";
            radioButton12.Size = new Size(44, 27);
            radioButton12.TabIndex = 22;
            radioButton12.Text = "no";
            radioButton12.UseVisualStyleBackColor = true;
            // 
            // radioButton11
            // 
            radioButton11.AutoSize = true;
            radioButton11.Location = new Point(15, 323);
            radioButton11.Name = "radioButton11";
            radioButton11.Size = new Size(37, 27);
            radioButton11.TabIndex = 21;
            radioButton11.Text = "sí";
            radioButton11.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(15, 293);
            label13.Name = "label13";
            label13.Size = new Size(168, 23);
            label13.TabIndex = 20;
            label13.Text = "5.- ¿Padeces depresión?";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(240, 256);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(139, 30);
            textBox5.TabIndex = 19;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(141, 260);
            label12.Name = "label12";
            label12.Size = new Size(104, 23);
            label12.TabIndex = 18;
            label12.Text = "¿qué ejercicio?";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(141, 192);
            label11.Name = "label11";
            label11.Size = new Size(66, 23);
            label11.TabIndex = 17;
            label11.Text = "¿de qué?";
            label11.Click += label11_Click;
            // 
            // radioButton10
            // 
            radioButton10.AutoSize = true;
            radioButton10.Location = new Point(64, 260);
            radioButton10.Name = "radioButton10";
            radioButton10.Size = new Size(44, 27);
            radioButton10.TabIndex = 16;
            radioButton10.Text = "no";
            radioButton10.UseVisualStyleBackColor = true;
            // 
            // radioButton9
            // 
            radioButton9.AutoSize = true;
            radioButton9.Location = new Point(15, 260);
            radioButton9.Name = "radioButton9";
            radioButton9.Size = new Size(37, 27);
            radioButton9.TabIndex = 15;
            radioButton9.Text = "sí";
            radioButton9.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 229);
            label10.Name = "label10";
            label10.Size = new Size(133, 23);
            label10.TabIndex = 14;
            label10.Text = "4.- ¿Haces ejercio?";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(213, 189);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(139, 30);
            textBox4.TabIndex = 13;
            // 
            // radioButton8
            // 
            radioButton8.AutoSize = true;
            radioButton8.Location = new Point(73, 189);
            radioButton8.Name = "radioButton8";
            radioButton8.Size = new Size(44, 27);
            radioButton8.TabIndex = 12;
            radioButton8.Text = "no";
            radioButton8.UseVisualStyleBackColor = true;
            // 
            // radioButton7
            // 
            radioButton7.AutoSize = true;
            radioButton7.Location = new Point(15, 189);
            radioButton7.Name = "radioButton7";
            radioButton7.Size = new Size(37, 27);
            radioButton7.TabIndex = 11;
            radioButton7.Text = "sí";
            radioButton7.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 157);
            label9.Name = "label9";
            label9.Size = new Size(221, 23);
            label9.TabIndex = 10;
            label9.Text = "3.-¿Alguna vez te han operado?";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(346, 119);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(139, 30);
            textBox3.TabIndex = 9;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "latex", "polen", "picaduras de insectos", "ácaros", "moho", "alimentos" });
            comboBox3.Location = new Point(142, 118);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(175, 31);
            comboBox3.TabIndex = 8;
            comboBox3.Text = "alergía que padeces";
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(73, 119);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(44, 27);
            radioButton6.TabIndex = 7;
            radioButton6.Text = "no";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(15, 119);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(37, 27);
            radioButton5.TabIndex = 6;
            radioButton5.Text = "sí";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(346, 47);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(139, 30);
            textBox2.TabIndex = 5;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "migraña", "diabetes", "infección respiratoria", "gastritis", "hipertensión", "otra" });
            comboBox2.Location = new Point(142, 45);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(175, 31);
            comboBox2.TabIndex = 4;
            comboBox2.Text = "enfermedad que padeces";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(15, 89);
            label8.Name = "label8";
            label8.Size = new Size(188, 23);
            label8.TabIndex = 3;
            label8.Text = "2.- ¿Tienes alguna alergía?";
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(73, 46);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(44, 27);
            radioButton4.TabIndex = 2;
            radioButton4.Text = "no";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Checked = true;
            radioButton3.Location = new Point(15, 46);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(37, 27);
            radioButton3.TabIndex = 1;
            radioButton3.TabStop = true;
            radioButton3.Text = "sí";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(15, 18);
            label7.Name = "label7";
            label7.Size = new Size(256, 23);
            label7.TabIndex = 0;
            label7.Text = "1.- ¿Padeces de alguna enfermedad?";
            // 
            // FormDatos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormDatos";
            Text = "Información personal";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtbdireccion;
        private Label label2;
        private TextBox txtbapellido;
        private TextBox txtbnombre;
        private Label label1;
        private Label lb1nombre;
        private TextBox textBox1;
        private Label label3;
        private Label label4;
        private DateTimePicker dateTimePicker1;
        private RadioButton radioButton1;
        private ComboBox comboBox1;
        private Label label5;
        private Button btndatos;
        private Label label6;
        private RadioButton radioButton2;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private Label label7;
        private ComboBox comboBox2;
        private Label label8;
        private Label label10;
        private TextBox textBox4;
        private RadioButton radioButton8;
        private RadioButton radioButton7;
        private Label label9;
        private TextBox textBox3;
        private ComboBox comboBox3;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private TextBox textBox2;
        private Label label11;
        private RadioButton radioButton10;
        private RadioButton radioButton9;
        private Button btnclinicos;
        private RadioButton radioButton12;
        private RadioButton radioButton11;
        private Label label13;
        private TextBox textBox5;
        private Label label12;
    }
}