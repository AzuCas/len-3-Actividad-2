namespace len_3_Actividad_2
{
    partial class FormOperaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOperaciones));
            label1 = new Label();
            btnsuma = new Button();
            txtno1 = new TextBox();
            label2 = new Label();
            txtno2 = new TextBox();
            btnresta = new Button();
            btnmultiplicar = new Button();
            btndividir = new Button();
            button5 = new Button();
            btnregresar = new Button();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(81, 202);
            label1.Name = "label1";
            label1.Size = new Size(35, 16);
            label1.TabIndex = 0;
            label1.Text = "No.1";
            // 
            // btnsuma
            // 
            btnsuma.BackColor = Color.FromArgb(255, 255, 192);
            btnsuma.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnsuma.Location = new Point(100, 270);
            btnsuma.Name = "btnsuma";
            btnsuma.Size = new Size(75, 36);
            btnsuma.TabIndex = 1;
            btnsuma.Text = "suma";
            btnsuma.UseVisualStyleBackColor = false;
            btnsuma.Click += btnsuma_Click;
            // 
            // txtno1
            // 
            txtno1.Location = new Point(122, 195);
            txtno1.Name = "txtno1";
            txtno1.Size = new Size(100, 23);
            txtno1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(284, 202);
            label2.Name = "label2";
            label2.Size = new Size(35, 16);
            label2.TabIndex = 3;
            label2.Text = "No.2";
            // 
            // txtno2
            // 
            txtno2.Location = new Point(335, 195);
            txtno2.Name = "txtno2";
            txtno2.Size = new Size(100, 23);
            txtno2.TabIndex = 4;
            // 
            // btnresta
            // 
            btnresta.BackColor = Color.FromArgb(192, 255, 192);
            btnresta.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnresta.Location = new Point(284, 272);
            btnresta.Name = "btnresta";
            btnresta.Size = new Size(75, 34);
            btnresta.TabIndex = 5;
            btnresta.Text = "resta";
            btnresta.UseVisualStyleBackColor = false;
            btnresta.Click += btnresta_Click;
            // 
            // btnmultiplicar
            // 
            btnmultiplicar.BackColor = Color.FromArgb(192, 192, 255);
            btnmultiplicar.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnmultiplicar.Location = new Point(429, 272);
            btnmultiplicar.Name = "btnmultiplicar";
            btnmultiplicar.Size = new Size(109, 34);
            btnmultiplicar.TabIndex = 6;
            btnmultiplicar.Text = "multipliar";
            btnmultiplicar.UseVisualStyleBackColor = false;
            btnmultiplicar.Click += btnmultiplicar_Click;
            // 
            // btndividir
            // 
            btndividir.BackColor = Color.FromArgb(255, 192, 255);
            btndividir.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btndividir.Location = new Point(589, 270);
            btndividir.Name = "btndividir";
            btndividir.Size = new Size(84, 36);
            btndividir.TabIndex = 7;
            btndividir.Text = "dividir";
            btndividir.UseVisualStyleBackColor = false;
            btndividir.Click += btndividir_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.FromArgb(255, 192, 192);
            button5.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button5.Location = new Point(457, 376);
            button5.Name = "button5";
            button5.Size = new Size(81, 36);
            button5.TabIndex = 8;
            button5.Text = "limpiar";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // btnregresar
            // 
            btnregresar.BackColor = Color.FromArgb(128, 128, 255);
            btnregresar.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnregresar.Location = new Point(589, 376);
            btnregresar.Name = "btnregresar";
            btnregresar.Size = new Size(97, 36);
            btnregresar.TabIndex = 9;
            btnregresar.Text = "regresar";
            btnregresar.UseVisualStyleBackColor = false;
            btnregresar.Click += button1_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe Print", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            richTextBox1.Location = new Point(81, 25);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(638, 121);
            richTextBox1.TabIndex = 10;
            richTextBox1.Text = resources.GetString("richTextBox1.Text");
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // FormOperaciones
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(btnregresar);
            Controls.Add(button5);
            Controls.Add(btndividir);
            Controls.Add(btnmultiplicar);
            Controls.Add(btnresta);
            Controls.Add(txtno2);
            Controls.Add(label2);
            Controls.Add(txtno1);
            Controls.Add(btnsuma);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormOperaciones";
            Text = "Operaciones básicas";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btnsuma;
        private TextBox txtno1;
        private Label label2;
        private TextBox txtno2;
        private Button btnresta;
        private Button btnmultiplicar;
        private Button btndividir;
        private Button button5;
        private Button btnregresar;
        private RichTextBox richTextBox1;
    }
}