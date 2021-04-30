namespace UserInterfaceZoo.CU_01
{
    partial class PA_01_06_Pantalla_sin_avisos
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnPersonasEntrada = new System.Windows.Forms.Button();
            this.btnPersonasSalida = new System.Windows.Forms.Button();
            this.btnAvisoFilas = new System.Windows.Forms.Button();
            this.btnTemExcedida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "No hay mensajes de alerta recientes";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.Location = new System.Drawing.Point(443, 284);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(80, 28);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnPersonasEntrada
            // 
            this.btnPersonasEntrada.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPersonasEntrada.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPersonasEntrada.Location = new System.Drawing.Point(12, 127);
            this.btnPersonasEntrada.Name = "btnPersonasEntrada";
            this.btnPersonasEntrada.Size = new System.Drawing.Size(79, 38);
            this.btnPersonasEntrada.TabIndex = 2;
            this.btnPersonasEntrada.Text = "Personas al entrar";
            this.btnPersonasEntrada.UseVisualStyleBackColor = false;
            this.btnPersonasEntrada.Click += new System.EventHandler(this.btnPersonasEntrada_Click);
            // 
            // btnPersonasSalida
            // 
            this.btnPersonasSalida.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnPersonasSalida.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPersonasSalida.Location = new System.Drawing.Point(12, 171);
            this.btnPersonasSalida.Name = "btnPersonasSalida";
            this.btnPersonasSalida.Size = new System.Drawing.Size(79, 38);
            this.btnPersonasSalida.TabIndex = 4;
            this.btnPersonasSalida.Text = "Personas al salir";
            this.btnPersonasSalida.UseVisualStyleBackColor = false;
            this.btnPersonasSalida.Click += new System.EventHandler(this.btnPersonasSalida_Click);
            // 
            // btnAvisoFilas
            // 
            this.btnAvisoFilas.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnAvisoFilas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAvisoFilas.Location = new System.Drawing.Point(12, 12);
            this.btnAvisoFilas.Name = "btnAvisoFilas";
            this.btnAvisoFilas.Size = new System.Drawing.Size(79, 53);
            this.btnAvisoFilas.TabIndex = 5;
            this.btnAvisoFilas.Text = "Aviso para las filas en la entrada";
            this.btnAvisoFilas.UseVisualStyleBackColor = false;
            this.btnAvisoFilas.Click += new System.EventHandler(this.btnAvisoFilas_Click);
            // 
            // btnTemExcedida
            // 
            this.btnTemExcedida.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnTemExcedida.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTemExcedida.Location = new System.Drawing.Point(12, 71);
            this.btnTemExcedida.Name = "btnTemExcedida";
            this.btnTemExcedida.Size = new System.Drawing.Size(79, 50);
            this.btnTemExcedida.TabIndex = 6;
            this.btnTemExcedida.Text = "Aviso de temperatura excedida";
            this.btnTemExcedida.UseVisualStyleBackColor = false;
            this.btnTemExcedida.Click += new System.EventHandler(this.btnTemExcedida_Click);
            // 
            // PA_01_06_Pantalla_sin_avisos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 351);
            this.Controls.Add(this.btnTemExcedida);
            this.Controls.Add(this.btnAvisoFilas);
            this.Controls.Add(this.btnPersonasSalida);
            this.Controls.Add(this.btnPersonasEntrada);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Name = "PA_01_06_Pantalla_sin_avisos";
            this.Text = "PA_01_06__Pantalla_sin_avisos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnPersonasEntrada;
        private System.Windows.Forms.Button btnPersonasSalida;
        private System.Windows.Forms.Button btnAvisoFilas;
        private System.Windows.Forms.Button btnTemExcedida;
    }
}