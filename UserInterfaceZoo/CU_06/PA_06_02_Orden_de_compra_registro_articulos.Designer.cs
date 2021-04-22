﻿namespace UserInterfaceZoo
{
    partial class PA_06_02_Orden_de_compra_registro_articulos
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridViewArticulos = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNumeroArticulo = new System.Windows.Forms.TextBox();
            this.lblDescripcionArticulo = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtUnidadPeso = new System.Windows.Forms.TextBox();
            this.lblPrecioUnitario = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnRegresar = new System.Windows.Forms.Button();
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.lblDatosP2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblFechaRecp_p2 = new System.Windows.Forms.Label();
            this.lblNoOrden_p2 = new System.Windows.Forms.Label();
            this.dateTimeRecp_p2 = new System.Windows.Forms.Label();
            this.dateTimePago_p2 = new System.Windows.Forms.Label();
            this.lblCompaProv_p2 = new System.Windows.Forms.Label();
            this.lblContacto_p2 = new System.Windows.Forms.Label();
            this.lblCargo_p2 = new System.Windows.Forms.Label();
            this.lblDomProv_p2 = new System.Windows.Forms.Label();
            this.lblTelProv_p2 = new System.Windows.Forms.Label();
            this.listBoxCompa_p2 = new System.Windows.Forms.Label();
            this.listBoxDepar_p2 = new System.Windows.Forms.Label();
            this.lblDomDepa_p2 = new System.Windows.Forms.Label();
            this.lblTelDepa_p2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agregar artículo\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 143);
            this.label2.TabIndex = 2;
            this.label2.Text = "Número/Nombre de articulo:\r\n\r\nDescripción de artículo:\r\n\r\nCantidad\r\n\r\nUnidad de p" +
    "eso:\r\n\r\nPrecio Unitario:\r\n\r\nTotal:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(241, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Artículos registrados";
            // 
            // dataGridViewArticulos
            // 
            this.dataGridViewArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Descuento,
            this.Cantidad,
            this.PrecioUnitario,
            this.Total});
            this.dataGridViewArticulos.Location = new System.Drawing.Point(243, 46);
            this.dataGridViewArticulos.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewArticulos.Name = "dataGridViewArticulos";
            this.dataGridViewArticulos.RowHeadersWidth = 51;
            this.dataGridViewArticulos.RowTemplate.Height = 24;
            this.dataGridViewArticulos.Size = new System.Drawing.Size(346, 152);
            this.dataGridViewArticulos.TabIndex = 4;
            // 
            // Numero
            // 
            this.Numero.HeaderText = "No.";
            this.Numero.MinimumWidth = 6;
            this.Numero.Name = "Numero";
            this.Numero.Width = 35;
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Desc.";
            this.Descuento.MinimumWidth = 6;
            this.Descuento.Name = "Descuento";
            this.Descuento.Width = 45;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.MinimumWidth = 6;
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Width = 70;
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.HeaderText = "Precio Uni.";
            this.PrecioUnitario.MinimumWidth = 6;
            this.PrecioUnitario.Name = "PrecioUnitario";
            this.PrecioUnitario.Width = 80;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.Width = 80;
            // 
            // txtNumeroArticulo
            // 
            this.txtNumeroArticulo.Location = new System.Drawing.Point(154, 46);
            this.txtNumeroArticulo.Margin = new System.Windows.Forms.Padding(2);
            this.txtNumeroArticulo.Name = "txtNumeroArticulo";
            this.txtNumeroArticulo.Size = new System.Drawing.Size(86, 20);
            this.txtNumeroArticulo.TabIndex = 5;
            this.txtNumeroArticulo.Text = "Ingresa número/nombre";
            // 
            // lblDescripcionArticulo
            // 
            this.lblDescripcionArticulo.AutoSize = true;
            this.lblDescripcionArticulo.Location = new System.Drawing.Point(132, 75);
            this.lblDescripcionArticulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcionArticulo.Name = "lblDescripcionArticulo";
            this.lblDescripcionArticulo.Size = new System.Drawing.Size(0, 13);
            this.lblDescripcionArticulo.TabIndex = 6;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(62, 104);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(155, 20);
            this.txtCantidad.TabIndex = 7;
            this.txtCantidad.Text = "Ingresa cantidad";
            // 
            // txtUnidadPeso
            // 
            this.txtUnidadPeso.Location = new System.Drawing.Point(94, 127);
            this.txtUnidadPeso.Margin = new System.Windows.Forms.Padding(2);
            this.txtUnidadPeso.Name = "txtUnidadPeso";
            this.txtUnidadPeso.Size = new System.Drawing.Size(123, 20);
            this.txtUnidadPeso.TabIndex = 8;
            this.txtUnidadPeso.Text = "Ingresa unidad de peso";
            // 
            // lblPrecioUnitario
            // 
            this.lblPrecioUnitario.AutoSize = true;
            this.lblPrecioUnitario.Location = new System.Drawing.Point(92, 154);
            this.lblPrecioUnitario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrecioUnitario.Name = "lblPrecioUnitario";
            this.lblPrecioUnitario.Size = new System.Drawing.Size(0, 13);
            this.lblPrecioUnitario.TabIndex = 9;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(50, 184);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 13);
            this.lblTotal.TabIndex = 10;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(62, 214);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 31);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(28, 270);
            this.btnRegresar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 31);
            this.btnRegresar.TabIndex = 12;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.Location = new System.Drawing.Point(134, 270);
            this.btnSiguiente.Margin = new System.Windows.Forms.Padding(2);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(68, 31);
            this.btnSiguiente.TabIndex = 13;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // lblDatosP2
            // 
            this.lblDatosP2.AutoSize = true;
            this.lblDatosP2.Location = new System.Drawing.Point(286, 98);
            this.lblDatosP2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDatosP2.Name = "lblDatosP2";
            this.lblDatosP2.Size = new System.Drawing.Size(35, 13);
            this.lblDatosP2.TabIndex = 15;
            this.lblDatosP2.Text = "label5";
            this.lblDatosP2.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 98);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "label5";
            this.label4.Visible = false;
            // 
            // lblFechaRecp_p2
            // 
            this.lblFechaRecp_p2.AutoSize = true;
            this.lblFechaRecp_p2.Location = new System.Drawing.Point(404, 98);
            this.lblFechaRecp_p2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblFechaRecp_p2.Name = "lblFechaRecp_p2";
            this.lblFechaRecp_p2.Size = new System.Drawing.Size(35, 13);
            this.lblFechaRecp_p2.TabIndex = 17;
            this.lblFechaRecp_p2.Text = "label5";
            this.lblFechaRecp_p2.Visible = false;
            // 
            // lblNoOrden_p2
            // 
            this.lblNoOrden_p2.AutoSize = true;
            this.lblNoOrden_p2.Location = new System.Drawing.Point(466, 98);
            this.lblNoOrden_p2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNoOrden_p2.Name = "lblNoOrden_p2";
            this.lblNoOrden_p2.Size = new System.Drawing.Size(35, 13);
            this.lblNoOrden_p2.TabIndex = 18;
            this.lblNoOrden_p2.Text = "label5";
            this.lblNoOrden_p2.Visible = false;
            // 
            // dateTimeRecp_p2
            // 
            this.dateTimeRecp_p2.AutoSize = true;
            this.dateTimeRecp_p2.Location = new System.Drawing.Point(286, 107);
            this.dateTimeRecp_p2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateTimeRecp_p2.Name = "dateTimeRecp_p2";
            this.dateTimeRecp_p2.Size = new System.Drawing.Size(35, 13);
            this.dateTimeRecp_p2.TabIndex = 19;
            this.dateTimeRecp_p2.Text = "label5";
            this.dateTimeRecp_p2.Visible = false;
            // 
            // dateTimePago_p2
            // 
            this.dateTimePago_p2.AutoSize = true;
            this.dateTimePago_p2.Location = new System.Drawing.Point(286, 115);
            this.dateTimePago_p2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dateTimePago_p2.Name = "dateTimePago_p2";
            this.dateTimePago_p2.Size = new System.Drawing.Size(35, 13);
            this.dateTimePago_p2.TabIndex = 20;
            this.dateTimePago_p2.Text = "label5";
            this.dateTimePago_p2.Visible = false;
            // 
            // lblCompaProv_p2
            // 
            this.lblCompaProv_p2.AutoSize = true;
            this.lblCompaProv_p2.Location = new System.Drawing.Point(286, 140);
            this.lblCompaProv_p2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCompaProv_p2.Name = "lblCompaProv_p2";
            this.lblCompaProv_p2.Size = new System.Drawing.Size(35, 13);
            this.lblCompaProv_p2.TabIndex = 21;
            this.lblCompaProv_p2.Text = "label5";
            this.lblCompaProv_p2.Visible = false;
            // 
            // lblContacto_p2
            // 
            this.lblContacto_p2.AutoSize = true;
            this.lblContacto_p2.Location = new System.Drawing.Point(286, 154);
            this.lblContacto_p2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContacto_p2.Name = "lblContacto_p2";
            this.lblContacto_p2.Size = new System.Drawing.Size(35, 13);
            this.lblContacto_p2.TabIndex = 22;
            this.lblContacto_p2.Text = "label5";
            this.lblContacto_p2.Visible = false;
            // 
            // lblCargo_p2
            // 
            this.lblCargo_p2.AutoSize = true;
            this.lblCargo_p2.Location = new System.Drawing.Point(286, 163);
            this.lblCargo_p2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCargo_p2.Name = "lblCargo_p2";
            this.lblCargo_p2.Size = new System.Drawing.Size(35, 13);
            this.lblCargo_p2.TabIndex = 23;
            this.lblCargo_p2.Text = "label5";
            this.lblCargo_p2.Visible = false;
            // 
            // lblDomProv_p2
            // 
            this.lblDomProv_p2.AutoSize = true;
            this.lblDomProv_p2.Location = new System.Drawing.Point(286, 171);
            this.lblDomProv_p2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDomProv_p2.Name = "lblDomProv_p2";
            this.lblDomProv_p2.Size = new System.Drawing.Size(35, 13);
            this.lblDomProv_p2.TabIndex = 24;
            this.lblDomProv_p2.Text = "label5";
            this.lblDomProv_p2.Visible = false;
            // 
            // lblTelProv_p2
            // 
            this.lblTelProv_p2.AutoSize = true;
            this.lblTelProv_p2.Location = new System.Drawing.Point(286, 180);
            this.lblTelProv_p2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelProv_p2.Name = "lblTelProv_p2";
            this.lblTelProv_p2.Size = new System.Drawing.Size(35, 13);
            this.lblTelProv_p2.TabIndex = 25;
            this.lblTelProv_p2.Text = "label5";
            this.lblTelProv_p2.Visible = false;
            // 
            // listBoxCompa_p2
            // 
            this.listBoxCompa_p2.AutoSize = true;
            this.listBoxCompa_p2.Location = new System.Drawing.Point(334, 140);
            this.listBoxCompa_p2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.listBoxCompa_p2.Name = "listBoxCompa_p2";
            this.listBoxCompa_p2.Size = new System.Drawing.Size(35, 13);
            this.listBoxCompa_p2.TabIndex = 26;
            this.listBoxCompa_p2.Text = "label5";
            this.listBoxCompa_p2.Visible = false;
            // 
            // listBoxDepar_p2
            // 
            this.listBoxDepar_p2.AutoSize = true;
            this.listBoxDepar_p2.Location = new System.Drawing.Point(334, 154);
            this.listBoxDepar_p2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.listBoxDepar_p2.Name = "listBoxDepar_p2";
            this.listBoxDepar_p2.Size = new System.Drawing.Size(35, 13);
            this.listBoxDepar_p2.TabIndex = 27;
            this.listBoxDepar_p2.Text = "label5";
            this.listBoxDepar_p2.Visible = false;
            // 
            // lblDomDepa_p2
            // 
            this.lblDomDepa_p2.AutoSize = true;
            this.lblDomDepa_p2.Location = new System.Drawing.Point(334, 163);
            this.lblDomDepa_p2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDomDepa_p2.Name = "lblDomDepa_p2";
            this.lblDomDepa_p2.Size = new System.Drawing.Size(35, 13);
            this.lblDomDepa_p2.TabIndex = 28;
            this.lblDomDepa_p2.Text = "label5";
            this.lblDomDepa_p2.Visible = false;
            // 
            // lblTelDepa_p2
            // 
            this.lblTelDepa_p2.AutoSize = true;
            this.lblTelDepa_p2.Location = new System.Drawing.Point(334, 171);
            this.lblTelDepa_p2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelDepa_p2.Name = "lblTelDepa_p2";
            this.lblTelDepa_p2.Size = new System.Drawing.Size(35, 13);
            this.lblTelDepa_p2.TabIndex = 29;
            this.lblTelDepa_p2.Text = "label5";
            this.lblTelDepa_p2.Visible = false;
            // 
            // PA_06_02_Orden_de_compra_registro_articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 317);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblPrecioUnitario);
            this.Controls.Add(this.txtUnidadPeso);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.lblDescripcionArticulo);
            this.Controls.Add(this.txtNumeroArticulo);
            this.Controls.Add(this.dataGridViewArticulos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTelDepa_p2);
            this.Controls.Add(this.lblDomDepa_p2);
            this.Controls.Add(this.listBoxDepar_p2);
            this.Controls.Add(this.listBoxCompa_p2);
            this.Controls.Add(this.lblTelProv_p2);
            this.Controls.Add(this.lblDomProv_p2);
            this.Controls.Add(this.lblCargo_p2);
            this.Controls.Add(this.lblContacto_p2);
            this.Controls.Add(this.lblCompaProv_p2);
            this.Controls.Add(this.dateTimePago_p2);
            this.Controls.Add(this.dateTimeRecp_p2);
            this.Controls.Add(this.lblNoOrden_p2);
            this.Controls.Add(this.lblFechaRecp_p2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDatosP2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PA_06_02_Orden_de_compra_registro_articulos";
            this.Text = "PA_06_02_Orden_de_compra_registro_articulos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnRegresar;
        private System.Windows.Forms.Button btnSiguiente;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.DataGridView dataGridViewArticulos;
        public System.Windows.Forms.TextBox txtNumeroArticulo;
        public System.Windows.Forms.Label lblDescripcionArticulo;
        public System.Windows.Forms.TextBox txtCantidad;
        public System.Windows.Forms.TextBox txtUnidadPeso;
        public System.Windows.Forms.Label lblPrecioUnitario;
        public System.Windows.Forms.Label lblTotal;
        public System.Windows.Forms.Label lblDatosP2;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label lblFechaRecp_p2;
        public System.Windows.Forms.Label lblNoOrden_p2;
        public System.Windows.Forms.Label dateTimeRecp_p2;
        public System.Windows.Forms.Label dateTimePago_p2;
        public System.Windows.Forms.Label lblCompaProv_p2;
        public System.Windows.Forms.Label lblContacto_p2;
        public System.Windows.Forms.Label lblCargo_p2;
        public System.Windows.Forms.Label lblDomProv_p2;
        public System.Windows.Forms.Label lblTelProv_p2;
        public System.Windows.Forms.Label listBoxCompa_p2;
        public System.Windows.Forms.Label listBoxDepar_p2;
        public System.Windows.Forms.Label lblDomDepa_p2;
        public System.Windows.Forms.Label lblTelDepa_p2;
    }
}