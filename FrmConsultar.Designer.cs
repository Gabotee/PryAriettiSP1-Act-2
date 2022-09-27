namespace PryAriettiSP1_Act_2
{
    partial class FrmConsultar
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
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.ColumnaTipoFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaNumeroFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaClienteID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaVendedorID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaMonto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnaFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cmdListarVentas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnaTipoFactura,
            this.ColumnaNumeroFactura,
            this.ColumnaClienteID,
            this.ColumnaVendedorID,
            this.ColumnaMonto,
            this.ColumnaFecha});
            this.dgvConsulta.Location = new System.Drawing.Point(23, 33);
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.Size = new System.Drawing.Size(646, 395);
            this.dgvConsulta.TabIndex = 0;
            // 
            // ColumnaTipoFactura
            // 
            this.ColumnaTipoFactura.HeaderText = "TipoFactura";
            this.ColumnaTipoFactura.Name = "ColumnaTipoFactura";
            // 
            // ColumnaNumeroFactura
            // 
            this.ColumnaNumeroFactura.HeaderText = "NumeroFactura";
            this.ColumnaNumeroFactura.Name = "ColumnaNumeroFactura";
            // 
            // ColumnaClienteID
            // 
            this.ColumnaClienteID.HeaderText = "ClienteID";
            this.ColumnaClienteID.Name = "ColumnaClienteID";
            // 
            // ColumnaVendedorID
            // 
            this.ColumnaVendedorID.HeaderText = "VendedorID";
            this.ColumnaVendedorID.Name = "ColumnaVendedorID";
            // 
            // ColumnaMonto
            // 
            this.ColumnaMonto.HeaderText = "Monto";
            this.ColumnaMonto.Name = "ColumnaMonto";
            // 
            // ColumnaFecha
            // 
            this.ColumnaFecha.HeaderText = "Fecha";
            this.ColumnaFecha.Name = "ColumnaFecha";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(31, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(219, 20);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Informacion de las Ventas";
            // 
            // cmdListarVentas
            // 
            this.cmdListarVentas.Location = new System.Drawing.Point(564, 434);
            this.cmdListarVentas.Name = "cmdListarVentas";
            this.cmdListarVentas.Size = new System.Drawing.Size(84, 26);
            this.cmdListarVentas.TabIndex = 2;
            this.cmdListarVentas.Text = "Listar";
            this.cmdListarVentas.UseVisualStyleBackColor = true;
            this.cmdListarVentas.Click += new System.EventHandler(this.cmdListarVentas_Click);
            // 
            // FrmConsultar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 465);
            this.Controls.Add(this.cmdListarVentas);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.dgvConsulta);
            this.Name = "FrmConsultar";
            this.Text = "FrmConsultar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaTipoFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaNumeroFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaClienteID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaVendedorID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaMonto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnaFecha;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button cmdListarVentas;
    }
}