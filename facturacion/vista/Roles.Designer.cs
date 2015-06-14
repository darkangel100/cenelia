namespace facturacion.vista
{
    partial class Roles
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbpa = new System.Windows.Forms.RadioButton();
            this.rdbac = new System.Windows.Forms.RadioButton();
            this.lstroles = new System.Windows.Forms.ListBox();
            this.txtnomrol = new System.Windows.Forms.TextBox();
            this.txtidrol = new System.Windows.Forms.TextBox();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btnaceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbpa);
            this.groupBox1.Controls.Add(this.rdbac);
            this.groupBox1.Location = new System.Drawing.Point(15, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 70);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado";
            // 
            // rdbpa
            // 
            this.rdbpa.AutoSize = true;
            this.rdbpa.Location = new System.Drawing.Point(10, 42);
            this.rdbpa.Name = "rdbpa";
            this.rdbpa.Size = new System.Drawing.Size(58, 17);
            this.rdbpa.TabIndex = 1;
            this.rdbpa.TabStop = true;
            this.rdbpa.Text = "Pacivo";
            this.rdbpa.UseVisualStyleBackColor = true;
            // 
            // rdbac
            // 
            this.rdbac.AutoSize = true;
            this.rdbac.Location = new System.Drawing.Point(10, 19);
            this.rdbac.Name = "rdbac";
            this.rdbac.Size = new System.Drawing.Size(55, 17);
            this.rdbac.TabIndex = 0;
            this.rdbac.TabStop = true;
            this.rdbac.Text = "Activo";
            this.rdbac.UseVisualStyleBackColor = true;
            // 
            // lstroles
            // 
            this.lstroles.FormattingEnabled = true;
            this.lstroles.Location = new System.Drawing.Point(264, 11);
            this.lstroles.Name = "lstroles";
            this.lstroles.Size = new System.Drawing.Size(126, 134);
            this.lstroles.TabIndex = 14;
            // 
            // txtnomrol
            // 
            this.txtnomrol.Location = new System.Drawing.Point(116, 67);
            this.txtnomrol.Name = "txtnomrol";
            this.txtnomrol.Size = new System.Drawing.Size(100, 20);
            this.txtnomrol.TabIndex = 13;
            // 
            // txtidrol
            // 
            this.txtidrol.Location = new System.Drawing.Point(116, 18);
            this.txtidrol.Name = "txtidrol";
            this.txtidrol.Size = new System.Drawing.Size(100, 20);
            this.txtidrol.TabIndex = 12;
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(250, 198);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 23);
            this.btnsalir.TabIndex = 11;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            // 
            // btnaceptar
            // 
            this.btnaceptar.Location = new System.Drawing.Point(15, 198);
            this.btnaceptar.Name = "btnaceptar";
            this.btnaceptar.Size = new System.Drawing.Size(75, 23);
            this.btnaceptar.TabIndex = 10;
            this.btnaceptar.Text = "Aceptar";
            this.btnaceptar.UseVisualStyleBackColor = true;
            this.btnaceptar.Click += new System.EventHandler(this.btnaceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Id Rol";
            // 
            // Roles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 229);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstroles);
            this.Controls.Add(this.txtnomrol);
            this.Controls.Add(this.txtidrol);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnaceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Roles";
            this.Text = "Roles";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbpa;
        private System.Windows.Forms.RadioButton rdbac;
        private System.Windows.Forms.ListBox lstroles;
        private System.Windows.Forms.TextBox txtnomrol;
        private System.Windows.Forms.TextBox txtidrol;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btnaceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}