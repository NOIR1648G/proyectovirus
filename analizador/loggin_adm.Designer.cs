namespace analizador
{
    partial class loggin_adm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loggin_adm));
            nombre = new TextBox();
            contraseña = new TextBox();
            label1 = new Label();
            label2 = new Label();
            loggin = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // nombre
            // 
            nombre.Location = new Point(175, 229);
            nombre.Name = "nombre";
            nombre.Size = new Size(146, 23);
            nombre.TabIndex = 1;
            nombre.TextChanged += nombre_TextChanged;
            // 
            // contraseña
            // 
            contraseña.Location = new Point(175, 258);
            contraseña.Name = "contraseña";
            contraseña.Size = new Size(146, 23);
            contraseña.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(118, 232);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 3;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(99, 261);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 4;
            label2.Text = "Contraseña:";
            label2.Click += label2_Click;
            // 
            // loggin
            // 
            loggin.Location = new Point(212, 304);
            loggin.Name = "loggin";
            loggin.RightToLeft = RightToLeft.Yes;
            loggin.Size = new Size(75, 23);
            loggin.TabIndex = 5;
            loggin.Text = "ingresar";
            loggin.UseVisualStyleBackColor = true;
            loggin.Click += loggin_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(166, 67);
            panel1.Name = "panel1";
            panel1.Size = new Size(155, 141);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // loggin_adm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkCyan;
            ClientSize = new Size(503, 410);
            Controls.Add(loggin);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(contraseña);
            Controls.Add(nombre);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "loggin_adm";
            Text = "Form1";
            Load += loggin_adm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox nombre;
        private TextBox contraseña;
        private Label label1;
        private Label label2;
        private Button loggin;
        private Panel panel1;
    }
}