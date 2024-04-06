namespace len_3_Actividad_2
{
    partial class FormMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            buttonSaludar = new Button();
            btndatos = new Button();
            btnoperaciones = new Button();
            btnsalir = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonSaludar
            // 
            buttonSaludar.BackColor = Color.FromArgb(255, 192, 192);
            buttonSaludar.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            buttonSaludar.Location = new Point(12, 12);
            buttonSaludar.Name = "buttonSaludar";
            buttonSaludar.Size = new Size(168, 49);
            buttonSaludar.TabIndex = 0;
            buttonSaludar.Text = "Saludar";
            buttonSaludar.UseVisualStyleBackColor = false;
            buttonSaludar.Click += buttonSaludar_Click;
            // 
            // btndatos
            // 
            btndatos.BackColor = Color.FromArgb(192, 192, 255);
            btndatos.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btndatos.Location = new Point(281, 5);
            btndatos.Name = "btndatos";
            btndatos.Size = new Size(170, 56);
            btndatos.TabIndex = 1;
            btndatos.Text = "Datos personales";
            btndatos.UseVisualStyleBackColor = false;
            btndatos.Click += button1_Click;
            // 
            // btnoperaciones
            // 
            btnoperaciones.BackColor = Color.FromArgb(192, 255, 192);
            btnoperaciones.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnoperaciones.Location = new Point(522, 5);
            btnoperaciones.Name = "btnoperaciones";
            btnoperaciones.Size = new Size(216, 54);
            btnoperaciones.TabIndex = 2;
            btnoperaciones.Text = "Operaciones básicas";
            btnoperaciones.UseVisualStyleBackColor = false;
            btnoperaciones.Click += btnoperaciones_Click;
            // 
            // btnsalir
            // 
            btnsalir.BackColor = Color.FromArgb(255, 192, 255);
            btnsalir.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnsalir.Location = new Point(666, 396);
            btnsalir.Name = "btnsalir";
            btnsalir.Size = new Size(105, 42);
            btnsalir.TabIndex = 3;
            btnsalir.Text = "Salir";
            btnsalir.UseVisualStyleBackColor = false;
            btnsalir.Click += btnsalir_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.LAC_2022_victim_and_player_ES_page_0001;
            pictureBox1.Location = new Point(145, 67);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(449, 374);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // FormMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Info;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(btnsalir);
            Controls.Add(btnoperaciones);
            Controls.Add(btndatos);
            Controls.Add(buttonSaludar);
            ForeColor = SystemColors.ActiveCaptionText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormMenu";
            Text = "Menú";
            Load += FormMenu_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonSaludar;
        private Button btndatos;
        private Button btnoperaciones;
        private Button btnsalir;
        private PictureBox pictureBox1;
    }
}
