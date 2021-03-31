namespace UserInterfaceZoo
{
    partial class PA_02_04_Cerrar_Caja
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
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.cmbCaja = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txbFaltaSobra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbSouvenir = new System.Windows.Forms.RadioButton();
            this.rbBoleto = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.lblGanancias = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRegresar.Location = new System.Drawing.Point(398, 210);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(102, 36);
            this.btnRegresar.TabIndex = 21;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCerrar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnCerrar.Location = new System.Drawing.Point(398, 146);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(102, 36);
            this.btnCerrar.TabIndex = 20;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = false;
            // 
            // cmbCaja
            // 
            this.cmbCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbCaja.FormattingEnabled = true;
            this.cmbCaja.Items.AddRange(new object[] {
            "01",
            "02",
            "03"});
            this.cmbCaja.Location = new System.Drawing.Point(25, 217);
            this.cmbCaja.Name = "cmbCaja";
            this.cmbCaja.Size = new System.Drawing.Size(121, 24);
            this.cmbCaja.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(218, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 17;
            this.label4.Text = "Ganancias";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(20, 189);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Caja:";
            // 
            // txbFaltaSobra
            // 
            this.txbFaltaSobra.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txbFaltaSobra.Location = new System.Drawing.Point(368, 73);
            this.txbFaltaSobra.Name = "txbFaltaSobra";
            this.txbFaltaSobra.Size = new System.Drawing.Size(108, 30);
            this.txbFaltaSobra.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(322, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(209, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Faltantes o Sobrantes:";
            // 
            // rbSouvenir
            // 
            this.rbSouvenir.AutoSize = true;
            this.rbSouvenir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbSouvenir.Location = new System.Drawing.Point(25, 100);
            this.rbSouvenir.Name = "rbSouvenir";
            this.rbSouvenir.Size = new System.Drawing.Size(82, 21);
            this.rbSouvenir.TabIndex = 13;
            this.rbSouvenir.TabStop = true;
            this.rbSouvenir.Text = "Souvenir";
            this.rbSouvenir.UseVisualStyleBackColor = true;
            // 
            // rbBoleto
            // 
            this.rbBoleto.AutoSize = true;
            this.rbBoleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbBoleto.Location = new System.Drawing.Point(25, 73);
            this.rbBoleto.Name = "rbBoleto";
            this.rbBoleto.Size = new System.Drawing.Size(66, 21);
            this.rbBoleto.TabIndex = 12;
            this.rbBoleto.TabStop = true;
            this.rbBoleto.Text = "Boleto";
            this.rbBoleto.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(20, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 11;
            this.label1.Text = "Tipo:";
            // 
            // lblGanancias
            // 
            this.lblGanancias.AutoSize = true;
            this.lblGanancias.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblGanancias.Location = new System.Drawing.Point(235, 125);
            this.lblGanancias.Name = "lblGanancias";
            this.lblGanancias.Size = new System.Drawing.Size(39, 25);
            this.lblGanancias.TabIndex = 22;
            this.lblGanancias.Text = "0.0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label5.Location = new System.Drawing.Point(218, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 25);
            this.label5.TabIndex = 23;
            this.label5.Text = "$";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(218, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 25);
            this.label6.TabIndex = 26;
            this.label6.Text = "$";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblMonto.Location = new System.Drawing.Point(235, 214);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(39, 25);
            this.lblMonto.TabIndex = 25;
            this.lblMonto.Text = "0.0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label8.Location = new System.Drawing.Point(218, 189);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 25);
            this.label8.TabIndex = 24;
            this.label8.Text = "Monto Caja";
            // 
            // PA_02_04_Cerrar_Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 390);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblGanancias);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.cmbCaja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbFaltaSobra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbSouvenir);
            this.Controls.Add(this.rbBoleto);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PA_02_04_Cerrar_Caja";
            this.Text = "PA_02_04_Cerrar_Caja";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ComboBox cmbCaja;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbFaltaSobra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rbSouvenir;
        private System.Windows.Forms.RadioButton rbBoleto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblGanancias;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label label8;
    }
}