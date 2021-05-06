
namespace UserInterfaceZoo.CU_05
{
    partial class PA_05_27_Emergencias
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
            this.BtnEvacuacion = new System.Windows.Forms.Button();
            this.BtnAccidente = new System.Windows.Forms.Button();
            this.BtnHerido = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnEvacuacion
            // 
            this.BtnEvacuacion.Location = new System.Drawing.Point(278, 162);
            this.BtnEvacuacion.Name = "BtnEvacuacion";
            this.BtnEvacuacion.Size = new System.Drawing.Size(118, 71);
            this.BtnEvacuacion.TabIndex = 0;
            this.BtnEvacuacion.Text = "Evacuación";
            this.BtnEvacuacion.UseVisualStyleBackColor = true;
            this.BtnEvacuacion.Click += new System.EventHandler(this.BtnEvacuacion_Click);
            // 
            // BtnAccidente
            // 
            this.BtnAccidente.Location = new System.Drawing.Point(121, 162);
            this.BtnAccidente.Name = "BtnAccidente";
            this.BtnAccidente.Size = new System.Drawing.Size(128, 71);
            this.BtnAccidente.TabIndex = 1;
            this.BtnAccidente.Text = "Accidente";
            this.BtnAccidente.UseVisualStyleBackColor = true;
            this.BtnAccidente.Click += new System.EventHandler(this.BtnAccidente_Click);
            // 
            // BtnHerido
            // 
            this.BtnHerido.Location = new System.Drawing.Point(421, 162);
            this.BtnHerido.Name = "BtnHerido";
            this.BtnHerido.Size = new System.Drawing.Size(135, 71);
            this.BtnHerido.TabIndex = 2;
            this.BtnHerido.Text = "Herido";
            this.BtnHerido.UseVisualStyleBackColor = true;
            this.BtnHerido.Click += new System.EventHandler(this.BtnHerido_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(182, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Seleccione la emergencia que tenga\r\n";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(613, 354);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 275);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 25);
            this.label2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(265, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 25);
            this.label3.TabIndex = 6;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(382, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 25);
            this.label4.TabIndex = 7;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // PA_05_26_Emergencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 488);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnHerido);
            this.Controls.Add(this.BtnAccidente);
            this.Controls.Add(this.BtnEvacuacion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PA_05_26_Emergencias";
            this.Text = "PA_05__26_Emergencias";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnEvacuacion;
        private System.Windows.Forms.Button BtnAccidente;
        private System.Windows.Forms.Button BtnHerido;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}