namespace Lab_8
{
    partial class TodosLocales
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxLista = new System.Windows.Forms.TextBox();
            this.labelLista = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxLista
            // 
            this.textBoxLista.Location = new System.Drawing.Point(23, 34);
            this.textBoxLista.Multiline = true;
            this.textBoxLista.Name = "textBoxLista";
            this.textBoxLista.Size = new System.Drawing.Size(184, 161);
            this.textBoxLista.TabIndex = 0;
            // 
            // labelLista
            // 
            this.labelLista.AutoSize = true;
            this.labelLista.Location = new System.Drawing.Point(3, 0);
            this.labelLista.Name = "labelLista";
            this.labelLista.Size = new System.Drawing.Size(110, 13);
            this.labelLista.TabIndex = 1;
            this.labelLista.Text = "Lista todos los locales";
            // 
            // TodosLocales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labelLista);
            this.Controls.Add(this.textBoxLista);
            this.Name = "TodosLocales";
            this.Size = new System.Drawing.Size(239, 239);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLista;
        private System.Windows.Forms.Label labelLista;
    }
}
