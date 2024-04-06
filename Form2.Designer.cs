namespace len_3_Actividad_2
{
    partial class FormSaludo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSaludo));
            label1 = new Label();
            textBoxnombre = new TextBox();
            button1saludar = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("MV Boli", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(81, 78);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            label1.Click += label1_Click;
            // 
            // textBoxnombre
            // 
            textBoxnombre.Location = new Point(81, 130);
            textBoxnombre.Name = "textBoxnombre";
            textBoxnombre.Size = new Size(266, 23);
            textBoxnombre.TabIndex = 1;
            // 
            // button1saludar
            // 
            button1saludar.BackColor = Color.FromArgb(255, 224, 192);
            button1saludar.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1saludar.Location = new Point(317, 237);
            button1saludar.Name = "button1saludar";
            button1saludar.Size = new Size(184, 34);
            button1saludar.TabIndex = 2;
            button1saludar.Text = "Saludar";
            button1saludar.UseVisualStyleBackColor = false;
            button1saludar.Click += button1saludar_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(192, 192, 255);
            button1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            button1.Location = new Point(576, 394);
            button1.Name = "button1";
            button1.Size = new Size(181, 44);
            button1.TabIndex = 3;
            button1.Text = "Regresar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // FormSaludo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(button1saludar);
            Controls.Add(textBoxnombre);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FormSaludo";
            Text = "Saludo";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxnombre;
        private Button button1saludar;
        private Button button1;
    }
}