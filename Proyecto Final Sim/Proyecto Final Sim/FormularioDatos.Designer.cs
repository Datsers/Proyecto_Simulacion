namespace Proyecto_Final_Sim
{
    partial class FormularioDatos
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbPierna = new System.Windows.Forms.CheckBox();
            this.cbBrazo = new System.Windows.Forms.CheckBox();
            this.cbEspalda = new System.Windows.Forms.CheckBox();
            this.cbRodilla = new System.Windows.Forms.CheckBox();
            this.cbHombro = new System.Windows.Forms.CheckBox();
            this.cbLPno = new System.Windows.Forms.CheckBox();
            this.cbLPsi = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbECno = new System.Windows.Forms.CheckBox();
            this.cbECsi = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbF = new System.Windows.Forms.CheckBox();
            this.cbM = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 33);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Final_Sim.Properties.Resources.iconfinder_icon_close_211652;
            this.pictureBox1.Location = new System.Drawing.Point(760, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(532, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "REGISTRO DE DATOS USUARIO";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbPierna);
            this.groupBox1.Controls.Add(this.cbBrazo);
            this.groupBox1.Controls.Add(this.cbEspalda);
            this.groupBox1.Controls.Add(this.cbRodilla);
            this.groupBox1.Controls.Add(this.cbHombro);
            this.groupBox1.Controls.Add(this.cbLPno);
            this.groupBox1.Controls.Add(this.cbLPsi);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.cbECno);
            this.groupBox1.Controls.Add(this.cbECsi);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cbF);
            this.groupBox1.Controls.Add(this.cbM);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtEdad);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtAltura);
            this.groupBox1.Controls.Add(this.txtPeso);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(19, 85);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(769, 257);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Principales";
            // 
            // cbPierna
            // 
            this.cbPierna.AutoSize = true;
            this.cbPierna.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPierna.Location = new System.Drawing.Point(365, 223);
            this.cbPierna.Name = "cbPierna";
            this.cbPierna.Size = new System.Drawing.Size(73, 24);
            this.cbPierna.TabIndex = 23;
            this.cbPierna.Text = "Pierna";
            this.cbPierna.UseVisualStyleBackColor = true;
            // 
            // cbBrazo
            // 
            this.cbBrazo.AutoSize = true;
            this.cbBrazo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbBrazo.Location = new System.Drawing.Point(289, 223);
            this.cbBrazo.Name = "cbBrazo";
            this.cbBrazo.Size = new System.Drawing.Size(70, 24);
            this.cbBrazo.TabIndex = 22;
            this.cbBrazo.Text = "Brazo";
            this.cbBrazo.UseVisualStyleBackColor = true;
            // 
            // cbEspalda
            // 
            this.cbEspalda.AutoSize = true;
            this.cbEspalda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbEspalda.Location = new System.Drawing.Point(197, 223);
            this.cbEspalda.Name = "cbEspalda";
            this.cbEspalda.Size = new System.Drawing.Size(86, 24);
            this.cbEspalda.TabIndex = 21;
            this.cbEspalda.Text = "Espalda";
            this.cbEspalda.UseVisualStyleBackColor = true;
            // 
            // cbRodilla
            // 
            this.cbRodilla.AutoSize = true;
            this.cbRodilla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRodilla.Location = new System.Drawing.Point(115, 223);
            this.cbRodilla.Name = "cbRodilla";
            this.cbRodilla.Size = new System.Drawing.Size(76, 24);
            this.cbRodilla.TabIndex = 20;
            this.cbRodilla.Text = "Rodilla";
            this.cbRodilla.UseVisualStyleBackColor = true;
            // 
            // cbHombro
            // 
            this.cbHombro.AutoSize = true;
            this.cbHombro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbHombro.Location = new System.Drawing.Point(24, 223);
            this.cbHombro.Name = "cbHombro";
            this.cbHombro.Size = new System.Drawing.Size(85, 24);
            this.cbHombro.TabIndex = 19;
            this.cbHombro.Text = "Hombro";
            this.cbHombro.UseVisualStyleBackColor = true;
            // 
            // cbLPno
            // 
            this.cbLPno.AutoSize = true;
            this.cbLPno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLPno.Location = new System.Drawing.Point(75, 193);
            this.cbLPno.Name = "cbLPno";
            this.cbLPno.Size = new System.Drawing.Size(39, 24);
            this.cbLPno.TabIndex = 18;
            this.cbLPno.Text = "N";
            this.cbLPno.UseVisualStyleBackColor = true;
            this.cbLPno.CheckedChanged += new System.EventHandler(this.cbLPno_CheckedChanged);
            // 
            // cbLPsi
            // 
            this.cbLPsi.AutoSize = true;
            this.cbLPsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbLPsi.Location = new System.Drawing.Point(24, 193);
            this.cbLPsi.Name = "cbLPsi";
            this.cbLPsi.Size = new System.Drawing.Size(39, 24);
            this.cbLPsi.TabIndex = 17;
            this.cbLPsi.Text = "S";
            this.cbLPsi.UseVisualStyleBackColor = true;
            this.cbLPsi.CheckedChanged += new System.EventHandler(this.cbLPsi_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(20, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 20);
            this.label9.TabIndex = 16;
            this.label9.Text = "Lesiones Previas";
            // 
            // cbECno
            // 
            this.cbECno.AutoSize = true;
            this.cbECno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbECno.Location = new System.Drawing.Point(722, 193);
            this.cbECno.Name = "cbECno";
            this.cbECno.Size = new System.Drawing.Size(39, 24);
            this.cbECno.TabIndex = 15;
            this.cbECno.Text = "N";
            this.cbECno.UseVisualStyleBackColor = true;
            this.cbECno.CheckedChanged += new System.EventHandler(this.cbECno_CheckedChanged);
            // 
            // cbECsi
            // 
            this.cbECsi.AutoSize = true;
            this.cbECsi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbECsi.Location = new System.Drawing.Point(677, 193);
            this.cbECsi.Name = "cbECsi";
            this.cbECsi.Size = new System.Drawing.Size(39, 24);
            this.cbECsi.TabIndex = 14;
            this.cbECsi.Text = "S";
            this.cbECsi.UseVisualStyleBackColor = true;
            this.cbECsi.CheckedChanged += new System.EventHandler(this.cbECsi_CheckedChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(493, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(270, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Enfermedad Cardiaca / Diabetes";
            // 
            // cbF
            // 
            this.cbF.AutoSize = true;
            this.cbF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbF.Location = new System.Drawing.Point(140, 124);
            this.cbF.Name = "cbF";
            this.cbF.Size = new System.Drawing.Size(38, 24);
            this.cbF.TabIndex = 12;
            this.cbF.Text = "F";
            this.cbF.UseVisualStyleBackColor = true;
            this.cbF.CheckedChanged += new System.EventHandler(this.cbF_CheckedChanged);
            // 
            // cbM
            // 
            this.cbM.AutoSize = true;
            this.cbM.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbM.Location = new System.Drawing.Point(85, 124);
            this.cbM.Name = "cbM";
            this.cbM.Size = new System.Drawing.Size(41, 24);
            this.cbM.TabIndex = 11;
            this.cbM.Text = "M";
            this.cbM.UseVisualStyleBackColor = true;
            this.cbM.CheckedChanged += new System.EventHandler(this.cbM_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 124);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Sexo";
            // 
            // txtEdad
            // 
            this.txtEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEdad.Location = new System.Drawing.Point(501, 80);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(118, 26);
            this.txtEdad.TabIndex = 9;
            this.txtEdad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(444, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Edad";
            // 
            // txtAltura
            // 
            this.txtAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.Location = new System.Drawing.Point(278, 80);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(118, 26);
            this.txtAltura.TabIndex = 7;
            this.txtAltura.Text = "cm";
            this.txtAltura.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(75, 80);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(118, 26);
            this.txtPeso.TabIndex = 6;
            this.txtPeso.Text = "kg";
            this.txtPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(462, 35);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(280, 26);
            this.txtApellido.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(97, 35);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(280, 26);
            this.txtNombre.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(215, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Altura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Peso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(383, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.Coral;
            this.btnAddUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddUser.Location = new System.Drawing.Point(317, 363);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(169, 55);
            this.btnAddUser.TabIndex = 7;
            this.btnAddUser.Text = "Añadir Usuario";
            this.btnAddUser.UseVisualStyleBackColor = false;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // FormularioDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 438);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormularioDatos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormularioDatos";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox cbF;
        private System.Windows.Forms.CheckBox cbM;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox cbPierna;
        private System.Windows.Forms.CheckBox cbBrazo;
        private System.Windows.Forms.CheckBox cbEspalda;
        private System.Windows.Forms.CheckBox cbRodilla;
        private System.Windows.Forms.CheckBox cbHombro;
        private System.Windows.Forms.CheckBox cbLPno;
        private System.Windows.Forms.CheckBox cbLPsi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox cbECno;
        private System.Windows.Forms.CheckBox cbECsi;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddUser;
    }
}