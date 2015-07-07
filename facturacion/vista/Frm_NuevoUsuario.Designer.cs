namespace facturacion.vista
{
    partial class Frm_NuevoUsuario
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
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtcla = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txttel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtdir = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtnom = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGuarda = new System.Windows.Forms.Button();
            this.txtape = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtced = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(270, 128);
            this.txtusuario.MaxLength = 40;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.PasswordChar = '*';
            this.txtusuario.Size = new System.Drawing.Size(101, 20);
            this.txtusuario.TabIndex = 45;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(214, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Usuario:";
            // 
            // txtcla
            // 
            this.txtcla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcla.Location = new System.Drawing.Point(73, 151);
            this.txtcla.MaxLength = 40;
            this.txtcla.Name = "txtcla";
            this.txtcla.PasswordChar = '*';
            this.txtcla.Size = new System.Drawing.Size(101, 20);
            this.txtcla.TabIndex = 40;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Clave:";
            // 
            // txttel
            // 
            this.txttel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txttel.Location = new System.Drawing.Point(73, 125);
            this.txttel.MaxLength = 10;
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(129, 20);
            this.txttel.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Teléfono:";
            // 
            // txtdir
            // 
            this.txtdir.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdir.Location = new System.Drawing.Point(73, 99);
            this.txtdir.MaxLength = 40;
            this.txtdir.Name = "txtdir";
            this.txtdir.Size = new System.Drawing.Size(286, 20);
            this.txtdir.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 35;
            this.label5.Text = "Dirección:";
            // 
            // txtnom
            // 
            this.txtnom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnom.Location = new System.Drawing.Point(73, 73);
            this.txtnom.MaxLength = 20;
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(207, 20);
            this.txtnom.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Nombres:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(291, 203);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(68, 28);
            this.btnCancelar.TabIndex = 32;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuarda
            // 
            this.btnGuarda.Location = new System.Drawing.Point(217, 203);
            this.btnGuarda.Name = "btnGuarda";
            this.btnGuarda.Size = new System.Drawing.Size(68, 28);
            this.btnGuarda.TabIndex = 31;
            this.btnGuarda.Text = "&Guardar";
            this.btnGuarda.UseVisualStyleBackColor = true;
            this.btnGuarda.Click += new System.EventHandler(this.btnGuarda_Click);
            // 
            // txtape
            // 
            this.txtape.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtape.Location = new System.Drawing.Point(73, 47);
            this.txtape.MaxLength = 20;
            this.txtape.Name = "txtape";
            this.txtape.Size = new System.Drawing.Size(207, 20);
            this.txtape.TabIndex = 30;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(7, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Apellidos:";
            // 
            // txtced
            // 
            this.txtced.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtced.Location = new System.Drawing.Point(73, 21);
            this.txtced.MaxLength = 13;
            this.txtced.Name = "txtced";
            this.txtced.Size = new System.Drawing.Size(128, 20);
            this.txtced.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Cédula:";
            // 
            // Frm_NuevoUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 259);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtcla);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txttel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtdir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtnom);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuarda);
            this.Controls.Add(this.txtape);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtced);
            this.Controls.Add(this.label2);
            this.Name = "Frm_NuevoUsuario";
            this.Text = "Frm_NuevoUsuario";
            this.Load += new System.EventHandler(this.Frm_NuevoUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtcla;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtdir;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtnom;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGuarda;
        private System.Windows.Forms.TextBox txtape;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtced;
        private System.Windows.Forms.Label label2;
    }
}