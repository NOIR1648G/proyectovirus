namespace analizador
{
    partial class loggin_usuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loggin_usuarios));
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            nombre = new TextBox();
            cargo = new TextBox();
            contraseña = new TextBox();
            ingreso = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaptionText;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(146, 74);
            panel1.Name = "panel1";
            panel1.Size = new Size(168, 154);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.FromArgb(255, 128, 0);
            label1.Location = new Point(79, 254);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(79, 282);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Cargo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(255, 128, 0);
            label3.Location = new Point(70, 313);
            label3.Name = "label3";
            label3.Size = new Size(70, 15);
            label3.TabIndex = 3;
            label3.Text = "Contraseña:";
            label3.Click += label3_Click;
            // 
            // nombre
            // 
            nombre.Location = new Point(146, 253);
            nombre.Name = "nombre";
            nombre.Size = new Size(212, 23);
            nombre.TabIndex = 4;
            // 
            // cargo
            // 
            cargo.Location = new Point(146, 279);
            cargo.Name = "cargo";
            cargo.Size = new Size(212, 23);
            cargo.TabIndex = 5;
            // 
            // contraseña
            // 
            contraseña.Location = new Point(146, 310);
            contraseña.Name = "contraseña";
            contraseña.Size = new Size(212, 23);
            contraseña.TabIndex = 6;
            // 
            // ingreso
            // 
            ingreso.Location = new Point(184, 349);
            ingreso.Name = "ingreso";
            ingreso.Size = new Size(75, 23);
            ingreso.TabIndex = 7;
            ingreso.Text = "Ingreso";
            ingreso.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(508, 477);
            Controls.Add(ingreso);
            Controls.Add(contraseña);
            Controls.Add(cargo);
            Controls.Add(nombre);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox nombre;
        private TextBox cargo;
        private TextBox contraseña;
        private Button ingreso;
    }
}