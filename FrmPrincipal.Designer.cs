namespace PryAriettiSP1_Act_2
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabVentas = new System.Windows.Forms.TabControl();
            this.tabPageClientes = new System.Windows.Forms.TabPage();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtClienteID = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblidClientes = new System.Windows.Forms.Label();
            this.cmdRegistrarCliente = new System.Windows.Forms.Button();
            this.tabPageVendedor = new System.Windows.Forms.TabPage();
            this.cmdRegistrarVendedor = new System.Windows.Forms.Button();
            this.txtComisionVendedor = new System.Windows.Forms.TextBox();
            this.txtVendedorActivo = new System.Windows.Forms.TextBox();
            this.txtNombreVendedor = new System.Windows.Forms.TextBox();
            this.txtVendedorID = new System.Windows.Forms.TextBox();
            this.lblComisionVendedor = new System.Windows.Forms.Label();
            this.lblEstadoVendedor = new System.Windows.Forms.Label();
            this.lblNombreVendedor = new System.Windows.Forms.Label();
            this.lblidVendedor = new System.Windows.Forms.Label();
            this.lblTituloVendedor = new System.Windows.Forms.Label();
            this.TabPageVentas = new System.Windows.Forms.TabPage();
            this.cmdRegistrarVentas = new System.Windows.Forms.Button();
            this.lblDatosVentas = new System.Windows.Forms.Label();
            this.lstVendedorID = new System.Windows.Forms.ComboBox();
            this.lstClienteID = new System.Windows.Forms.ComboBox();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.lblMonto = new System.Windows.Forms.Label();
            this.txtMonto = new System.Windows.Forms.TextBox();
            this.txtNumeroFactura = new System.Windows.Forms.TextBox();
            this.txtTipoFactura = new System.Windows.Forms.TextBox();
            this.lblClienteID = new System.Windows.Forms.Label();
            this.lblVendedorID = new System.Windows.Forms.Label();
            this.lblNumeroFactura = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblTipoFactura = new System.Windows.Forms.Label();
            this.lblConsultar = new System.Windows.Forms.Label();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.tabVentas.SuspendLayout();
            this.tabPageClientes.SuspendLayout();
            this.tabPageVendedor.SuspendLayout();
            this.TabPageVentas.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabVentas
            // 
            this.tabVentas.Controls.Add(this.tabPageClientes);
            this.tabVentas.Controls.Add(this.tabPageVendedor);
            this.tabVentas.Controls.Add(this.TabPageVentas);
            this.tabVentas.Location = new System.Drawing.Point(12, 12);
            this.tabVentas.Name = "tabVentas";
            this.tabVentas.SelectedIndex = 0;
            this.tabVentas.Size = new System.Drawing.Size(362, 291);
            this.tabVentas.TabIndex = 0;
            this.tabVentas.SelectedIndexChanged += new System.EventHandler(this.tabVentas_SelectedIndexChanged);
            // 
            // tabPageClientes
            // 
            this.tabPageClientes.Controls.Add(this.lblTitulo);
            this.tabPageClientes.Controls.Add(this.txtNombreCliente);
            this.tabPageClientes.Controls.Add(this.txtClienteID);
            this.tabPageClientes.Controls.Add(this.lblNombreCliente);
            this.tabPageClientes.Controls.Add(this.lblidClientes);
            this.tabPageClientes.Controls.Add(this.cmdRegistrarCliente);
            this.tabPageClientes.Location = new System.Drawing.Point(4, 22);
            this.tabPageClientes.Name = "tabPageClientes";
            this.tabPageClientes.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageClientes.Size = new System.Drawing.Size(354, 265);
            this.tabPageClientes.TabIndex = 0;
            this.tabPageClientes.Text = "Clientes";
            this.tabPageClientes.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(102, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(117, 20);
            this.lblTitulo.TabIndex = 5;
            this.lblTitulo.Text = "Datos Clientes ";
            this.lblTitulo.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtNombreCliente
            // 
            this.txtNombreCliente.Location = new System.Drawing.Point(83, 135);
            this.txtNombreCliente.Name = "txtNombreCliente";
            this.txtNombreCliente.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCliente.TabIndex = 4;
            // 
            // txtClienteID
            // 
            this.txtClienteID.Location = new System.Drawing.Point(81, 83);
            this.txtClienteID.Name = "txtClienteID";
            this.txtClienteID.Size = new System.Drawing.Size(100, 20);
            this.txtClienteID.TabIndex = 3;
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Location = new System.Drawing.Point(33, 135);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(44, 13);
            this.lblNombreCliente.TabIndex = 2;
            this.lblNombreCliente.Text = "Nombre";
            // 
            // lblidClientes
            // 
            this.lblidClientes.AutoSize = true;
            this.lblidClientes.Location = new System.Drawing.Point(33, 83);
            this.lblidClientes.Name = "lblidClientes";
            this.lblidClientes.Size = new System.Drawing.Size(18, 13);
            this.lblidClientes.TabIndex = 1;
            this.lblidClientes.Text = "ID";
            // 
            // cmdRegistrarCliente
            // 
            this.cmdRegistrarCliente.Location = new System.Drawing.Point(252, 226);
            this.cmdRegistrarCliente.Name = "cmdRegistrarCliente";
            this.cmdRegistrarCliente.Size = new System.Drawing.Size(75, 23);
            this.cmdRegistrarCliente.TabIndex = 0;
            this.cmdRegistrarCliente.Text = "Registrar";
            this.cmdRegistrarCliente.UseVisualStyleBackColor = true;
            this.cmdRegistrarCliente.Click += new System.EventHandler(this.cmdRegistrarCliente_Click);
            // 
            // tabPageVendedor
            // 
            this.tabPageVendedor.Controls.Add(this.cmdRegistrarVendedor);
            this.tabPageVendedor.Controls.Add(this.txtComisionVendedor);
            this.tabPageVendedor.Controls.Add(this.txtVendedorActivo);
            this.tabPageVendedor.Controls.Add(this.txtNombreVendedor);
            this.tabPageVendedor.Controls.Add(this.txtVendedorID);
            this.tabPageVendedor.Controls.Add(this.lblComisionVendedor);
            this.tabPageVendedor.Controls.Add(this.lblEstadoVendedor);
            this.tabPageVendedor.Controls.Add(this.lblNombreVendedor);
            this.tabPageVendedor.Controls.Add(this.lblidVendedor);
            this.tabPageVendedor.Controls.Add(this.lblTituloVendedor);
            this.tabPageVendedor.Location = new System.Drawing.Point(4, 22);
            this.tabPageVendedor.Name = "tabPageVendedor";
            this.tabPageVendedor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageVendedor.Size = new System.Drawing.Size(354, 265);
            this.tabPageVendedor.TabIndex = 1;
            this.tabPageVendedor.Text = "Vendedor";
            this.tabPageVendedor.UseVisualStyleBackColor = true;
            this.tabPageVendedor.Click += new System.EventHandler(this.tabPageVendedor_Click);
            // 
            // cmdRegistrarVendedor
            // 
            this.cmdRegistrarVendedor.Location = new System.Drawing.Point(234, 226);
            this.cmdRegistrarVendedor.Name = "cmdRegistrarVendedor";
            this.cmdRegistrarVendedor.Size = new System.Drawing.Size(75, 23);
            this.cmdRegistrarVendedor.TabIndex = 9;
            this.cmdRegistrarVendedor.Text = "Registrar";
            this.cmdRegistrarVendedor.UseVisualStyleBackColor = true;
            this.cmdRegistrarVendedor.Click += new System.EventHandler(this.cmdRegistrarVendedor_Click);
            // 
            // txtComisionVendedor
            // 
            this.txtComisionVendedor.Location = new System.Drawing.Point(120, 183);
            this.txtComisionVendedor.Name = "txtComisionVendedor";
            this.txtComisionVendedor.Size = new System.Drawing.Size(100, 20);
            this.txtComisionVendedor.TabIndex = 8;
            // 
            // txtVendedorActivo
            // 
            this.txtVendedorActivo.Location = new System.Drawing.Point(120, 145);
            this.txtVendedorActivo.Name = "txtVendedorActivo";
            this.txtVendedorActivo.Size = new System.Drawing.Size(100, 20);
            this.txtVendedorActivo.TabIndex = 7;
            // 
            // txtNombreVendedor
            // 
            this.txtNombreVendedor.Location = new System.Drawing.Point(120, 107);
            this.txtNombreVendedor.Name = "txtNombreVendedor";
            this.txtNombreVendedor.Size = new System.Drawing.Size(100, 20);
            this.txtNombreVendedor.TabIndex = 6;
            // 
            // txtVendedorID
            // 
            this.txtVendedorID.Location = new System.Drawing.Point(120, 69);
            this.txtVendedorID.Name = "txtVendedorID";
            this.txtVendedorID.Size = new System.Drawing.Size(61, 20);
            this.txtVendedorID.TabIndex = 5;
            // 
            // lblComisionVendedor
            // 
            this.lblComisionVendedor.AutoSize = true;
            this.lblComisionVendedor.Location = new System.Drawing.Point(20, 183);
            this.lblComisionVendedor.Name = "lblComisionVendedor";
            this.lblComisionVendedor.Size = new System.Drawing.Size(80, 13);
            this.lblComisionVendedor.TabIndex = 4;
            this.lblComisionVendedor.Text = "Cobra Comision";
            // 
            // lblEstadoVendedor
            // 
            this.lblEstadoVendedor.AutoSize = true;
            this.lblEstadoVendedor.Location = new System.Drawing.Point(20, 145);
            this.lblEstadoVendedor.Name = "lblEstadoVendedor";
            this.lblEstadoVendedor.Size = new System.Drawing.Size(37, 13);
            this.lblEstadoVendedor.TabIndex = 3;
            this.lblEstadoVendedor.Text = "Activo";
            // 
            // lblNombreVendedor
            // 
            this.lblNombreVendedor.AutoSize = true;
            this.lblNombreVendedor.Location = new System.Drawing.Point(20, 107);
            this.lblNombreVendedor.Name = "lblNombreVendedor";
            this.lblNombreVendedor.Size = new System.Drawing.Size(44, 13);
            this.lblNombreVendedor.TabIndex = 2;
            this.lblNombreVendedor.Text = "Nombre";
            // 
            // lblidVendedor
            // 
            this.lblidVendedor.AutoSize = true;
            this.lblidVendedor.Location = new System.Drawing.Point(20, 69);
            this.lblidVendedor.Name = "lblidVendedor";
            this.lblidVendedor.Size = new System.Drawing.Size(18, 13);
            this.lblidVendedor.TabIndex = 1;
            this.lblidVendedor.Text = "ID";
            // 
            // lblTituloVendedor
            // 
            this.lblTituloVendedor.AutoSize = true;
            this.lblTituloVendedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloVendedor.Location = new System.Drawing.Point(116, 16);
            this.lblTituloVendedor.Name = "lblTituloVendedor";
            this.lblTituloVendedor.Size = new System.Drawing.Size(126, 20);
            this.lblTituloVendedor.TabIndex = 0;
            this.lblTituloVendedor.Text = "Datos Vendedor";
            // 
            // TabPageVentas
            // 
            this.TabPageVentas.Controls.Add(this.cmdRegistrarVentas);
            this.TabPageVentas.Controls.Add(this.lblDatosVentas);
            this.TabPageVentas.Controls.Add(this.lstVendedorID);
            this.TabPageVentas.Controls.Add(this.lstClienteID);
            this.TabPageVentas.Controls.Add(this.dtpFecha);
            this.TabPageVentas.Controls.Add(this.lblMonto);
            this.TabPageVentas.Controls.Add(this.txtMonto);
            this.TabPageVentas.Controls.Add(this.txtNumeroFactura);
            this.TabPageVentas.Controls.Add(this.txtTipoFactura);
            this.TabPageVentas.Controls.Add(this.lblClienteID);
            this.TabPageVentas.Controls.Add(this.lblVendedorID);
            this.TabPageVentas.Controls.Add(this.lblNumeroFactura);
            this.TabPageVentas.Controls.Add(this.lblFecha);
            this.TabPageVentas.Controls.Add(this.lblTipoFactura);
            this.TabPageVentas.Location = new System.Drawing.Point(4, 22);
            this.TabPageVentas.Name = "TabPageVentas";
            this.TabPageVentas.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageVentas.Size = new System.Drawing.Size(354, 265);
            this.TabPageVentas.TabIndex = 2;
            this.TabPageVentas.Text = "Ventas";
            this.TabPageVentas.UseVisualStyleBackColor = true;
            this.TabPageVentas.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // cmdRegistrarVentas
            // 
            this.cmdRegistrarVentas.Location = new System.Drawing.Point(219, 222);
            this.cmdRegistrarVentas.Name = "cmdRegistrarVentas";
            this.cmdRegistrarVentas.Size = new System.Drawing.Size(75, 23);
            this.cmdRegistrarVentas.TabIndex = 14;
            this.cmdRegistrarVentas.Text = "Registrar";
            this.cmdRegistrarVentas.UseVisualStyleBackColor = true;
            this.cmdRegistrarVentas.Click += new System.EventHandler(this.cmdRegistrarVentas_Click);
            // 
            // lblDatosVentas
            // 
            this.lblDatosVentas.AutoSize = true;
            this.lblDatosVentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatosVentas.Location = new System.Drawing.Point(116, 16);
            this.lblDatosVentas.Name = "lblDatosVentas";
            this.lblDatosVentas.Size = new System.Drawing.Size(107, 20);
            this.lblDatosVentas.TabIndex = 13;
            this.lblDatosVentas.Text = "Datos Ventas";
            // 
            // lstVendedorID
            // 
            this.lstVendedorID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstVendedorID.FormattingEnabled = true;
            this.lstVendedorID.Location = new System.Drawing.Point(95, 156);
            this.lstVendedorID.Name = "lstVendedorID";
            this.lstVendedorID.Size = new System.Drawing.Size(121, 21);
            this.lstVendedorID.TabIndex = 12;
            // 
            // lstClienteID
            // 
            this.lstClienteID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstClienteID.FormattingEnabled = true;
            this.lstClienteID.Location = new System.Drawing.Point(95, 127);
            this.lstClienteID.Name = "lstClienteID";
            this.lstClienteID.Size = new System.Drawing.Size(121, 21);
            this.lstClienteID.TabIndex = 11;
            this.lstClienteID.SelectedIndexChanged += new System.EventHandler(this.lstClienteID_SelectedIndexChanged);
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(95, 99);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(199, 20);
            this.dtpFecha.TabIndex = 10;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(6, 188);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(37, 13);
            this.lblMonto.TabIndex = 9;
            this.lblMonto.Text = "Monto";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(95, 185);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(62, 20);
            this.txtMonto.TabIndex = 8;
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Location = new System.Drawing.Point(95, 71);
            this.txtNumeroFactura.Name = "txtNumeroFactura";
            this.txtNumeroFactura.Size = new System.Drawing.Size(62, 20);
            this.txtNumeroFactura.TabIndex = 6;
            // 
            // txtTipoFactura
            // 
            this.txtTipoFactura.Location = new System.Drawing.Point(95, 43);
            this.txtTipoFactura.Name = "txtTipoFactura";
            this.txtTipoFactura.Size = new System.Drawing.Size(62, 20);
            this.txtTipoFactura.TabIndex = 5;
            // 
            // lblClienteID
            // 
            this.lblClienteID.AutoSize = true;
            this.lblClienteID.Location = new System.Drawing.Point(6, 130);
            this.lblClienteID.Name = "lblClienteID";
            this.lblClienteID.Size = new System.Drawing.Size(50, 13);
            this.lblClienteID.TabIndex = 4;
            this.lblClienteID.Text = "ClienteID";
            this.lblClienteID.Click += new System.EventHandler(this.label13_Click);
            // 
            // lblVendedorID
            // 
            this.lblVendedorID.AutoSize = true;
            this.lblVendedorID.Location = new System.Drawing.Point(6, 159);
            this.lblVendedorID.Name = "lblVendedorID";
            this.lblVendedorID.Size = new System.Drawing.Size(64, 13);
            this.lblVendedorID.TabIndex = 3;
            this.lblVendedorID.Text = "VendedorID";
            // 
            // lblNumeroFactura
            // 
            this.lblNumeroFactura.AutoSize = true;
            this.lblNumeroFactura.Location = new System.Drawing.Point(6, 72);
            this.lblNumeroFactura.Name = "lblNumeroFactura";
            this.lblNumeroFactura.Size = new System.Drawing.Size(83, 13);
            this.lblNumeroFactura.TabIndex = 2;
            this.lblNumeroFactura.Text = "Numero Factura";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(6, 101);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.Click += new System.EventHandler(this.label10_Click);
            // 
            // lblTipoFactura
            // 
            this.lblTipoFactura.AutoSize = true;
            this.lblTipoFactura.Location = new System.Drawing.Point(6, 43);
            this.lblTipoFactura.Name = "lblTipoFactura";
            this.lblTipoFactura.Size = new System.Drawing.Size(67, 13);
            this.lblTipoFactura.TabIndex = 0;
            this.lblTipoFactura.Text = "TipoFactura ";
            // 
            // lblConsultar
            // 
            this.lblConsultar.AutoSize = true;
            this.lblConsultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConsultar.Location = new System.Drawing.Point(22, 324);
            this.lblConsultar.Name = "lblConsultar";
            this.lblConsultar.Size = new System.Drawing.Size(248, 16);
            this.lblConsultar.TabIndex = 1;
            this.lblConsultar.Text = "Consulte La informacion aqui ------>";
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Location = new System.Drawing.Point(276, 321);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(75, 23);
            this.cmdConsultar.TabIndex = 2;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(410, 353);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.lblConsultar);
            this.Controls.Add(this.tabVentas);
            this.Name = "FrmPrincipal";
            this.Text = "Base de Datos SP1";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.tabVentas.ResumeLayout(false);
            this.tabPageClientes.ResumeLayout(false);
            this.tabPageClientes.PerformLayout();
            this.tabPageVendedor.ResumeLayout(false);
            this.tabPageVendedor.PerformLayout();
            this.TabPageVentas.ResumeLayout(false);
            this.TabPageVentas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabVentas;
        private System.Windows.Forms.TabPage tabPageClientes;
        private System.Windows.Forms.TabPage tabPageVendedor;
        private System.Windows.Forms.TextBox txtNombreCliente;
        private System.Windows.Forms.TextBox txtClienteID;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label lblidClientes;
        private System.Windows.Forms.Button cmdRegistrarCliente;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button cmdRegistrarVendedor;
        private System.Windows.Forms.TextBox txtComisionVendedor;
        private System.Windows.Forms.TextBox txtVendedorActivo;
        private System.Windows.Forms.TextBox txtNombreVendedor;
        private System.Windows.Forms.TextBox txtVendedorID;
        private System.Windows.Forms.Label lblComisionVendedor;
        private System.Windows.Forms.Label lblEstadoVendedor;
        private System.Windows.Forms.Label lblNombreVendedor;
        private System.Windows.Forms.Label lblidVendedor;
        private System.Windows.Forms.Label lblTituloVendedor;
        private System.Windows.Forms.TabPage TabPageVentas;
        private System.Windows.Forms.TextBox txtMonto;
        private System.Windows.Forms.TextBox txtNumeroFactura;
        private System.Windows.Forms.TextBox txtTipoFactura;
        private System.Windows.Forms.Label lblClienteID;
        private System.Windows.Forms.Label lblVendedorID;
        private System.Windows.Forms.Label lblNumeroFactura;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblTipoFactura;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.ComboBox lstVendedorID;
        private System.Windows.Forms.ComboBox lstClienteID;
        private System.Windows.Forms.Label lblDatosVentas;
        private System.Windows.Forms.Button cmdRegistrarVentas;
        private System.Windows.Forms.Label lblConsultar;
        private System.Windows.Forms.Button cmdConsultar;
    }
}

