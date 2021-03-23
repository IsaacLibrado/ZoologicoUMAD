namespace UserInterfaceZoo
{
    partial class MenuPrincipal
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
            this.components = new System.ComponentModel.Container();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelUsuario = new System.Windows.Forms.Panel();
            this.lblIp = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.pbPerfil = new System.Windows.Forms.PictureBox();
            this.panelSubMenus = new System.Windows.Forms.Panel();
            this.panelInteractivoSubMenu = new System.Windows.Forms.Panel();
            this.btnSMVideojuego = new System.Windows.Forms.Button();
            this.btnSMInformacion = new System.Windows.Forms.Button();
            this.btnInteractivo = new System.Windows.Forms.Button();
            this.panelGestionSubMenu = new System.Windows.Forms.Panel();
            this.btnSMSanitizar = new System.Windows.Forms.Button();
            this.btnSMReciclado = new System.Windows.Forms.Button();
            this.btnSMMaquinaExp = new System.Windows.Forms.Button();
            this.btnGestion = new System.Windows.Forms.Button();
            this.panelComprasSubMenu = new System.Windows.Forms.Panel();
            this.btnSMAlimento = new System.Windows.Forms.Button();
            this.btnSMInventario = new System.Windows.Forms.Button();
            this.btnSMOrdenCompra = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.panelVentasSubMenu = new System.Windows.Forms.Panel();
            this.btnSMApartarBoletos = new System.Windows.Forms.Button();
            this.btnSMVender = new System.Windows.Forms.Button();
            this.btnSMCerrarCaja = new System.Windows.Forms.Button();
            this.btnSMAbrirCaja = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.panelDatos = new System.Windows.Forms.Panel();
            this.panelFecha = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblNombreZoo = new System.Windows.Forms.Label();
            this.panelBase = new System.Windows.Forms.Panel();
            this.lblMensajes = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.horaFecha = new System.Windows.Forms.Timer(this.components);
            this.pbLogoTemp = new System.Windows.Forms.PictureBox();
            this.panelSideMenu.SuspendLayout();
            this.panelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).BeginInit();
            this.panelSubMenus.SuspendLayout();
            this.panelInteractivoSubMenu.SuspendLayout();
            this.panelGestionSubMenu.SuspendLayout();
            this.panelComprasSubMenu.SuspendLayout();
            this.panelVentasSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.panelDatos.SuspendLayout();
            this.panelFecha.SuspendLayout();
            this.panelBase.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoTemp)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelSideMenu.Controls.Add(this.panelUsuario);
            this.panelSideMenu.Controls.Add(this.panelSubMenus);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(234, 561);
            this.panelSideMenu.TabIndex = 0;
            // 
            // panelUsuario
            // 
            this.panelUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelUsuario.Controls.Add(this.lblIp);
            this.panelUsuario.Controls.Add(this.lblCargo);
            this.panelUsuario.Controls.Add(this.lblUserName);
            this.panelUsuario.Controls.Add(this.pbPerfil);
            this.panelUsuario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelUsuario.Location = new System.Drawing.Point(0, 463);
            this.panelUsuario.Name = "panelUsuario";
            this.panelUsuario.Size = new System.Drawing.Size(234, 98);
            this.panelUsuario.TabIndex = 4;
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblIp.Location = new System.Drawing.Point(0, 79);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(83, 17);
            this.lblIp.TabIndex = 3;
            this.lblIp.Text = "Dirección IP";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.ForeColor = System.Drawing.Color.White;
            this.lblCargo.Location = new System.Drawing.Point(69, 54);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(46, 17);
            this.lblCargo.TabIndex = 2;
            this.lblCargo.Text = "Cargo";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.ForeColor = System.Drawing.Color.White;
            this.lblUserName.Location = new System.Drawing.Point(70, 18);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(75, 17);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "UserName";
            // 
            // pbPerfil
            // 
            this.pbPerfil.Location = new System.Drawing.Point(4, 18);
            this.pbPerfil.Name = "pbPerfil";
            this.pbPerfil.Size = new System.Drawing.Size(59, 53);
            this.pbPerfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPerfil.TabIndex = 0;
            this.pbPerfil.TabStop = false;
            // 
            // panelSubMenus
            // 
            this.panelSubMenus.AutoScroll = true;
            this.panelSubMenus.Controls.Add(this.panelInteractivoSubMenu);
            this.panelSubMenus.Controls.Add(this.btnInteractivo);
            this.panelSubMenus.Controls.Add(this.panelGestionSubMenu);
            this.panelSubMenus.Controls.Add(this.btnGestion);
            this.panelSubMenus.Controls.Add(this.panelComprasSubMenu);
            this.panelSubMenus.Controls.Add(this.btnCompras);
            this.panelSubMenus.Controls.Add(this.panelVentasSubMenu);
            this.panelSubMenus.Controls.Add(this.btnVentas);
            this.panelSubMenus.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelSubMenus.Location = new System.Drawing.Point(0, 100);
            this.panelSubMenus.Name = "panelSubMenus";
            this.panelSubMenus.Size = new System.Drawing.Size(234, 357);
            this.panelSubMenus.TabIndex = 3;
            // 
            // panelInteractivoSubMenu
            // 
            this.panelInteractivoSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelInteractivoSubMenu.Controls.Add(this.btnSMVideojuego);
            this.panelInteractivoSubMenu.Controls.Add(this.btnSMInformacion);
            this.panelInteractivoSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelInteractivoSubMenu.Location = new System.Drawing.Point(0, 595);
            this.panelInteractivoSubMenu.Name = "panelInteractivoSubMenu";
            this.panelInteractivoSubMenu.Size = new System.Drawing.Size(217, 89);
            this.panelInteractivoSubMenu.TabIndex = 8;
            // 
            // btnSMVideojuego
            // 
            this.btnSMVideojuego.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSMVideojuego.FlatAppearance.BorderSize = 0;
            this.btnSMVideojuego.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMVideojuego.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSMVideojuego.Location = new System.Drawing.Point(0, 43);
            this.btnSMVideojuego.Name = "btnSMVideojuego";
            this.btnSMVideojuego.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSMVideojuego.Size = new System.Drawing.Size(217, 40);
            this.btnSMVideojuego.TabIndex = 1;
            this.btnSMVideojuego.Text = "Videojuego";
            this.btnSMVideojuego.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMVideojuego.UseVisualStyleBackColor = true;
            this.btnSMVideojuego.Click += new System.EventHandler(this.btnSMVideojuego_Click);
            // 
            // btnSMInformacion
            // 
            this.btnSMInformacion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSMInformacion.FlatAppearance.BorderSize = 0;
            this.btnSMInformacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMInformacion.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSMInformacion.Location = new System.Drawing.Point(0, 0);
            this.btnSMInformacion.Name = "btnSMInformacion";
            this.btnSMInformacion.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSMInformacion.Size = new System.Drawing.Size(217, 43);
            this.btnSMInformacion.TabIndex = 0;
            this.btnSMInformacion.Text = "Mostrar Información";
            this.btnSMInformacion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMInformacion.UseVisualStyleBackColor = true;
            this.btnSMInformacion.Click += new System.EventHandler(this.btnSMInformacion_Click);
            // 
            // btnInteractivo
            // 
            this.btnInteractivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnInteractivo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInteractivo.FlatAppearance.BorderSize = 0;
            this.btnInteractivo.ForeColor = System.Drawing.Color.White;
            this.btnInteractivo.Location = new System.Drawing.Point(0, 550);
            this.btnInteractivo.Name = "btnInteractivo";
            this.btnInteractivo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnInteractivo.Size = new System.Drawing.Size(217, 45);
            this.btnInteractivo.TabIndex = 7;
            this.btnInteractivo.Text = "Interactivo";
            this.btnInteractivo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInteractivo.UseVisualStyleBackColor = false;
            this.btnInteractivo.Click += new System.EventHandler(this.btnInteractivo_Click);
            // 
            // panelGestionSubMenu
            // 
            this.panelGestionSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelGestionSubMenu.Controls.Add(this.btnSMSanitizar);
            this.panelGestionSubMenu.Controls.Add(this.btnSMReciclado);
            this.panelGestionSubMenu.Controls.Add(this.btnSMMaquinaExp);
            this.panelGestionSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGestionSubMenu.Location = new System.Drawing.Point(0, 420);
            this.panelGestionSubMenu.Name = "panelGestionSubMenu";
            this.panelGestionSubMenu.Size = new System.Drawing.Size(217, 130);
            this.panelGestionSubMenu.TabIndex = 6;
            // 
            // btnSMSanitizar
            // 
            this.btnSMSanitizar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSMSanitizar.FlatAppearance.BorderSize = 0;
            this.btnSMSanitizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMSanitizar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSMSanitizar.Location = new System.Drawing.Point(0, 83);
            this.btnSMSanitizar.Name = "btnSMSanitizar";
            this.btnSMSanitizar.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSMSanitizar.Size = new System.Drawing.Size(217, 40);
            this.btnSMSanitizar.TabIndex = 2;
            this.btnSMSanitizar.Text = "Sanitizar";
            this.btnSMSanitizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMSanitizar.UseVisualStyleBackColor = true;
            this.btnSMSanitizar.Click += new System.EventHandler(this.btnSMSanitizar_Click);
            // 
            // btnSMReciclado
            // 
            this.btnSMReciclado.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSMReciclado.FlatAppearance.BorderSize = 0;
            this.btnSMReciclado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMReciclado.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSMReciclado.Location = new System.Drawing.Point(0, 43);
            this.btnSMReciclado.Name = "btnSMReciclado";
            this.btnSMReciclado.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSMReciclado.Size = new System.Drawing.Size(217, 40);
            this.btnSMReciclado.TabIndex = 1;
            this.btnSMReciclado.Text = "Reciclado";
            this.btnSMReciclado.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMReciclado.UseVisualStyleBackColor = true;
            this.btnSMReciclado.Click += new System.EventHandler(this.btnSMReciclado_Click);
            // 
            // btnSMMaquinaExp
            // 
            this.btnSMMaquinaExp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSMMaquinaExp.FlatAppearance.BorderSize = 0;
            this.btnSMMaquinaExp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMMaquinaExp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSMMaquinaExp.Location = new System.Drawing.Point(0, 0);
            this.btnSMMaquinaExp.Name = "btnSMMaquinaExp";
            this.btnSMMaquinaExp.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSMMaquinaExp.Size = new System.Drawing.Size(217, 43);
            this.btnSMMaquinaExp.TabIndex = 0;
            this.btnSMMaquinaExp.Text = "Maquina Expendedora";
            this.btnSMMaquinaExp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMMaquinaExp.UseVisualStyleBackColor = true;
            this.btnSMMaquinaExp.Click += new System.EventHandler(this.btnSMMaquinaExp_Click);
            // 
            // btnGestion
            // 
            this.btnGestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGestion.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestion.FlatAppearance.BorderSize = 0;
            this.btnGestion.ForeColor = System.Drawing.Color.White;
            this.btnGestion.Location = new System.Drawing.Point(0, 375);
            this.btnGestion.Name = "btnGestion";
            this.btnGestion.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnGestion.Size = new System.Drawing.Size(217, 45);
            this.btnGestion.TabIndex = 5;
            this.btnGestion.Text = "Gestion";
            this.btnGestion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGestion.UseVisualStyleBackColor = false;
            this.btnGestion.Click += new System.EventHandler(this.btnGestion_Click);
            // 
            // panelComprasSubMenu
            // 
            this.panelComprasSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelComprasSubMenu.Controls.Add(this.btnSMAlimento);
            this.panelComprasSubMenu.Controls.Add(this.btnSMInventario);
            this.panelComprasSubMenu.Controls.Add(this.btnSMOrdenCompra);
            this.panelComprasSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelComprasSubMenu.Location = new System.Drawing.Point(0, 250);
            this.panelComprasSubMenu.Name = "panelComprasSubMenu";
            this.panelComprasSubMenu.Size = new System.Drawing.Size(217, 125);
            this.panelComprasSubMenu.TabIndex = 4;
            // 
            // btnSMAlimento
            // 
            this.btnSMAlimento.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSMAlimento.FlatAppearance.BorderSize = 0;
            this.btnSMAlimento.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMAlimento.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSMAlimento.Location = new System.Drawing.Point(0, 80);
            this.btnSMAlimento.Name = "btnSMAlimento";
            this.btnSMAlimento.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSMAlimento.Size = new System.Drawing.Size(217, 40);
            this.btnSMAlimento.TabIndex = 2;
            this.btnSMAlimento.Text = "Comprar alimento";
            this.btnSMAlimento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMAlimento.UseVisualStyleBackColor = true;
            this.btnSMAlimento.Click += new System.EventHandler(this.btnSMAlimento_Click);
            // 
            // btnSMInventario
            // 
            this.btnSMInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSMInventario.FlatAppearance.BorderSize = 0;
            this.btnSMInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMInventario.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSMInventario.Location = new System.Drawing.Point(0, 40);
            this.btnSMInventario.Name = "btnSMInventario";
            this.btnSMInventario.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSMInventario.Size = new System.Drawing.Size(217, 40);
            this.btnSMInventario.TabIndex = 1;
            this.btnSMInventario.Text = "Mostrar Inventario";
            this.btnSMInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMInventario.UseVisualStyleBackColor = true;
            this.btnSMInventario.Click += new System.EventHandler(this.btnSMInventario_Click);
            // 
            // btnSMOrdenCompra
            // 
            this.btnSMOrdenCompra.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSMOrdenCompra.FlatAppearance.BorderSize = 0;
            this.btnSMOrdenCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMOrdenCompra.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSMOrdenCompra.Location = new System.Drawing.Point(0, 0);
            this.btnSMOrdenCompra.Name = "btnSMOrdenCompra";
            this.btnSMOrdenCompra.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSMOrdenCompra.Size = new System.Drawing.Size(217, 40);
            this.btnSMOrdenCompra.TabIndex = 0;
            this.btnSMOrdenCompra.Text = "OrdenCompra";
            this.btnSMOrdenCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMOrdenCompra.UseVisualStyleBackColor = true;
            this.btnSMOrdenCompra.Click += new System.EventHandler(this.btnSMOrdenCompra_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnCompras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompras.FlatAppearance.BorderSize = 0;
            this.btnCompras.ForeColor = System.Drawing.Color.White;
            this.btnCompras.Location = new System.Drawing.Point(0, 205);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnCompras.Size = new System.Drawing.Size(217, 45);
            this.btnCompras.TabIndex = 3;
            this.btnCompras.Text = "Compras";
            this.btnCompras.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompras.UseVisualStyleBackColor = false;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // panelVentasSubMenu
            // 
            this.panelVentasSubMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelVentasSubMenu.Controls.Add(this.btnSMApartarBoletos);
            this.panelVentasSubMenu.Controls.Add(this.btnSMVender);
            this.panelVentasSubMenu.Controls.Add(this.btnSMCerrarCaja);
            this.panelVentasSubMenu.Controls.Add(this.btnSMAbrirCaja);
            this.panelVentasSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelVentasSubMenu.Location = new System.Drawing.Point(0, 45);
            this.panelVentasSubMenu.Name = "panelVentasSubMenu";
            this.panelVentasSubMenu.Size = new System.Drawing.Size(217, 160);
            this.panelVentasSubMenu.TabIndex = 2;
            // 
            // btnSMApartarBoletos
            // 
            this.btnSMApartarBoletos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSMApartarBoletos.FlatAppearance.BorderSize = 0;
            this.btnSMApartarBoletos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMApartarBoletos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSMApartarBoletos.Location = new System.Drawing.Point(0, 120);
            this.btnSMApartarBoletos.Name = "btnSMApartarBoletos";
            this.btnSMApartarBoletos.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSMApartarBoletos.Size = new System.Drawing.Size(217, 40);
            this.btnSMApartarBoletos.TabIndex = 3;
            this.btnSMApartarBoletos.Text = "Apartar Boletos";
            this.btnSMApartarBoletos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMApartarBoletos.UseVisualStyleBackColor = true;
            this.btnSMApartarBoletos.Click += new System.EventHandler(this.btnSMApartarBoletos_Click);
            // 
            // btnSMVender
            // 
            this.btnSMVender.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSMVender.FlatAppearance.BorderSize = 0;
            this.btnSMVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMVender.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSMVender.Location = new System.Drawing.Point(0, 80);
            this.btnSMVender.Name = "btnSMVender";
            this.btnSMVender.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSMVender.Size = new System.Drawing.Size(217, 40);
            this.btnSMVender.TabIndex = 2;
            this.btnSMVender.Text = "Vender";
            this.btnSMVender.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMVender.UseVisualStyleBackColor = true;
            this.btnSMVender.Click += new System.EventHandler(this.btnSMVender_Click);
            // 
            // btnSMCerrarCaja
            // 
            this.btnSMCerrarCaja.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSMCerrarCaja.FlatAppearance.BorderSize = 0;
            this.btnSMCerrarCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMCerrarCaja.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSMCerrarCaja.Location = new System.Drawing.Point(0, 40);
            this.btnSMCerrarCaja.Name = "btnSMCerrarCaja";
            this.btnSMCerrarCaja.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSMCerrarCaja.Size = new System.Drawing.Size(217, 40);
            this.btnSMCerrarCaja.TabIndex = 1;
            this.btnSMCerrarCaja.Text = "Cerrar Caja";
            this.btnSMCerrarCaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMCerrarCaja.UseVisualStyleBackColor = true;
            this.btnSMCerrarCaja.Click += new System.EventHandler(this.btnSMCerrarCaja_Click);
            // 
            // btnSMAbrirCaja
            // 
            this.btnSMAbrirCaja.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSMAbrirCaja.FlatAppearance.BorderSize = 0;
            this.btnSMAbrirCaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSMAbrirCaja.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnSMAbrirCaja.Location = new System.Drawing.Point(0, 0);
            this.btnSMAbrirCaja.Name = "btnSMAbrirCaja";
            this.btnSMAbrirCaja.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnSMAbrirCaja.Size = new System.Drawing.Size(217, 40);
            this.btnSMAbrirCaja.TabIndex = 0;
            this.btnSMAbrirCaja.Text = "Abrir Caja";
            this.btnSMAbrirCaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSMAbrirCaja.UseVisualStyleBackColor = true;
            this.btnSMAbrirCaja.Click += new System.EventHandler(this.btnSMAbrirCaja_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVentas.FlatAppearance.BorderSize = 0;
            this.btnVentas.ForeColor = System.Drawing.Color.White;
            this.btnVentas.Location = new System.Drawing.Point(0, 0);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnVentas.Size = new System.Drawing.Size(217, 45);
            this.btnVentas.TabIndex = 1;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVentas.UseVisualStyleBackColor = false;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pbLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(234, 100);
            this.panelLogo.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Image = global::UserInterfaceZoo.Properties.Resources.logo_zootopia;
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(234, 100);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 0;
            this.pbLogo.TabStop = false;
            // 
            // panelDatos
            // 
            this.panelDatos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panelDatos.Controls.Add(this.pbLogoTemp);
            this.panelDatos.Controls.Add(this.panelFecha);
            this.panelDatos.Controls.Add(this.lblNombreZoo);
            this.panelDatos.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDatos.Location = new System.Drawing.Point(234, 0);
            this.panelDatos.Name = "panelDatos";
            this.panelDatos.Size = new System.Drawing.Size(700, 100);
            this.panelDatos.TabIndex = 1;
            // 
            // panelFecha
            // 
            this.panelFecha.Controls.Add(this.lblFecha);
            this.panelFecha.Controls.Add(this.lblHora);
            this.panelFecha.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelFecha.Location = new System.Drawing.Point(553, 0);
            this.panelFecha.Name = "panelFecha";
            this.panelFecha.Size = new System.Drawing.Size(147, 100);
            this.panelFecha.TabIndex = 1;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(0, 50);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(67, 25);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(0, 75);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(54, 25);
            this.lblHora.TabIndex = 0;
            this.lblHora.Text = "Hora";
            // 
            // lblNombreZoo
            // 
            this.lblNombreZoo.AutoSize = true;
            this.lblNombreZoo.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreZoo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblNombreZoo.Location = new System.Drawing.Point(162, 36);
            this.lblNombreZoo.Name = "lblNombreZoo";
            this.lblNombreZoo.Size = new System.Drawing.Size(350, 39);
            this.lblNombreZoo.TabIndex = 0;
            this.lblNombreZoo.Text = "Zootopia S.A. de C.V.";
            // 
            // panelBase
            // 
            this.panelBase.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panelBase.Controls.Add(this.lblMensajes);
            this.panelBase.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBase.Location = new System.Drawing.Point(234, 520);
            this.panelBase.Name = "panelBase";
            this.panelBase.Size = new System.Drawing.Size(700, 41);
            this.panelBase.TabIndex = 2;
            // 
            // lblMensajes
            // 
            this.lblMensajes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMensajes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensajes.ForeColor = System.Drawing.Color.Red;
            this.lblMensajes.Location = new System.Drawing.Point(0, 5);
            this.lblMensajes.Name = "lblMensajes";
            this.lblMensajes.Size = new System.Drawing.Size(697, 27);
            this.lblMensajes.TabIndex = 1;
            this.lblMensajes.Text = "MSJ0";
            this.lblMensajes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panelTitulo.Controls.Add(this.lblTitulo);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(234, 100);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(700, 30);
            this.panelTitulo.TabIndex = 3;
            // 
            // lblTitulo
            // 
            this.lblTitulo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Red;
            this.lblTitulo.Location = new System.Drawing.Point(29, 3);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(650, 27);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "PantallaActiva";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Controls.Add(this.pictureBox1);
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(234, 130);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(700, 390);
            this.panelContenedor.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::UserInterfaceZoo.Properties.Resources.e5ba79334133d2cb362dd639f755a392;
            this.pictureBox1.Location = new System.Drawing.Point(154, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 301);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // horaFecha
            // 
            this.horaFecha.Enabled = true;
            this.horaFecha.Tick += new System.EventHandler(this.horaFecha_Tick);
            // 
            // pbLogoTemp
            // 
            this.pbLogoTemp.Dock = System.Windows.Forms.DockStyle.Left;
            this.pbLogoTemp.Image = global::UserInterfaceZoo.Properties.Resources.logo_zootopia;
            this.pbLogoTemp.Location = new System.Drawing.Point(0, 0);
            this.pbLogoTemp.Name = "pbLogoTemp";
            this.pbLogoTemp.Size = new System.Drawing.Size(142, 100);
            this.pbLogoTemp.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogoTemp.TabIndex = 2;
            this.pbLogoTemp.TabStop = false;
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 561);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelBase);
            this.Controls.Add(this.panelDatos);
            this.Controls.Add(this.panelSideMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "MenuPrincipal";
            this.Text = "SIstema Administrador Zootopia";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelUsuario.ResumeLayout(false);
            this.panelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPerfil)).EndInit();
            this.panelSubMenus.ResumeLayout(false);
            this.panelInteractivoSubMenu.ResumeLayout(false);
            this.panelGestionSubMenu.ResumeLayout(false);
            this.panelComprasSubMenu.ResumeLayout(false);
            this.panelVentasSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.panelDatos.ResumeLayout(false);
            this.panelDatos.PerformLayout();
            this.panelFecha.ResumeLayout(false);
            this.panelFecha.PerformLayout();
            this.panelBase.ResumeLayout(false);
            this.panelTitulo.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogoTemp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelVentasSubMenu;
        private System.Windows.Forms.Button btnSMApartarBoletos;
        private System.Windows.Forms.Button btnSMVender;
        private System.Windows.Forms.Button btnSMCerrarCaja;
        private System.Windows.Forms.Button btnSMAbrirCaja;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelDatos;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Panel panelBase;
        private System.Windows.Forms.Panel panelTitulo;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelSubMenus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblMensajes;
        private System.Windows.Forms.Panel panelUsuario;
        private System.Windows.Forms.PictureBox pbPerfil;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.Label lblCargo;
        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.Label lblNombreZoo;
        private System.Windows.Forms.Panel panelFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Timer horaFecha;
        private System.Windows.Forms.Panel panelComprasSubMenu;
        private System.Windows.Forms.Button btnSMOrdenCompra;
        private System.Windows.Forms.Button btnCompras;
        private System.Windows.Forms.Button btnSMInventario;
        private System.Windows.Forms.Panel panelGestionSubMenu;
        private System.Windows.Forms.Button btnSMSanitizar;
        private System.Windows.Forms.Button btnSMReciclado;
        private System.Windows.Forms.Button btnSMMaquinaExp;
        private System.Windows.Forms.Button btnGestion;
        private System.Windows.Forms.Button btnSMAlimento;
        private System.Windows.Forms.Panel panelInteractivoSubMenu;
        private System.Windows.Forms.Button btnSMVideojuego;
        private System.Windows.Forms.Button btnSMInformacion;
        private System.Windows.Forms.Button btnInteractivo;
        private System.Windows.Forms.PictureBox pbLogoTemp;
    }
}

