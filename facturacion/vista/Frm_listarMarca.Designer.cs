namespace facturacion.vista
{
    partial class Frm_listarMarca
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.list_marca = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_marca = new System.Windows.Forms.TextBox();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.cbx_criiterio = new System.Windows.Forms.ComboBox();
            this.btn_modificar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTADO DE MARCAS";
            // 
            // list_marca
            // 
            this.list_marca.FormattingEnabled = true;
            this.list_marca.Location = new System.Drawing.Point(35, 94);
            this.list_marca.Name = "list_marca";
            this.list_marca.Size = new System.Drawing.Size(335, 134);
            this.list_marca.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Criterio:";
            // 
            // txt_marca
            // 
            this.txt_marca.Location = new System.Drawing.Point(189, 56);
            this.txt_marca.Name = "txt_marca";
            this.txt_marca.Size = new System.Drawing.Size(100, 20);
            this.txt_marca.TabIndex = 3;
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(295, 53);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(75, 23);
            this.btn_buscar.TabIndex = 4;
            this.btn_buscar.Text = "Buscar";
            this.btn_buscar.UseVisualStyleBackColor = true;
           
            // 
            // cbx_criiterio
            // 
            this.cbx_criiterio.FormattingEnabled = true;
            this.cbx_criiterio.Items.AddRange(new object[] {
            "Nombre",
            "Todos"});
            this.cbx_criiterio.Location = new System.Drawing.Point(81, 56);
            this.cbx_criiterio.Name = "cbx_criiterio";
            this.cbx_criiterio.Size = new System.Drawing.Size(102, 21);
            this.cbx_criiterio.TabIndex = 5;
            // 
            // btn_modificar
            // 
            this.btn_modificar.Location = new System.Drawing.Point(35, 248);
            this.btn_modificar.Name = "btn_modificar";
            this.btn_modificar.Size = new System.Drawing.Size(75, 23);
            this.btn_modificar.TabIndex = 6;
            this.btn_modificar.Text = "Modificar";
            this.btn_modificar.UseVisualStyleBackColor = true;
           
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(295, 248);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 8;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            
            // 
            // Frm_listarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 283);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_modificar);
            this.Controls.Add(this.cbx_criiterio);
            this.Controls.Add(this.btn_buscar);
            this.Controls.Add(this.txt_marca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.list_marca);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_listarMarca";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Frm_listarMarca";
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox list_marca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_marca;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.ComboBox cbx_criiterio;
        private System.Windows.Forms.Button btn_modificar;
        private System.Windows.Forms.Button btn_cancelar;

    }
}
