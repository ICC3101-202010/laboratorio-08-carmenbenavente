namespace Lab_8
{
    partial class Form1
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
            this.comboBoxAgregarTipo = new System.Windows.Forms.ComboBox();
            this.labelAgregarTipo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.Tienda = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonCVolver = new System.Windows.Forms.Button();
            this.Cine = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonRestVolver = new System.Windows.Forms.Button();
            this.Restaurante = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.buttonRecVolver = new System.Windows.Forms.Button();
            this.Recreacional = new System.Windows.Forms.Label();
            this.buttonTVolver = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxAgregarTipo
            // 
            this.comboBoxAgregarTipo.FormattingEnabled = true;
            this.comboBoxAgregarTipo.Items.AddRange(new object[] {
            "Tienda",
            "Restaurante",
            "Cine",
            "Recreacional"});
            this.comboBoxAgregarTipo.Location = new System.Drawing.Point(31, 28);
            this.comboBoxAgregarTipo.Name = "comboBoxAgregarTipo";
            this.comboBoxAgregarTipo.Size = new System.Drawing.Size(121, 21);
            this.comboBoxAgregarTipo.TabIndex = 2;
            // 
            // labelAgregarTipo
            // 
            this.labelAgregarTipo.AutoSize = true;
            this.labelAgregarTipo.Location = new System.Drawing.Point(28, 12);
            this.labelAgregarTipo.Name = "labelAgregarTipo";
            this.labelAgregarTipo.Size = new System.Drawing.Size(124, 13);
            this.labelAgregarTipo.TabIndex = 3;
            this.labelAgregarTipo.Text = "Agregar un local del tipo:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonAgregar);
            this.panel1.Controls.Add(this.labelAgregarTipo);
            this.panel1.Controls.Add(this.comboBoxAgregarTipo);
            this.panel1.Location = new System.Drawing.Point(28, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 114);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buttonTVolver);
            this.panel2.Controls.Add(this.Tienda);
            this.panel2.Location = new System.Drawing.Point(28, 190);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 5;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(77, 55);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregar.TabIndex = 1;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tienda
            // 
            this.Tienda.AutoSize = true;
            this.Tienda.Location = new System.Drawing.Point(14, 4);
            this.Tienda.Name = "Tienda";
            this.Tienda.Size = new System.Drawing.Size(40, 13);
            this.Tienda.TabIndex = 0;
            this.Tienda.Text = "Tienda";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.buttonCVolver);
            this.panel3.Controls.Add(this.Cine);
            this.panel3.Location = new System.Drawing.Point(316, 27);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 100);
            this.panel3.TabIndex = 6;
            // 
            // buttonCVolver
            // 
            this.buttonCVolver.Location = new System.Drawing.Point(57, 1);
            this.buttonCVolver.Name = "buttonCVolver";
            this.buttonCVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonCVolver.TabIndex = 1;
            this.buttonCVolver.Text = "Volver";
            this.buttonCVolver.UseVisualStyleBackColor = true;
            this.buttonCVolver.Click += new System.EventHandler(this.buttonCVolver_Click);
            // 
            // Cine
            // 
            this.Cine.AutoSize = true;
            this.Cine.Location = new System.Drawing.Point(22, 4);
            this.Cine.Name = "Cine";
            this.Cine.Size = new System.Drawing.Size(28, 13);
            this.Cine.TabIndex = 0;
            this.Cine.Text = "Cine";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonRestVolver);
            this.panel4.Controls.Add(this.Restaurante);
            this.panel4.Location = new System.Drawing.Point(316, 190);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 100);
            this.panel4.TabIndex = 7;
            // 
            // buttonRestVolver
            // 
            this.buttonRestVolver.Location = new System.Drawing.Point(91, 3);
            this.buttonRestVolver.Name = "buttonRestVolver";
            this.buttonRestVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonRestVolver.TabIndex = 1;
            this.buttonRestVolver.Text = "Volver";
            this.buttonRestVolver.UseVisualStyleBackColor = true;
            this.buttonRestVolver.Click += new System.EventHandler(this.buttonRestVolver_Click);
            // 
            // Restaurante
            // 
            this.Restaurante.AutoSize = true;
            this.Restaurante.Location = new System.Drawing.Point(19, 4);
            this.Restaurante.Name = "Restaurante";
            this.Restaurante.Size = new System.Drawing.Size(65, 13);
            this.Restaurante.TabIndex = 0;
            this.Restaurante.Text = "Restaurante";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttonRecVolver);
            this.panel5.Controls.Add(this.Recreacional);
            this.panel5.Location = new System.Drawing.Point(599, 27);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(200, 100);
            this.panel5.TabIndex = 8;
            // 
            // buttonRecVolver
            // 
            this.buttonRecVolver.Location = new System.Drawing.Point(70, 50);
            this.buttonRecVolver.Name = "buttonRecVolver";
            this.buttonRecVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonRecVolver.TabIndex = 1;
            this.buttonRecVolver.Text = "Volver";
            this.buttonRecVolver.UseVisualStyleBackColor = true;
            this.buttonRecVolver.Click += new System.EventHandler(this.buttonRecVolver_Click);
            // 
            // Recreacional
            // 
            this.Recreacional.AutoSize = true;
            this.Recreacional.Location = new System.Drawing.Point(27, 4);
            this.Recreacional.Name = "Recreacional";
            this.Recreacional.Size = new System.Drawing.Size(70, 13);
            this.Recreacional.TabIndex = 0;
            this.Recreacional.Text = "Recreacional";
            // 
            // buttonTVolver
            // 
            this.buttonTVolver.Location = new System.Drawing.Point(63, 39);
            this.buttonTVolver.Name = "buttonTVolver";
            this.buttonTVolver.Size = new System.Drawing.Size(75, 23);
            this.buttonTVolver.TabIndex = 2;
            this.buttonTVolver.Text = "Volver";
            this.buttonTVolver.UseVisualStyleBackColor = true;
            this.buttonTVolver.Click += new System.EventHandler(this.buttonTVolver_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAgregarTipo;
        private System.Windows.Forms.Label labelAgregarTipo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Tienda;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Cine;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Restaurante;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label Recreacional;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.Button buttonCVolver;
        private System.Windows.Forms.Button buttonRestVolver;
        private System.Windows.Forms.Button buttonRecVolver;
        private System.Windows.Forms.Button buttonTVolver;
    }
}