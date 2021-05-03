
namespace UserInterfaceZoo.CU_08
{
    partial class PA_08_04_SIMBOLOGIA
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
            this.lblBote = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblActividad = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMaquina = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBote
            // 
            this.lblBote.AutoSize = true;
            this.lblBote.Location = new System.Drawing.Point(110, 49);
            this.lblBote.Name = "lblBote";
            this.lblBote.Size = new System.Drawing.Size(275, 13);
            this.lblBote.TabIndex = 1;
            this.lblBote.Text = "LUGARES DONDE ENCONTRAR BOTES DE BASURA";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(463, 285);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Location = new System.Drawing.Point(110, 136);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(289, 13);
            this.lblActividad.TabIndex = 4;
            this.lblActividad.Text = "ACTIVIDADES RECREATIVAS A FAVOR DEL RECICLAJE";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::UserInterfaceZoo.Properties.Resources.expendedora;
            this.pictureBox3.Location = new System.Drawing.Point(12, 186);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(92, 81);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UserInterfaceZoo.Properties.Resources.actividad;
            this.pictureBox2.Location = new System.Drawing.Point(12, 99);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(92, 81);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UserInterfaceZoo.Properties.Resources.bote_de_basura;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 81);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblMaquina
            // 
            this.lblMaquina.AutoSize = true;
            this.lblMaquina.Location = new System.Drawing.Point(111, 220);
            this.lblMaquina.Name = "lblMaquina";
            this.lblMaquina.Size = new System.Drawing.Size(317, 13);
            this.lblMaquina.TabIndex = 6;
            this.lblMaquina.Text = "MÁQUINA EXPENDEDORA QUE RECIBE LATAS RECICLADAS";
            // 
            // PA_08_04_SIMBOLOGIA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 320);
            this.Controls.Add(this.lblMaquina);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.lblActividad);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lblBote);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PA_08_04_SIMBOLOGIA";
            this.Text = "PA_08_04_SIMBOLOGIA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblBote;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lblMaquina;
    }
}