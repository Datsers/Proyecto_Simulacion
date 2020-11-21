namespace Proyecto_Final_Sim
{
    partial class Formulario_Menu
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
            this.btnGenProgress = new System.Windows.Forms.Button();
            this.btnConsEjer = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnIMactual = new System.Windows.Forms.Button();
            this.btnConsRE = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGenProgress
            // 
            this.btnGenProgress.BackColor = System.Drawing.Color.Coral;
            this.btnGenProgress.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGenProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenProgress.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenProgress.Location = new System.Drawing.Point(26, 225);
            this.btnGenProgress.Name = "btnGenProgress";
            this.btnGenProgress.Size = new System.Drawing.Size(169, 55);
            this.btnGenProgress.TabIndex = 10;
            this.btnGenProgress.Text = "Generar Progreso";
            this.btnGenProgress.UseVisualStyleBackColor = false;
            this.btnGenProgress.Click += new System.EventHandler(this.btnGenProgress_Click);
            // 
            // btnConsEjer
            // 
            this.btnConsEjer.BackColor = System.Drawing.Color.Coral;
            this.btnConsEjer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsEjer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsEjer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsEjer.Location = new System.Drawing.Point(245, 225);
            this.btnConsEjer.Name = "btnConsEjer";
            this.btnConsEjer.Size = new System.Drawing.Size(169, 55);
            this.btnConsEjer.TabIndex = 11;
            this.btnConsEjer.Text = "Consultar Ejercicio";
            this.btnConsEjer.UseVisualStyleBackColor = false;
            this.btnConsEjer.Click += new System.EventHandler(this.btnConsEjer_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(169, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "Numero Usuario";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(148, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Numero Usuario";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Coral;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Location = new System.Drawing.Point(1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(440, 33);
            this.panel2.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Final_Sim.Properties.Resources.iconfinder_icon_close_211652;
            this.pictureBox1.Location = new System.Drawing.Point(409, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(28, 31);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto_Final_Sim.Properties.Resources.iconfinder_icon_close_211652;
            this.pictureBox2.Location = new System.Drawing.Point(760, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // btnIMactual
            // 
            this.btnIMactual.BackColor = System.Drawing.Color.Coral;
            this.btnIMactual.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIMactual.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIMactual.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnIMactual.Location = new System.Drawing.Point(26, 111);
            this.btnIMactual.Name = "btnIMactual";
            this.btnIMactual.Size = new System.Drawing.Size(169, 55);
            this.btnIMactual.TabIndex = 15;
            this.btnIMactual.Text = "IMC y Masa Muscular Actual";
            this.btnIMactual.UseVisualStyleBackColor = false;
            this.btnIMactual.Click += new System.EventHandler(this.btnIMactual_Click);
            // 
            // btnConsRE
            // 
            this.btnConsRE.BackColor = System.Drawing.Color.Coral;
            this.btnConsRE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsRE.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsRE.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConsRE.Location = new System.Drawing.Point(245, 111);
            this.btnConsRE.Name = "btnConsRE";
            this.btnConsRE.Size = new System.Drawing.Size(169, 55);
            this.btnConsRE.TabIndex = 16;
            this.btnConsRE.Text = "Consultar Rutina De Ejercicio";
            this.btnConsRE.UseVisualStyleBackColor = false;
            this.btnConsRE.Click += new System.EventHandler(this.btnConsRE_Click);
            // 
            // Formulario_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkTurquoise;
            this.ClientSize = new System.Drawing.Size(440, 305);
            this.Controls.Add(this.btnConsRE);
            this.Controls.Add(this.btnIMactual);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnConsEjer);
            this.Controls.Add(this.btnGenProgress);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Formulario_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario_Menu";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnGenProgress;
        private System.Windows.Forms.Button btnConsEjer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnIMactual;
        private System.Windows.Forms.Button btnConsRE;
    }
}