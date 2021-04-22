namespace UserInterfaceZoo
{
    partial class PA_02_03_Apertura_Caja
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
            this.label1 = new System.Windows.Forms.Label();
            this.rbBoleto = new System.Windows.Forms.RadioButton();
            this.rbSouvenir = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.txbMontoInicial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbCaja = new System.Windows.Forms.ComboBox();
            this.cmbCajero = new System.Windows.Forms.ComboBox();
            this.btnAperturar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(24, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo:";
            // 
            // rbBoleto
            // 
            this.rbBoleto.AutoSize = true;
            this.rbBoleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbBoleto.Location = new System.Drawing.Point(29, 74);
            this.rbBoleto.Name = "rbBoleto";
            this.rbBoleto.Size = new System.Drawing.Size(66, 21);
            this.rbBoleto.TabIndex = 1;
            this.rbBoleto.TabStop = true;
            this.rbBoleto.Text = "Boleto";
            this.rbBoleto.UseVisualStyleBackColor = true;
            // 
            // rbSouvenir
            // 
            this.rbSouvenir.AutoSize = true;
            this.rbSouvenir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rbSouvenir.Location = new System.Drawing.Point(29, 101);
            this.rbSouvenir.Name = "rbSouvenir";
            this.rbSouvenir.Size = new System.Drawing.Size(82, 21);
            this.rbSouvenir.TabIndex = 2;
            this.rbSouvenir.TabStop = true;
            this.rbSouvenir.Text = "Souvenir";
            this.rbSouvenir.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(11, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Monto Inicial:";
            // 
            // txbMontoInicial
            // 
            this.txbMontoInicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.txbMontoInicial.Location = new System.Drawing.Point(16, 217);
            this.txbMontoInicial.Name = "txbMontoInicial";
            this.txbMontoInicial.Size = new System.Drawing.Size(108, 30);
            this.txbMontoInicial.TabIndex = 4;
            this.txbMontoInicial.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeros_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label3.Location = new System.Drawing.Point(183, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Caja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.Location = new System.Drawing.Point(183, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cajero:";
            // 
            // cmbCaja
            // 
            this.cmbCaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbCaja.FormattingEnabled = true;
            this.cmbCaja.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04"});
            this.cmbCaja.Location = new System.Drawing.Point(188, 96);
            this.cmbCaja.Name = "cmbCaja";
            this.cmbCaja.Size = new System.Drawing.Size(121, 24);
            this.cmbCaja.TabIndex = 7;
            this.cmbCaja.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeros_KeyPress);
            // 
            // cmbCajero
            // 
            this.cmbCajero.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbCajero.FormattingEnabled = true;
            this.cmbCajero.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05"});
            this.cmbCajero.Location = new System.Drawing.Point(188, 223);
            this.cmbCajero.Name = "cmbCajero";
            this.cmbCajero.Size = new System.Drawing.Size(121, 24);
            this.cmbCajero.TabIndex = 8;
            this.cmbCajero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Numeros_KeyPress);
            // 
            // btnAperturar
            // 
            this.btnAperturar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnAperturar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnAperturar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnAperturar.Location = new System.Drawing.Point(400, 68);
            this.btnAperturar.Name = "btnAperturar";
            this.btnAperturar.Size = new System.Drawing.Size(102, 36);
            this.btnAperturar.TabIndex = 9;
            this.btnAperturar.Text = "Aperturar";
            this.btnAperturar.UseVisualStyleBackColor = false;
            this.btnAperturar.Click += new System.EventHandler(this.btnAperturar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRegresar.Location = new System.Drawing.Point(400, 211);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(102, 36);
            this.btnRegresar.TabIndex = 10;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // PA_02_03_Apertura_Caja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(700, 390);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnAperturar);
            this.Controls.Add(this.cmbCajero);
            this.Controls.Add(this.cmbCaja);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txbMontoInicial);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbSouvenir);
            this.Controls.Add(this.rbBoleto);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PA_02_03_Apertura_Caja";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "PA_02_03_Apertura_Caja";
            this.Load += new System.EventHandler(this.PA_02_03_Apertura_Caja_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbBoleto;
        private System.Windows.Forms.RadioButton rbSouvenir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbMontoInicial;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbCaja;
        private System.Windows.Forms.ComboBox cmbCajero;
        private System.Windows.Forms.Button btnAperturar;
        private System.Windows.Forms.Button btnRegresar;
    }
}