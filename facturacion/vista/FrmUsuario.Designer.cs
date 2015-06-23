namespace facturacion.vista
{
    partial class FrmUsuario
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
            this.tc1 = new System.Windows.Forms.TabControl();
            this.tp1 = new System.Windows.Forms.TabPage();
            this.chkeliminados = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSal = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnborra = new System.Windows.Forms.Button();
            this.btnEdita = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.lstusu = new System.Windows.Forms.ListBox();
            this.tp2 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbp = new System.Windows.Forms.RadioButton();
            this.rba = new System.Windows.Forms.RadioButton();
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
            this.tc1.SuspendLayout();
            this.tp1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tp2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tc1
            // 
            this.tc1.Controls.Add(this.tp1);
            this.tc1.Controls.Add(this.tp2);
            this.tc1.Location = new System.Drawing.Point(70, 21);
            this.tc1.Name = "tc1";
            this.tc1.SelectedIndex = 0;
            this.tc1.Size = new System.Drawing.Size(535, 336);
            this.tc1.TabIndex = 2;
            this.tc1.SelectedIndexChanged += new System.EventHandler(this.tc1_SelectedIndexChanged);
            // 
            // tp1
            // 
            this.tp1.Controls.Add(this.chkeliminados);
            this.tp1.Controls.Add(this.label4);
            this.tp1.Controls.Add(this.btnSal);
            this.tp1.Controls.Add(this.panel2);
            this.tp1.Controls.Add(this.lstusu);
            this.tp1.Location = new System.Drawing.Point(4, 22);
            this.tp1.Name = "tp1";
            this.tp1.Padding = new System.Windows.Forms.Padding(3);
            this.tp1.Size = new System.Drawing.Size(527, 310);
            this.tp1.TabIndex = 0;
            this.tp1.Text = "Listado";
            this.tp1.UseVisualStyleBackColor = true;
            // 
            // chkeliminados
            // 
            this.chkeliminados.AutoSize = true;
            this.chkeliminados.Location = new System.Drawing.Point(381, 30);
            this.chkeliminados.Name = "chkeliminados";
            this.chkeliminados.Size = new System.Drawing.Size(76, 17);
            this.chkeliminados.TabIndex = 58;
            this.chkeliminados.Text = "Eliminados";
            this.chkeliminados.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 56;
            this.label4.Text = "USUARIOS:";
            // 
            // btnSal
            // 
            this.btnSal.Location = new System.Drawing.Point(389, 239);
            this.btnSal.Name = "btnSal";
            this.btnSal.Size = new System.Drawing.Size(68, 28);
            this.btnSal.TabIndex = 55;
            this.btnSal.Text = "&Salir";
            this.btnSal.UseVisualStyleBackColor = true;
            this.btnSal.Click += new System.EventHandler(this.btnSal_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnborra);
            this.panel2.Controls.Add(this.btnEdita);
            this.panel2.Controls.Add(this.btnNuevo);
            this.panel2.Location = new System.Drawing.Point(70, 227);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(262, 50);
            this.panel2.TabIndex = 54;
            // 
            // btnborra
            // 
            this.btnborra.Location = new System.Drawing.Point(175, 12);
            this.btnborra.Name = "btnborra";
            this.btnborra.Size = new System.Drawing.Size(68, 28);
            this.btnborra.TabIndex = 9;
            this.btnborra.Text = "&Eliminar";
            this.btnborra.UseVisualStyleBackColor = true;
            // 
            // btnEdita
            // 
            this.btnEdita.Location = new System.Drawing.Point(92, 12);
            this.btnEdita.Name = "btnEdita";
            this.btnEdita.Size = new System.Drawing.Size(68, 28);
            this.btnEdita.TabIndex = 8;
            this.btnEdita.Text = "&Modificar";
            this.btnEdita.UseVisualStyleBackColor = true;
            this.btnEdita.Click += new System.EventHandler(this.btnEdita_Click_1);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 12);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(68, 28);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // lstusu
            // 
            this.lstusu.FormattingEnabled = true;
            this.lstusu.Location = new System.Drawing.Point(70, 53);
            this.lstusu.Name = "lstusu";
            this.lstusu.Size = new System.Drawing.Size(387, 160);
            this.lstusu.TabIndex = 53;
            // 
            // tp2
            // 
            this.tp2.Controls.Add(this.panel1);
            this.tp2.Location = new System.Drawing.Point(4, 22);
            this.tp2.Name = "tp2";
            this.tp2.Padding = new System.Windows.Forms.Padding(3);
            this.tp2.Size = new System.Drawing.Size(527, 310);
            this.tp2.TabIndex = 1;
            this.tp2.Text = "Datos";
            this.tp2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.txtusuario);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.txtcla);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txttel);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtdir);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtnom);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnGuarda);
            this.panel1.Controls.Add(this.txtape);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtced);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(23, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(459, 233);
            this.panel1.TabIndex = 51;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(272, 117);
            this.txtusuario.MaxLength = 40;
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.PasswordChar = '*';
            this.txtusuario.Size = new System.Drawing.Size(101, 20);
            this.txtusuario.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(216, 121);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Usuario:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(216, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Rol:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(272, 143);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(107, 21);
            this.comboBox1.TabIndex = 23;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbp);
            this.groupBox2.Controls.Add(this.rba);
            this.groupBox2.Location = new System.Drawing.Point(75, 166);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(86, 55);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Estado:";
            // 
            // rbp
            // 
            this.rbp.AutoSize = true;
            this.rbp.Location = new System.Drawing.Point(16, 32);
            this.rbp.Name = "rbp";
            this.rbp.Size = new System.Drawing.Size(57, 17);
            this.rbp.TabIndex = 1;
            this.rbp.Text = "Pasivo";
            this.rbp.UseVisualStyleBackColor = true;
            // 
            // rba
            // 
            this.rba.AutoSize = true;
            this.rba.Checked = true;
            this.rba.Location = new System.Drawing.Point(16, 15);
            this.rba.Name = "rba";
            this.rba.Size = new System.Drawing.Size(55, 17);
            this.rba.TabIndex = 0;
            this.rba.TabStop = true;
            this.rba.Text = "Activo";
            this.rba.UseVisualStyleBackColor = true;
            // 
            // txtcla
            // 
            this.txtcla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcla.Location = new System.Drawing.Point(75, 140);
            this.txtcla.MaxLength = 40;
            this.txtcla.Name = "txtcla";
            this.txtcla.PasswordChar = '*';
            this.txtcla.Size = new System.Drawing.Size(101, 20);
            this.txtcla.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(9, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Clave:";
            // 
            // txttel
            // 
            this.txttel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txttel.Location = new System.Drawing.Point(75, 114);
            this.txttel.MaxLength = 10;
            this.txttel.Name = "txttel";
            this.txttel.Size = new System.Drawing.Size(129, 20);
            this.txttel.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Teléfono:";
            // 
            // txtdir
            // 
            this.txtdir.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdir.Location = new System.Drawing.Point(75, 88);
            this.txtdir.MaxLength = 40;
            this.txtdir.Name = "txtdir";
            this.txtdir.Size = new System.Drawing.Size(286, 20);
            this.txtdir.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Dirección:";
            // 
            // txtnom
            // 
            this.txtnom.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtnom.Location = new System.Drawing.Point(75, 62);
            this.txtnom.MaxLength = 20;
            this.txtnom.Name = "txtnom";
            this.txtnom.Size = new System.Drawing.Size(207, 20);
            this.txtnom.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nombres:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(293, 192);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(68, 28);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuarda
            // 
            this.btnGuarda.Location = new System.Drawing.Point(219, 192);
            this.btnGuarda.Name = "btnGuarda";
            this.btnGuarda.Size = new System.Drawing.Size(68, 28);
            this.btnGuarda.TabIndex = 9;
            this.btnGuarda.Text = "&Guardar";
            this.btnGuarda.UseVisualStyleBackColor = true;
            this.btnGuarda.Click += new System.EventHandler(this.btnGuarda_Click);
            // 
            // txtape
            // 
            this.txtape.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtape.Location = new System.Drawing.Point(75, 36);
            this.txtape.MaxLength = 20;
            this.txtape.Name = "txtape";
            this.txtape.Size = new System.Drawing.Size(207, 20);
            this.txtape.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Apellidos:";
            // 
            // txtced
            // 
            this.txtced.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtced.Location = new System.Drawing.Point(75, 10);
            this.txtced.MaxLength = 13;
            this.txtced.Name = "txtced";
            this.txtced.Size = new System.Drawing.Size(128, 20);
            this.txtced.TabIndex = 3;
            this.txtced.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtced_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cédula:";
            // 
            // FrmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::facturacion.Properties.Resources.fondo_login2;
            this.ClientSize = new System.Drawing.Size(655, 382);
            this.Controls.Add(this.tc1);
            this.Name = "FrmUsuario";
            this.Text = "FrmUsuario";
            this.Load += new System.EventHandler(this.FrmUsuario_Load);
            this.tc1.ResumeLayout(false);
            this.tp1.ResumeLayout(false);
            this.tp1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.tp2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tc1;
        private System.Windows.Forms.TabPage tp1;
        private System.Windows.Forms.CheckBox chkeliminados;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSal;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnborra;
        private System.Windows.Forms.Button btnEdita;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.ListBox lstusu;
        private System.Windows.Forms.TabPage tp2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbp;
        private System.Windows.Forms.RadioButton rba;
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.Label label9;
    }
}