namespace len_3_Actividad_2
{
    partial class contrasena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(contrasena));
            label1 = new Label();
            label2 = new Label();
            txtcontrasena = new TextBox();
            btningresar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Ink Free", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 78);
            label1.Name = "label1";
            label1.Size = new Size(703, 26);
            label1.TabIndex = 0;
            label1.Text = "Para poder hacer uso de este sofware debes de ingresar la contraseña";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Impact", 14.25F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(157, 187);
            label2.Name = "label2";
            label2.Size = new Size(107, 23);
            label2.TabIndex = 1;
            label2.Text = "Contraseña:";
            // 
            // txtcontrasena
            // 
            txtcontrasena.Location = new Point(270, 187);
            txtcontrasena.Name = "txtcontrasena";
            txtcontrasena.PasswordChar = '*';
            txtcontrasena.Size = new Size(204, 23);
            txtcontrasena.TabIndex = 3;
            // 
            // btningresar
            // 
            btningresar.BackColor = Color.FromArgb(255, 192, 128);
            btningresar.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btningresar.Location = new Point(344, 276);
            btningresar.Name = "btningresar";
            btningresar.Size = new Size(174, 56);
            btningresar.TabIndex = 4;
            btningresar.Text = "Ingresar";
            btningresar.UseVisualStyleBackColor = false;
            btningresar.Click += btningresar_Click;
            // 
            // contrasena
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btningresar);
            Controls.Add(txtcontrasena);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "contrasena";
            Text = "contraseña";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtcontrasena;
        private Button btningresar;
    }
}