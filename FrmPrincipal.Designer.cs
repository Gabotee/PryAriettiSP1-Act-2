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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.txtNombreCliente = new System.Windows.Forms.TextBox();
            this.txtClienteID = new System.Windows.Forms.TextBox();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.lblidClientes = new System.Windows.Forms.Label();
            this.cmdRegistrarCliente = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
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
            this.tabPage3 = new System.Windows.Forms.TabPage();
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
            this.tabBaseDeDatos = new System.Windows.Forms.TabPage();
            this.cmdMostrar = new System.Windows.Forms.Button();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabBaseDeDatos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabBaseDeDatos);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(362, 291);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lblTitulo);
            this.tabPage1.Controls.Add(this.txtNombreCliente);
            this.tabPage1.Controls.Add(this.txtClienteID);
            this.tabPage1.Controls.Add(this.lblNombreCliente);
            this.tabPage1.Controls.Add(this.lblidClientes);
            this.tabPage1.Controls.Add(this.cmdRegistrarCliente);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(354, 265);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Clientes";
            this.tabPage1.UseVisualStyleBackColor = true;
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
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmdRegistrarVendedor);
            this.tabPage2.Controls.Add(this.txtComisionVendedor);
            this.tabPage2.Controls.Add(this.txtVendedorActivo);
            this.tabPage2.Controls.Add(this.txtNombreVendedor);
            this.tabPage2.Controls.Add(this.txtVendedorID);
            this.tabPage2.Controls.Add(this.lblComisionVendedor);
            this.tabPage2.Controls.Add(this.lblEstadoVendedor);
            this.tabPage2.Controls.Add(this.lblNombreVendedor);
            this.tabPage2.Controls.Add(this.lblidVendedor);
            this.tabPage2.Controls.Add(this.lblTituloVendedor);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(354, 265);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Vendedor";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmdRegistrarVendedor
            // 
            this.cmdRegistrarVendedor.Location = new System.Drawing.Point(260, 225);
            this.cmdRegistrarVendedor.Name = "cmdRegistrarVendedor";
            this.cmdRegistrarVendedor.Size = new System.Drawing.Size(75, 23);
            this.cmdRegistrarVendedor.TabIndex = 9;
            this.cmdRegistrarVendedor.Text = "Registrar";
            this.cmdRegistrarVendedor.UseVisualStyleBackColor = true;
            this.cmdRegistrarVendedor.Click += new System.EventHandler(this.cmdRegistrarVendedor_Click);
            // 
            // txtComisionVendedor
            // 
            this.txtComisionVendedor.Location = new System.Drawing.Point(120, 184);
            this.txtComisionVendedor.Name = "txtComisionVendedor";
            this.txtComisionVendedor.Size = new System.Drawing.Size(100, 20);
            this.txtComisionVendedor.TabIndex = 8;
            // 
            // txtVendedorActivo
            // 
            this.txtVendedorActivo.Location = new System.Drawing.Point(120, 149);
            this.txtVendedorActivo.Name = "txtVendedorActivo";
            this.txtVendedorActivo.Size = new System.Drawing.Size(100, 20);
            this.txtVendedorActivo.TabIndex = 7;
            // 
            // txtNombreVendedor
            // 
            this.txtNombreVendedor.Location = new System.Drawing.Point(120, 109);
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
            this.lblComisionVendedor.Location = new System.Drawing.Point(20, 184);
            this.lblComisionVendedor.Name = "lblComisionVendedor";
            this.lblComisionVendedor.Size = new System.Drawing.Size(80, 13);
            this.lblComisionVendedor.TabIndex = 4;
            this.lblComisionVendedor.Text = "Cobra Comision";
            // 
            // lblEstadoVendedor
            // 
            this.lblEstadoVendedor.AutoSize = true;
            this.lblEstadoVendedor.Location = new System.Drawing.Point(20, 149);
            this.lblEstadoVendedor.Name = "lblEstadoVendedor";
            this.lblEstadoVendedor.Size = new System.Drawing.Size(37, 13);
            this.lblEstadoVendedor.TabIndex = 3;
            this.lblEstadoVendedor.Text = "Activo";
            // 
            // lblNombreVendedor
            // 
            this.lblNombreVendedor.AutoSize = true;
            this.lblNombreVendedor.Location = new System.Drawing.Point(20, 109);
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cmdRegistrarVentas);
            this.tabPage3.Controls.Add(this.lblDatosVentas);
            this.tabPage3.Controls.Add(this.lstVendedorID);
            this.tabPage3.Controls.Add(this.lstClienteID);
            this.tabPage3.Controls.Add(this.dtpFecha);
            this.tabPage3.Controls.Add(this.lblMonto);
            this.tabPage3.Controls.Add(this.txtMonto);
            this.tabPage3.Controls.Add(this.txtNumeroFactura);
            this.tabPage3.Controls.Add(this.txtTipoFactura);
            this.tabPage3.Controls.Add(this.lblClienteID);
            this.tabPage3.Controls.Add(this.lblVendedorID);
            this.tabPage3.Controls.Add(this.lblNumeroFactura);
            this.tabPage3.Controls.Add(this.lblFecha);
            this.tabPage3.Controls.Add(this.lblTipoFactura);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(354, 265);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ventas";
            this.tabPage3.UseVisualStyleBackColor = true;
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // cmdRegistrarVentas
            // 
            this.cmdRegistrarVentas.Location = new System.Drawing.Point(259, 227);
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
            this.lstVendedorID.Location = new System.Drawing.Point(95, 162);
            this.lstVendedorID.Name = "lstVendedorID";
            this.lstVendedorID.Size = new System.Drawing.Size(121, 21);
            this.lstVendedorID.TabIndex = 12;
            // 
            // lstClienteID
            // 
            this.lstClienteID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstClienteID.FormattingEnabled = true;
            this.lstClienteID.Location = new System.Drawing.Point(95, 134);
            this.lstClienteID.Name = "lstClienteID";
            this.lstClienteID.Size = new System.Drawing.Size(121, 21);
            this.lstClienteID.TabIndex = 11;
            // 
            // dtpFecha
            // 
            this.dtpFecha.Location = new System.Drawing.Point(95, 108);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(199, 20);
            this.dtpFecha.TabIndex = 10;
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Location = new System.Drawing.Point(6, 191);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(37, 13);
            this.lblMonto.TabIndex = 9;
            this.lblMonto.Text = "Monto";
            // 
            // txtMonto
            // 
            this.txtMonto.Location = new System.Drawing.Point(95, 188);
            this.txtMonto.Name = "txtMonto";
            this.txtMonto.Size = new System.Drawing.Size(62, 20);
            this.txtMonto.TabIndex = 8;
            // 
            // txtNumeroFactura
            // 
            this.txtNumeroFactura.Location = new System.Drawing.Point(95, 75);
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
            this.lblClienteID.Location = new System.Drawing.Point(6, 134);
            this.lblClienteID.Name = "lblClienteID";
            this.lblClienteID.Size = new System.Drawing.Size(50, 13);
            this.lblClienteID.TabIndex = 4;
            this.lblClienteID.Text = "ClienteID";
            this.lblClienteID.Click += new System.EventHandler(this.label13_Click);
            // 
            // lblVendedorID
            // 
            this.lblVendedorID.AutoSize = true;
            this.lblVendedorID.Location = new System.Drawing.Point(6, 162);
            this.lblVendedorID.Name = "lblVendedorID";
            this.lblVendedorID.Size = new System.Drawing.Size(64, 13);
            this.lblVendedorID.TabIndex = 3;
            this.lblVendedorID.Text = "VendedorID";
            // 
            // lblNumeroFactura
            // 
            this.lblNumeroFactura.AutoSize = true;
            this.lblNumeroFactura.Location = new System.Drawing.Point(6, 75);
            this.lblNumeroFactura.Name = "lblNumeroFactura";
            this.lblNumeroFactura.Size = new System.Drawing.Size(83, 13);
            this.lblNumeroFactura.TabIndex = 2;
            this.lblNumeroFactura.Text = "Numero Factura";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(6, 105);
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
            // tabBaseDeDatos
            // 
            this.tabBaseDeDatos.Controls.Add(this.cmdMostrar);
            this.tabBaseDeDatos.Controls.Add(this.dgvConsulta);
            this.tabBaseDeDatos.Location = new System.Drawing.Point(4, 22);
            this.tabBaseDeDatos.Name = "tabBaseDeDatos";
            this.tabBaseDeDatos.Padding = new System.Windows.Forms.Padding(3);
            this.tabBaseDeDatos.Size = new System.Drawing.Size(354, 265);
            this.tabBaseDeDatos.TabIndex = 3;
            this.tabBaseDeDatos.Text = "Consultar";
            this.tabBaseDeDatos.UseVisualStyleBackColor = true;
            // 
            // cmdMostrar
            // 
            this.cmdMostrar.Location = new System.Drawing.Point(131, 242);
            this.cmdMostrar.Name = "cmdMostrar";
            this.cmdMostrar.Size = new System.Drawing.Size(89, 20);
            this.cmdMostrar.TabIndex = 1;
            this.cmdMostrar.Text = "Mostrar";
            this.cmdMostrar.UseVisualStyleBackColor = true;
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvConsulta.Location = new System.Drawing.Point(6, 3);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.Size = new System.Drawing.Size(342, 235);
            this.dgvConsulta.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Cliente";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Vendedor";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Ventas";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Monto";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 309);
            this.Controls.Add(this.tabControl1);
            this.Name = "FrmPrincipal";
            this.Text = "Base de Datos SP1";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabBaseDeDatos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
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
        private System.Windows.Forms.TabPage tabPage3;
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
        private System.Windows.Forms.TabPage tabBaseDeDatos;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.Button cmdMostrar;
    }
}

