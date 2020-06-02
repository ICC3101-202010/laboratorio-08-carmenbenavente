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
            this.comboBoxTodosLocales = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBoxTodosLocales
            // 
            this.comboBoxTodosLocales.FormattingEnabled = true;
            this.comboBoxTodosLocales.Location = new System.Drawing.Point(54, 97);
            this.comboBoxTodosLocales.Name = "comboBoxTodosLocales";
            this.comboBoxTodosLocales.Size = new System.Drawing.Size(121, 21);
            this.comboBoxTodosLocales.TabIndex = 0;
            this.comboBoxTodosLocales.SelectedIndexChanged += new System.EventHandler(this.comboBoxTodosLocales_SelectedIndexChanged);
            // 
            // TodosLocales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.comboBoxTodosLocales);
            this.Name = "TodosLocales";
            this.Size = new System.Drawing.Size(239, 239);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxTodosLocales;
    }
}
