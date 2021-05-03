
namespace UserInterfaceZoo.CU_SinDefinir
{
    partial class CU_07_GestionarMaquina
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
            this.ib_contenido = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ib_contenido)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ib_contenido
            // 
            this.ib_contenido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ib_contenido.Image = global::UserInterfaceZoo.Properties.Resources.CU_07;
            this.ib_contenido.Location = new System.Drawing.Point(3, 3);
            this.ib_contenido.Name = "ib_contenido";
            this.ib_contenido.Size = new System.Drawing.Size(607, 481);
            this.ib_contenido.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ib_contenido.TabIndex = 3;
            this.ib_contenido.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.ib_contenido);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(571, 256);
            this.panel1.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(177)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(15, 273);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 31);
            this.button1.TabIndex = 13;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CU_07_GestionarMaquina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 315);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CU_07_GestionarMaquina";
            this.Text = "CU_03_ApartadoBoletos";
            ((System.ComponentModel.ISupportInitialize)(this.ib_contenido)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ib_contenido;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}