namespace analizador
{
    partial class pant_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pant_principal));
            panel1 = new Panel();
            sesion = new Button();
            panel3 = new Panel();
            registrar = new Button();
            panel2 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(sesion);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(registrar);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(141, 496);
            panel1.TabIndex = 0;
            // 
            // sesion
            // 
            sesion.Location = new Point(0, 270);
            sesion.Name = "sesion";
            sesion.Size = new Size(141, 40);
            sesion.TabIndex = 3;
            sesion.Text = "iniciar sesion";
            sesion.UseVisualStyleBackColor = true;
            sesion.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(224, 224, 224);
            panel3.BackgroundImage = (Image)resources.GetObject("panel3.BackgroundImage");
            panel3.BackgroundImageLayout = ImageLayout.Stretch;
            panel3.Location = new Point(0, 151);
            panel3.Name = "panel3";
            panel3.Size = new Size(141, 122);
            panel3.TabIndex = 2;
            panel3.Paint += panel3_Paint;
            // 
            // registrar
            // 
            registrar.BackColor = Color.FromArgb(224, 224, 224);
            registrar.Location = new Point(0, 110);
            registrar.Name = "registrar";
            registrar.Size = new Size(141, 46);
            registrar.TabIndex = 1;
            registrar.Text = "personal admin";
            registrar.UseVisualStyleBackColor = false;
            registrar.Click += registrar_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 255, 255);
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(141, 113);
            panel2.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.Location = new Point(141, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(657, 450);
            panel4.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackgroundImage = (Image)resources.GetObject("panel5.BackgroundImage");
            panel5.BackgroundImageLayout = ImageLayout.Stretch;
            panel5.Location = new Point(144, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(641, 496);
            panel5.TabIndex = 1;
            panel5.Paint += panel5_Paint;
            // 
            // pant_principal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 496);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Name = "pant_principal";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button registrar;
        private Panel panel3;
        private Button sesion;
        private Panel panel4;
        private Panel panel5;
    }
}
