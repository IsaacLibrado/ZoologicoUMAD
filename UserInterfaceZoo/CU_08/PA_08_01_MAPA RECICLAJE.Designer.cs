
namespace UserInterfaceZoo.CU_08
{
    partial class PA_08_01_MAPA_RECICLAJE
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
            this.btnInformacion = new System.Windows.Forms.Button();
            this.btnRestaurante = new System.Windows.Forms.Button();
            this.btnSimbologia = new System.Windows.Forms.Button();
            this.pictureBoxMapa = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMapa)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(437, 283);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click_1);
            // 
            // btnInformacion
            // 
            this.btnInformacion.Location = new System.Drawing.Point(107, 283);
            this.btnInformacion.Name = "btnInformacion";
            this.btnInformacion.Size = new System.Drawing.Size(94, 23);
            this.btnInformacion.TabIndex = 2;
            this.btnInformacion.Text = "Información ♻️";
            this.btnInformacion.UseVisualStyleBackColor = true;
            this.btnInformacion.Click += new System.EventHandler(this.btnInformacion_Click);
            // 
            // btnRestaurante
            // 
            this.btnRestaurante.Location = new System.Drawing.Point(207, 283);
            this.btnRestaurante.Name = "btnRestaurante";
            this.btnRestaurante.Size = new System.Drawing.Size(94, 23);
            this.btnRestaurante.TabIndex = 3;
            this.btnRestaurante.Text = "Desechos ♻️";
            this.btnRestaurante.UseVisualStyleBackColor = true;
            this.btnRestaurante.Click += new System.EventHandler(this.btnRestaurante_Click);
            // 
            // btnSimbologia
            // 
            this.btnSimbologia.Location = new System.Drawing.Point(12, 283);
            this.btnSimbologia.Name = "btnSimbologia";
            this.btnSimbologia.Size = new System.Drawing.Size(89, 23);
            this.btnSimbologia.TabIndex = 4;
            this.btnSimbologia.Text = "Simbología ♻️";
            this.btnSimbologia.UseVisualStyleBackColor = true;
            this.btnSimbologia.Click += new System.EventHandler(this.btnBasura_Click);
            // 
            // pictureBoxMapa
            // 
            this.pictureBoxMapa.Image = global::UserInterfaceZoo.Properties.Resources.MAPA_CU_08_VERSION_FINAL;
            this.pictureBoxMapa.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxMapa.Name = "pictureBoxMapa";
            this.pictureBoxMapa.Size = new System.Drawing.Size(500, 265);
            this.pictureBoxMapa.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMapa.TabIndex = 0;
            this.pictureBoxMapa.TabStop = false;
            // 
            // PA_08_01_MAPA_RECICLAJE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 320);
            this.Controls.Add(this.btnSimbologia);
            this.Controls.Add(this.btnRestaurante);
            this.Controls.Add(this.btnInformacion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.pictureBoxMapa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PA_08_01_MAPA_RECICLAJE";
            this.Text = "PA_08_01_MAPA_RECICLAJE";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMapa)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMapa;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnInformacion;
        private System.Windows.Forms.Button btnRestaurante;
        private System.Windows.Forms.Button btnSimbologia;
    }
}