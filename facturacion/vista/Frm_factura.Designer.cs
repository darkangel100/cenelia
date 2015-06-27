namespace facturacion.vista
{
    partial class Frm_factura
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_factura));
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.btn_imprimir = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.cbx_descuento = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_iva = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_subtotal = new System.Windows.Forms.TextBox();
            this.tbl_tabla = new System.Windows.Forms.DataGridView();
            this.btn_buscarP = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.btn_nuevo = new System.Windows.Forms.Button();
            this.btn_buscar = new System.Windows.Forms.Button();
            this.date_fecha = new System.Windows.Forms.DateTimePicker();
            this.txt_numFact = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.txt_direccion = new System.Windows.Forms.TextBox();
            this.txt_cliente = new System.Windows.Forms.TextBox();
            this.txt_cedula = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_tabla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.btn_cancelar);
            this.panel1.Controls.Add(this.btn_imprimir);
            this.panel1.Controls.Add(this.btn_guardar);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txt_total);
            this.panel1.Controls.Add(this.cbx_descuento);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txt_iva);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt_subtotal);
            this.panel1.Controls.Add(this.tbl_tabla);
            this.panel1.Controls.Add(this.btn_buscarP);
            this.panel1.Controls.Add(this.btn_agregar);
            this.panel1.Controls.Add(this.btn_nuevo);
            this.panel1.Controls.Add(this.btn_buscar);
            this.panel1.Controls.Add(this.date_fecha);
            this.panel1.Controls.Add(this.txt_numFact);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txt_codigo);
            this.panel1.Controls.Add(this.txt_telefono);
            this.panel1.Controls.Add(this.txt_direccion);
            this.panel1.Controls.Add(this.txt_cliente);
            this.panel1.Controls.Add(this.txt_cedula);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 461);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Cédula",
            "Apellido"});
            this.comboBox1.Location = new System.Drawing.Point(209, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(82, 21);
            this.comboBox1.TabIndex = 33;
            this.comboBox1.Text = "Opc Buscar";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(14, 419);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(75, 23);
            this.btn_cancelar.TabIndex = 31;
            this.btn_cancelar.Text = "CANCELAR";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            // 
            // btn_imprimir
            // 
            this.btn_imprimir.Enabled = false;
            this.btn_imprimir.Location = new System.Drawing.Point(14, 374);
            this.btn_imprimir.Name = "btn_imprimir";
            this.btn_imprimir.Size = new System.Drawing.Size(75, 23);
            this.btn_imprimir.TabIndex = 30;
            this.btn_imprimir.Text = "IMPRIMIR";
            this.btn_imprimir.UseVisualStyleBackColor = true;
            this.btn_imprimir.Click += new System.EventHandler(this.btn_imprimir_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(14, 329);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(75, 23);
            this.btn_guardar.TabIndex = 29;
            this.btn_guardar.Text = "GUARDAR";
            this.btn_guardar.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(243, 407);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 16);
            this.label12.TabIndex = 28;
            this.label12.Text = "Total*:";
            // 
            // txt_total
            // 
            this.txt_total.Enabled = false;
            this.txt_total.Location = new System.Drawing.Point(328, 407);
            this.txt_total.Name = "txt_total";
            this.txt_total.Size = new System.Drawing.Size(100, 20);
            this.txt_total.TabIndex = 27;
            // 
            // cbx_descuento
            // 
            this.cbx_descuento.FormattingEnabled = true;
            this.cbx_descuento.Items.AddRange(new object[] {
            "5",
            "10",
            "15",
            "20",
            "25",
            "30"});
            this.cbx_descuento.Location = new System.Drawing.Point(328, 380);
            this.cbx_descuento.Name = "cbx_descuento";
            this.cbx_descuento.Size = new System.Drawing.Size(100, 21);
            this.cbx_descuento.TabIndex = 26;
            this.cbx_descuento.Text = "Seleccione";
            this.cbx_descuento.UseWaitCursor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(243, 381);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 16);
            this.label11.TabIndex = 25;
            this.label11.Text = "Descuento*:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(243, 355);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 16);
            this.label10.TabIndex = 23;
            this.label10.Text = "Iva*:";
            // 
            // txt_iva
            // 
            this.txt_iva.Enabled = false;
            this.txt_iva.Location = new System.Drawing.Point(328, 355);
            this.txt_iva.Name = "txt_iva";
            this.txt_iva.Size = new System.Drawing.Size(100, 20);
            this.txt_iva.TabIndex = 22;
            this.txt_iva.Text = "12";
            this.txt_iva.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(243, 329);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 16);
            this.label9.TabIndex = 21;
            this.label9.Text = "Subtotal*:";
            // 
            // txt_subtotal
            // 
            this.txt_subtotal.Enabled = false;
            this.txt_subtotal.Location = new System.Drawing.Point(328, 329);
            this.txt_subtotal.Name = "txt_subtotal";
            this.txt_subtotal.Size = new System.Drawing.Size(100, 20);
            this.txt_subtotal.TabIndex = 20;
            this.txt_subtotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbl_tabla
            // 
            this.tbl_tabla.AllowUserToAddRows = false;
            this.tbl_tabla.AllowUserToDeleteRows = false;
            this.tbl_tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_tabla.Location = new System.Drawing.Point(14, 185);
            this.tbl_tabla.Name = "tbl_tabla";
            this.tbl_tabla.ReadOnly = true;
            this.tbl_tabla.Size = new System.Drawing.Size(414, 125);
            this.tbl_tabla.TabIndex = 19;
            // 
            // btn_buscarP
            // 
            this.btn_buscarP.Location = new System.Drawing.Point(353, 147);
            this.btn_buscarP.Name = "btn_buscarP";
            this.btn_buscarP.Size = new System.Drawing.Size(75, 23);
            this.btn_buscarP.TabIndex = 18;
            this.btn_buscarP.Text = "BUSCAR";
            this.btn_buscarP.UseVisualStyleBackColor = true;
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(203, 146);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(75, 23);
            this.btn_agregar.TabIndex = 17;
            this.btn_agregar.Text = "AGREGAR";
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Location = new System.Drawing.Point(366, 37);
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(62, 23);
            this.btn_nuevo.TabIndex = 16;
            this.btn_nuevo.Text = "NUEVO";
            this.btn_nuevo.UseVisualStyleBackColor = true;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_buscar
            // 
            this.btn_buscar.Location = new System.Drawing.Point(292, 38);
            this.btn_buscar.Name = "btn_buscar";
            this.btn_buscar.Size = new System.Drawing.Size(69, 23);
            this.btn_buscar.TabIndex = 15;
            this.btn_buscar.Text = "BUSCAR";
            this.btn_buscar.UseVisualStyleBackColor = true;
            // 
            // date_fecha
            // 
            this.date_fecha.Enabled = false;
            this.date_fecha.Location = new System.Drawing.Point(310, 119);
            this.date_fecha.Name = "date_fecha";
            this.date_fecha.Size = new System.Drawing.Size(118, 20);
            this.date_fecha.TabIndex = 14;
            // 
            // txt_numFact
            // 
            this.txt_numFact.Location = new System.Drawing.Point(310, 92);
            this.txt_numFact.Name = "txt_numFact";
            this.txt_numFact.Size = new System.Drawing.Size(118, 20);
            this.txt_numFact.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(243, 119);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 16);
            this.label8.TabIndex = 12;
            this.label8.Text = "Fecha*:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(243, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Nro Fact*:";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(103, 146);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(79, 20);
            this.txt_codigo.TabIndex = 10;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Enabled = false;
            this.txt_telefono.Location = new System.Drawing.Point(103, 120);
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(118, 20);
            this.txt_telefono.TabIndex = 9;
            // 
            // txt_direccion
            // 
            this.txt_direccion.Enabled = false;
            this.txt_direccion.Location = new System.Drawing.Point(103, 92);
            this.txt_direccion.Name = "txt_direccion";
            this.txt_direccion.Size = new System.Drawing.Size(118, 20);
            this.txt_direccion.TabIndex = 8;
            // 
            // txt_cliente
            // 
            this.txt_cliente.Enabled = false;
            this.txt_cliente.Location = new System.Drawing.Point(103, 66);
            this.txt_cliente.Name = "txt_cliente";
            this.txt_cliente.Size = new System.Drawing.Size(325, 20);
            this.txt_cliente.TabIndex = 7;
            // 
            // txt_cedula
            // 
            this.txt_cedula.Location = new System.Drawing.Point(103, 40);
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(100, 20);
            this.txt_cedula.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Código*:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Teléfono*:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dirección*:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Cliente*:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cédula*:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(160, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "FACTURACIÓN";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Frm_factura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 464);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_factura";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Factura";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_tabla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker date_fecha;
        private System.Windows.Forms.TextBox txt_numFact;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.TextBox txt_direccion;
        private System.Windows.Forms.TextBox txt_cliente;
        private System.Windows.Forms.TextBox txt_cedula;
        private System.Windows.Forms.Button btn_nuevo;
        private System.Windows.Forms.Button btn_buscar;
        private System.Windows.Forms.Button btn_buscarP;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.ComboBox cbx_descuento;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_iva;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_subtotal;
        private System.Windows.Forms.DataGridView tbl_tabla;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.Button btn_imprimir;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox comboBox1;

    }
}
