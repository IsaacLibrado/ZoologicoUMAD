﻿
namespace UserInterfaceZoo
{
    partial class PA_01_02_Menu_Cajero
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
            this.btnEntrada = new System.Windows.Forms.Button();
            this.btnEspectaculo = new System.Windows.Forms.Button();
            this.btnSouvenirs = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEntrada
            // 
            this.btnEntrada.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEntrada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEntrada.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEntrada.Location = new System.Drawing.Point(54, 166);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(140, 31);
            this.btnEntrada.TabIndex = 0;
            this.btnEntrada.Text = "Boletos Entrada";
            this.btnEntrada.UseVisualStyleBackColor = false;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // btnEspectaculo
            // 
            this.btnEspectaculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnEspectaculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEspectaculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnEspectaculo.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEspectaculo.Location = new System.Drawing.Point(263, 166);
            this.btnEspectaculo.Name = "btnEspectaculo";
            this.btnEspectaculo.Size = new System.Drawing.Size(181, 31);
            this.btnEspectaculo.TabIndex = 1;
            this.btnEspectaculo.Text = "Boletos Espectaculo";
            this.btnEspectaculo.UseVisualStyleBackColor = false;
            this.btnEspectaculo.Click += new System.EventHandler(this.btnEspectaculo_Click);
            // 
            // btnSouvenirs
            // 
            this.btnSouvenirs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSouvenirs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSouvenirs.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSouvenirs.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSouvenirs.Location = new System.Drawing.Point(499, 166);
            this.btnSouvenirs.Name = "btnSouvenirs";
            this.btnSouvenirs.Size = new System.Drawing.Size(107, 31);
            this.btnSouvenirs.TabIndex = 2;
            this.btnSouvenirs.Text = "Souvenirs";
            this.btnSouvenirs.UseVisualStyleBackColor = false;
            this.btnSouvenirs.Click += new System.EventHandler(this.btnSouvenirs_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnRegresar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRegresar.Location = new System.Drawing.Point(559, 320);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(98, 31);
            this.btnRegresar.TabIndex = 3;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // PA_01_02_Menu_Cajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(711, 436);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnSouvenirs);
            this.Controls.Add(this.btnEspectaculo);
            this.Controls.Add(this.btnEntrada);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PA_01_02_Menu_Cajero";
            this.Text = "PA_01_02_Menu_Cajero";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Button btnEspectaculo;
        private System.Windows.Forms.Button btnSouvenirs;
        private System.Windows.Forms.Button btnRegresar;
    }
}