namespace SistemaPOS
{
    partial class FormFacturacionVentas
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFacturacionVentas));
            dgvDetalleVenta = new DataGridView();
            productoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Cantidad = new DataGridViewTextBoxColumn();
            valorUnitarioDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            valorTotalDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewImageColumn();
            detalleVentasBindingSource = new BindingSource(components);
            label3 = new Label();
            txtCliente = new TextBox();
            btnBuscar = new Button();
            btnAgregarProducto = new Button();
            txtCodigoBarrasProducto = new TextBox();
            label1 = new Label();
            label2 = new Label();
            lbl1 = new Label();
            lblCambio = new Label();
            txtPagoCliente = new TextBox();
            label4 = new Label();
            btnGuardar = new Button();
            label5 = new Label();
            cBFormaPago = new ComboBox();
            label7 = new Label();
            lblTotal = new Label();
            label6 = new Label();
            label8 = new Label();
            btnBorrar = new Button();
            label11 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            label12 = new Label();
            txtDescuento = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).BeginInit();
            ((System.ComponentModel.ISupportInitialize)detalleVentasBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgvDetalleVenta
            // 
            dgvDetalleVenta.AllowUserToDeleteRows = false;
            dgvDetalleVenta.AllowUserToOrderColumns = true;
            dgvDetalleVenta.AutoGenerateColumns = false;
            dgvDetalleVenta.BackgroundColor = Color.FromArgb(224, 224, 224);
            dgvDetalleVenta.BorderStyle = BorderStyle.None;
            dgvDetalleVenta.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvDetalleVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvDetalleVenta.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDetalleVenta.Columns.AddRange(new DataGridViewColumn[] { productoDataGridViewTextBoxColumn, Cantidad, valorUnitarioDataGridViewTextBoxColumn, valorTotalDataGridViewTextBoxColumn, Eliminar });
            dgvDetalleVenta.DataSource = detalleVentasBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvDetalleVenta.DefaultCellStyle = dataGridViewCellStyle2;
            dgvDetalleVenta.EditMode = DataGridViewEditMode.EditOnEnter;
            dgvDetalleVenta.EnableHeadersVisualStyles = false;
            dgvDetalleVenta.Location = new Point(21, 171);
            dgvDetalleVenta.Margin = new Padding(2, 3, 2, 3);
            dgvDetalleVenta.Name = "dgvDetalleVenta";
            dgvDetalleVenta.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvDetalleVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvDetalleVenta.RowHeadersWidth = 62;
            dgvDetalleVenta.Size = new Size(1205, 389);
            dgvDetalleVenta.TabIndex = 6;
            dgvDetalleVenta.CellClick += dgvDetalleVenta_CellClick;
            dgvDetalleVenta.CellEndEdit += dgvDetalleVenta_CellEndEdit;
            // 
            // productoDataGridViewTextBoxColumn
            // 
            productoDataGridViewTextBoxColumn.DataPropertyName = "nombreProducto";
            productoDataGridViewTextBoxColumn.HeaderText = "Producto";
            productoDataGridViewTextBoxColumn.MinimumWidth = 6;
            productoDataGridViewTextBoxColumn.Name = "productoDataGridViewTextBoxColumn";
            productoDataGridViewTextBoxColumn.ReadOnly = true;
            productoDataGridViewTextBoxColumn.Width = 500;
            // 
            // Cantidad
            // 
            Cantidad.DataPropertyName = "CantidadProductos";
            Cantidad.HeaderText = "Cantidad";
            Cantidad.MinimumWidth = 6;
            Cantidad.Name = "Cantidad";
            Cantidad.Width = 140;
            // 
            // valorUnitarioDataGridViewTextBoxColumn
            // 
            valorUnitarioDataGridViewTextBoxColumn.DataPropertyName = "ValorUnitario";
            valorUnitarioDataGridViewTextBoxColumn.HeaderText = "Valor Unitario";
            valorUnitarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            valorUnitarioDataGridViewTextBoxColumn.Name = "valorUnitarioDataGridViewTextBoxColumn";
            valorUnitarioDataGridViewTextBoxColumn.ReadOnly = true;
            valorUnitarioDataGridViewTextBoxColumn.Width = 170;
            // 
            // valorTotalDataGridViewTextBoxColumn
            // 
            valorTotalDataGridViewTextBoxColumn.DataPropertyName = "ValorTotal";
            valorTotalDataGridViewTextBoxColumn.HeaderText = "Valor Total";
            valorTotalDataGridViewTextBoxColumn.MinimumWidth = 6;
            valorTotalDataGridViewTextBoxColumn.Name = "valorTotalDataGridViewTextBoxColumn";
            valorTotalDataGridViewTextBoxColumn.ReadOnly = true;
            valorTotalDataGridViewTextBoxColumn.Width = 170;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Image = Properties.Resources.icono_delete;
            Eliminar.MinimumWidth = 8;
            Eliminar.Name = "Eliminar";
            Eliminar.Width = 125;
            // 
            // detalleVentasBindingSource
            // 
            detalleVentasBindingSource.DataSource = typeof(SistemaPos.Entidades.DetalleVentas);
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(826, 101);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(129, 28);
            label3.TabIndex = 55;
            label3.Text = "Cliente";
            // 
            // txtCliente
            // 
            txtCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCliente.Location = new Point(975, 95);
            txtCliente.Margin = new Padding(2, 3, 2, 3);
            txtCliente.MinimumSize = new Size(0, 40);
            txtCliente.Name = "txtCliente";
            txtCliente.ReadOnly = true;
            txtCliente.Size = new Size(261, 40);
            txtCliente.TabIndex = 4;
            // 
            // btnBuscar
            // 
            btnBuscar.BackgroundImage = Properties.Resources.icons8_búsqueda_20;
            btnBuscar.BackgroundImageLayout = ImageLayout.None;
            btnBuscar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(1281, 98);
            btnBuscar.Margin = new Padding(2, 3, 2, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(134, 43);
            btnBuscar.TabIndex = 3;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextAlign = ContentAlignment.TopCenter;
            btnBuscar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackgroundImageLayout = ImageLayout.None;
            btnAgregarProducto.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarProducto.ImageAlign = ContentAlignment.MiddleLeft;
            btnAgregarProducto.Location = new Point(538, 91);
            btnAgregarProducto.Margin = new Padding(2, 3, 2, 3);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Size = new Size(206, 47);
            btnAgregarProducto.TabIndex = 2;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.TextImageRelation = TextImageRelation.TextAboveImage;
            btnAgregarProducto.UseVisualStyleBackColor = true;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // txtCodigoBarrasProducto
            // 
            txtCodigoBarrasProducto.Location = new Point(260, 95);
            txtCodigoBarrasProducto.Margin = new Padding(2, 3, 2, 3);
            txtCodigoBarrasProducto.MinimumSize = new Size(0, 40);
            txtCodigoBarrasProducto.Name = "txtCodigoBarrasProducto";
            txtCodigoBarrasProducto.Size = new Size(246, 40);
            txtCodigoBarrasProducto.TabIndex = 1;
            txtCodigoBarrasProducto.TextChanged += txtCodigoBarrasProducto_TextChanged;
            txtCodigoBarrasProducto.KeyPress += txtCodigoBarrasProducto_KeyPress;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(11, 94);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(139, 28);
            label1.TabIndex = 59;
            label1.Text = "Producto";
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(1293, 598);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.MinimumSize = new Size(101, 100);
            label2.Name = "label2";
            label2.Size = new Size(210, 100);
            label2.TabIndex = 61;
            label2.Text = "TOTAL PAGAR:";
            // 
            // lbl1
            // 
            lbl1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Century Gothic", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl1.ForeColor = Color.Black;
            lbl1.Location = new Point(1339, 723);
            lbl1.Margin = new Padding(2, 0, 2, 0);
            lbl1.MinimumSize = new Size(101, 100);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(137, 100);
            lbl1.TabIndex = 62;
            lbl1.Text = "CAMBIO:";
            // 
            // lblCambio
            // 
            lblCambio.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblCambio.BackColor = Color.FromArgb(224, 224, 224);
            lblCambio.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCambio.ForeColor = Color.Red;
            lblCambio.Location = new Point(1596, 720);
            lblCambio.Margin = new Padding(2, 0, 2, 0);
            lblCambio.Name = "lblCambio";
            lblCambio.Size = new Size(203, 100);
            lblCambio.TabIndex = 63;
            lblCambio.Text = "0";
            // 
            // txtPagoCliente
            // 
            txtPagoCliente.Anchor = AnchorStyles.Bottom;
            txtPagoCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPagoCliente.Location = new Point(846, 668);
            txtPagoCliente.Margin = new Padding(2, 3, 2, 3);
            txtPagoCliente.MaxLength = 32767999;
            txtPagoCliente.MinimumSize = new Size(0, 40);
            txtPagoCliente.Name = "txtPagoCliente";
            txtPagoCliente.Size = new Size(268, 40);
            txtPagoCliente.TabIndex = 64;
            txtPagoCliente.TextChanged += txtPagoCliente_TextChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Bottom;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(678, 668);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.MinimumSize = new Size(0, 30);
            label4.Name = "label4";
            label4.Size = new Size(136, 30);
            label4.TabIndex = 65;
            label4.Text = "Billete Pago";
            // 
            // btnGuardar
            // 
            btnGuardar.Anchor = AnchorStyles.Bottom;
            btnGuardar.BackgroundImageLayout = ImageLayout.Center;
            btnGuardar.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGuardar.Location = new Point(909, 741);
            btnGuardar.Margin = new Padding(2, 3, 2, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(270, 82);
            btnGuardar.TabIndex = 3;
            btnGuardar.Text = "FACTURAR";
            btnGuardar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(21, 776);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.MinimumSize = new Size(0, 30);
            label5.Name = "label5";
            label5.Size = new Size(274, 30);
            label5.TabIndex = 67;
            label5.Text = "Forma Pago";
            // 
            // cBFormaPago
            // 
            cBFormaPago.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            cBFormaPago.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cBFormaPago.Location = new Point(260, 768);
            cBFormaPago.Name = "cBFormaPago";
            cBFormaPago.Size = new Size(268, 36);
            cBFormaPago.TabIndex = 68;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label7.BackColor = Color.FromArgb(224, 224, 224);
            label7.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(1519, 720);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(101, 100);
            label7.TabIndex = 64;
            label7.Text = "$";
            // 
            // lblTotal
            // 
            lblTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lblTotal.BackColor = Color.FromArgb(224, 224, 224);
            lblTotal.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.ForeColor = Color.LimeGreen;
            lblTotal.Location = new Point(1596, 595);
            lblTotal.Margin = new Padding(2, 0, 2, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(224, 100);
            lblTotal.TabIndex = 60;
            lblTotal.Text = "0";
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label6.BackColor = Color.FromArgb(224, 224, 224);
            label6.Font = new Font("Century Gothic", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LimeGreen;
            label6.Location = new Point(1519, 595);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(101, 100);
            label6.TabIndex = 61;
            label6.Text = "$";
            // 
            // label8
            // 
            label8.BackColor = SystemColors.HotTrack;
            label8.Dock = DockStyle.Top;
            label8.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(0, 0);
            label8.Name = "label8";
            label8.Size = new Size(1865, 60);
            label8.TabIndex = 72;
            label8.Text = "FACTURACIÓN VENTAS";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnBorrar
            // 
            btnBorrar.Anchor = AnchorStyles.Bottom;
            btnBorrar.BackgroundImageLayout = ImageLayout.None;
            btnBorrar.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBorrar.Location = new Point(639, 741);
            btnBorrar.Margin = new Padding(2, 3, 2, 3);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(257, 82);
            btnBorrar.TabIndex = 77;
            btnBorrar.Text = "BORRAR";
            btnBorrar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // label11
            // 
            label11.Image = Properties.Resources.icons8_código_de_barras_50;
            label11.Location = new Point(155, 84);
            label11.Name = "label11";
            label11.Size = new Size(100, 61);
            label11.TabIndex = 78;
            // 
            // label12
            // 
            label12.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label12.BackColor = Color.Transparent;
            label12.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold);
            label12.ForeColor = Color.Black;
            label12.Location = new Point(39, 668);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.MinimumSize = new Size(0, 30);
            label12.Name = "label12";
            label12.Size = new Size(169, 30);
            label12.TabIndex = 80;
            label12.Text = "Descuento";
            // 
            // txtDescuento
            // 
            txtDescuento.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            txtDescuento.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescuento.Location = new Point(260, 668);
            txtDescuento.Margin = new Padding(2, 3, 2, 3);
            txtDescuento.MaxLength = 32767999;
            txtDescuento.MinimumSize = new Size(0, 40);
            txtDescuento.Name = "txtDescuento";
            txtDescuento.Size = new Size(268, 40);
            txtDescuento.TabIndex = 79;
            txtDescuento.Text = "0";
            txtDescuento.TextChanged += txtDescuento_TextChanged;
            // 
            // FormFacturacionVentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(224, 224, 224);
            ClientSize = new Size(1865, 832);
            Controls.Add(lblCambio);
            Controls.Add(label7);
            Controls.Add(lblTotal);
            Controls.Add(label6);
            Controls.Add(label12);
            Controls.Add(txtDescuento);
            Controls.Add(label11);
            Controls.Add(btnBorrar);
            Controls.Add(label8);
            Controls.Add(cBFormaPago);
            Controls.Add(label5);
            Controls.Add(btnGuardar);
            Controls.Add(label4);
            Controls.Add(txtPagoCliente);
            Controls.Add(lbl1);
            Controls.Add(dgvDetalleVenta);
            Controls.Add(label2);
            Controls.Add(txtCodigoBarrasProducto);
            Controls.Add(label1);
            Controls.Add(btnAgregarProducto);
            Controls.Add(btnBuscar);
            Controls.Add(txtCliente);
            Controls.Add(label3);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormFacturacionVentas";
            Text = "FacturacionVentas";
            ((System.ComponentModel.ISupportInitialize)dgvDetalleVenta).EndInit();
            ((System.ComponentModel.ISupportInitialize)detalleVentasBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvDetalleVenta;
        private Label label3;
        private Button btnBuscar;
        public TextBox txtCliente;
        private Button btnAgregarProducto;
        public TextBox txtCodigoBarrasProducto;
        private Label label1;
        private BindingSource detalleVentasBindingSource;
        private Label label2;
        private Label lbl1;
        private Label lblCambio;
        public TextBox txtPagoCliente;
        private Label label4;
        private Button btnGuardar;
        private Label label5;
        private ComboBox cBFormaPago;
        private Label label7;
        private Label lblTotal;
        private Label label6;
        private Label label8;
        private Button btnBorrar;
        private Label label11;
        private System.Windows.Forms.Timer timer1;
        private Label label12;
        public TextBox txtDescuento;
        private DataGridViewTextBoxColumn productoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn valorUnitarioDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn valorTotalDataGridViewTextBoxColumn;
        private DataGridViewImageColumn Eliminar;
    }
}