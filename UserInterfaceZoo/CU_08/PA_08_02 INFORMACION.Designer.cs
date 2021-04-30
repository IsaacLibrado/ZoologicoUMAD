
namespace UserInterfaceZoo.CU_08
{
    partial class PA_08_02_INFORMACION
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblInfo2 = new System.Windows.Forms.Label();
            this.lblInfo3 = new System.Windows.Forms.Label();
            this.lblInfo4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(463, 285);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // lblInfo2
            // 
            this.lblInfo2.AutoSize = true;
            this.lblInfo2.Location = new System.Drawing.Point(9, 145);
            this.lblInfo2.Name = "lblInfo2";
            this.lblInfo2.Size = new System.Drawing.Size(543, 13);
            this.lblInfo2.TabIndex = 4;
            this.lblInfo2.Text = "El reciclaje es la mejor manera de aprovechar los materiales usados porque con el" +
    "los se crean nuevos materiales. ";
            // 
            // lblInfo3
            // 
            this.lblInfo3.AutoSize = true;
            this.lblInfo3.Location = new System.Drawing.Point(9, 192);
            this.lblInfo3.Name = "lblInfo3";
            this.lblInfo3.Size = new System.Drawing.Size(441, 13);
            this.lblInfo3.TabIndex = 5;
            this.lblInfo3.Text = "Reciclar es un proceso que depende del aporte de materias primas de millones de p" +
    "ersonas,";
            // 
            // lblInfo4
            // 
            this.lblInfo4.AutoSize = true;
            this.lblInfo4.Location = new System.Drawing.Point(9, 237);
            this.lblInfo4.Name = "lblInfo4";
            this.lblInfo4.Size = new System.Drawing.Size(525, 13);
            this.lblInfo4.TabIndex = 6;
            this.lblInfo4.Text = "Por ello es la mejor ayuda para la conservación del planeta tanto para el hombre " +
    "como para el medioambiente.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UserInterfaceZoo.Properties.Resources.reciclaje;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(525, 120);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // PA_08_02_INFORMACION
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 320);
            this.Controls.Add(this.lblInfo4);
            this.Controls.Add(this.lblInfo3);
            this.Controls.Add(this.lblInfo2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PA_08_02_INFORMACION";
            this.Text = "PA_08_02_INFORMACION";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblInfo2;
        private System.Windows.Forms.Label lblInfo3;
        private System.Windows.Forms.Label lblInfo4;
    }
}