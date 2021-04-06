
namespace UserInterfaceZoo.CU_05
{
    partial class PA_05_01_Menú_Mapa_interactivo
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
            this.btnEspectaculo = new System.Windows.Forms.Button();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnEspectaculo
            // 
            this.btnEspectaculo.AutoSize = true;
            this.btnEspectaculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEspectaculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEspectaculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEspectaculo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEspectaculo.Location = new System.Drawing.Point(377, 202);
            this.btnEspectaculo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEspectaculo.Name = "btnEspectaculo";
            this.btnEspectaculo.Size = new System.Drawing.Size(336, 46);
            this.btnEspectaculo.TabIndex = 3;
            this.btnEspectaculo.Text = "No";
            this.btnEspectaculo.UseVisualStyleBackColor = false;
            // 
            // btnEntrada
            // 
            this.btnEntrada.AutoSize = true;
            this.btnEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrada.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEntrada.Location = new System.Drawing.Point(88, 202);
            this.btnEntrada.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(284, 46);
            this.btnEntrada.TabIndex = 2;
            this.btnEntrada.Text = "Si";
            this.btnEntrada.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(354, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "¿Quieres activar tu ubicacion?";
            // 
            // PA_05_01_Ubicación
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEspectaculo);
            this.Controls.Add(this.btnEntrada);
            this.Name = "PA_05_01_Ubicación";
            this.Text = "PA_05_01_Ubicación";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEspectaculo;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Label label3;
    }
}