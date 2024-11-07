namespace SistemaPOS
{
    partial class FormConsultaFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsultaFactura));
            label7 = new Label();
            cBFormaPago = new ComboBox();
            txtCliente = new TextBox();
            dTPFechaInicio = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dTPFechaFin = new DateTimePicker();
            cBUsuario = new ComboBox();
            facturacionVentasBindingSource = new BindingSource(components);
            dgvConsultaVentas = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            DatosVenta = new DataGridViewTextBoxColumn();
            FacturaNum = new DataGridViewTextBoxColumn();
            Cliente = new DataGridViewTextBoxColumn();
            ValorVenta = new DataGridViewTextBoxColumn();
            Descuento = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            FormaPago = new DataGridViewTextBoxColumn();
            Cambio = new DataGridViewTextBoxColumn();
            NombreUsuario = new DataGridViewTextBoxColumn();
            btnBuscar = new Button();
            btnNuevaFactura = new Button();
            btnExportar = new Button();
            lblmensaje = new Label();
            brnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)facturacionVentasBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaVentas).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(39, 37);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(150, 20);
            label7.TabIndex = 44;
            label7.Text = "Fecha Inicio";
            // 
            // cBFormaPago
            // 
            cBFormaPago.FormattingEnabled = true;
            cBFormaPago.Location = new Point(700, 105);
            cBFormaPago.Margin = new Padding(2, 3, 2, 3);
            cBFormaPago.Name = "cBFormaPago";
            cBFormaPago.Size = new Size(250, 28);
            cBFormaPago.TabIndex = 4;
            // 
            // txtCliente
            // 
            txtCliente.Location = new Point(173, 101);
            txtCliente.Margin = new Padding(2, 3, 2, 3);
            txtCliente.Name = "txtCliente";
            txtCliente.Size = new Size(250, 27);
            txtCliente.TabIndex = 3;
            txtCliente.TextChanged += txtCliente_TextChanged;
            // 
            // dTPFechaInicio
            // 
            dTPFechaInicio.Format = DateTimePickerFormat.Short;
            dTPFechaInicio.Location = new Point(173, 30);
            dTPFechaInicio.Margin = new Padding(3, 4, 3, 4);
            dTPFechaInicio.MinDate = new DateTime(1753, 1, 24, 0, 0, 0, 0);
            dTPFechaInicio.Name = "dTPFechaInicio";
            dTPFechaInicio.Size = new Size(250, 27);
            dTPFechaInicio.TabIndex = 1;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(39, 171);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 25);
            label1.TabIndex = 52;
            label1.Text = "Usuario";
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(560, 107);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(135, 28);
            label2.TabIndex = 53;
            label2.Text = "Forma Pago";
            // 
            // label3
            // 
            label3.BackColor = Color.FromArgb(45, 66, 91);
            label3.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.Transparent;
            label3.Location = new Point(39, 103);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(129, 28);
            label3.TabIndex = 54;
            label3.Text = "Cliente";
            // 
            // label4
            // 
            label4.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(560, 41);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(150, 20);
            label4.TabIndex = 55;
            label4.Text = "Fecha Fin";
            // 
            // dTPFechaFin
            // 
            dTPFechaFin.Format = DateTimePickerFormat.Short;
            dTPFechaFin.Location = new Point(700, 34);
            dTPFechaFin.Margin = new Padding(3, 4, 3, 4);
            dTPFechaFin.Name = "dTPFechaFin";
            dTPFechaFin.Size = new Size(250, 27);
            dTPFechaFin.TabIndex = 2;
            // 
            // cBUsuario
            // 
            cBUsuario.FormattingEnabled = true;
            cBUsuario.Location = new Point(173, 169);
            cBUsuario.Margin = new Padding(2, 3, 2, 3);
            cBUsuario.Name = "cBUsuario";
            cBUsuario.Size = new Size(250, 28);
            cBUsuario.TabIndex = 5;
            // 
            // facturacionVentasBindingSource
            // 
            facturacionVentasBindingSource.DataSource = typeof(SistemaPos.Entidades.FacturacionVentas);
            // 
            // dgvConsultaVentas
            // 
            dgvConsultaVentas.AllowUserToDeleteRows = false;
            dgvConsultaVentas.AllowUserToOrderColumns = true;
            dgvConsultaVentas.AutoGenerateColumns = false;
            dgvConsultaVentas.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgvConsultaVentas.BorderStyle = BorderStyle.None;
            dgvConsultaVentas.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvConsultaVentas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvConsultaVentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvConsultaVentas.Columns.AddRange(new DataGridViewColumn[] { Id, DatosVenta, FacturaNum, Cliente, ValorVenta, Descuento, Total, FormaPago, Cambio, NombreUsuario });
            dgvConsultaVentas.DataSource = facturacionVentasBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvConsultaVentas.DefaultCellStyle = dataGridViewCellStyle2;
            dgvConsultaVentas.EnableHeadersVisualStyles = false;
            dgvConsultaVentas.Location = new Point(24, 293);
            dgvConsultaVentas.Margin = new Padding(2, 3, 2, 3);
            dgvConsultaVentas.Name = "dgvConsultaVentas";
            dgvConsultaVentas.ReadOnly = true;
            dgvConsultaVentas.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvConsultaVentas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvConsultaVentas.RowHeadersWidth = 62;
            dgvConsultaVentas.Size = new Size(1557, 450);
            dgvConsultaVentas.TabIndex = 58;
            dgvConsultaVentas.CellClick += dgvConsultaVentas_CellClick_1;
            dgvConsultaVentas.CellContentClick += dgvConsultaVentas_CellContentClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "IdEncabezadoVenta";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 70;
            // 
            // DatosVenta
            // 
            DatosVenta.DataPropertyName = "FechaHoraVenta";
            DatosVenta.HeaderText = "Fecha/Hora";
            DatosVenta.MinimumWidth = 6;
            DatosVenta.Name = "DatosVenta";
            DatosVenta.ReadOnly = true;
            DatosVenta.Width = 170;
            // 
            // FacturaNum
            // 
            FacturaNum.DataPropertyName = "NumeroFacturacion";
            FacturaNum.HeaderText = "Numero Fac.";
            FacturaNum.MinimumWidth = 6;
            FacturaNum.Name = "FacturaNum";
            FacturaNum.ReadOnly = true;
            FacturaNum.Width = 150;
            // 
            // Cliente
            // 
            Cliente.DataPropertyName = "NombreCliente";
            Cliente.HeaderText = "Cliente";
            Cliente.MinimumWidth = 6;
            Cliente.Name = "Cliente";
            Cliente.ReadOnly = true;
            Cliente.Width = 180;
            // 
            // ValorVenta
            // 
            ValorVenta.DataPropertyName = "ValorVenta";
            ValorVenta.HeaderText = "ValorVenta";
            ValorVenta.MinimumWidth = 6;
            ValorVenta.Name = "ValorVenta";
            ValorVenta.ReadOnly = true;
            ValorVenta.Width = 150;
            // 
            // Descuento
            // 
            Descuento.DataPropertyName = "ValorDescuento";
            Descuento.HeaderText = "Descuento";
            Descuento.MinimumWidth = 6;
            Descuento.Name = "Descuento";
            Descuento.ReadOnly = true;
            Descuento.Width = 125;
            // 
            // Total
            // 
            Total.DataPropertyName = "ValorTotal";
            Total.HeaderText = "Total";
            Total.MinimumWidth = 6;
            Total.Name = "Total";
            Total.ReadOnly = true;
            Total.Width = 150;
            // 
            // FormaPago
            // 
            FormaPago.DataPropertyName = "FormaPago";
            FormaPago.HeaderText = "FormaPago";
            FormaPago.MinimumWidth = 6;
            FormaPago.Name = "FormaPago";
            FormaPago.ReadOnly = true;
            FormaPago.Width = 150;
            // 
            // Cambio
            // 
            Cambio.DataPropertyName = "ValorCambio";
            Cambio.HeaderText = "Cambio";
            Cambio.MinimumWidth = 6;
            Cambio.Name = "Cambio";
            Cambio.ReadOnly = true;
            Cambio.Width = 150;
            // 
            // NombreUsuario
            // 
            NombreUsuario.DataPropertyName = "NombreUsuario";
            NombreUsuario.HeaderText = "Usuario";
            NombreUsuario.MinimumWidth = 6;
            NombreUsuario.Name = "NombreUsuario";
            NombreUsuario.ReadOnly = true;
            NombreUsuario.Width = 165;
            // 
            // btnBuscar
            // 
            btnBuscar.BackgroundImage = Properties.Resources.icons8_búsqueda_20;
            btnBuscar.BackgroundImageLayout = ImageLayout.None;
            btnBuscar.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnBuscar.ImageAlign = ContentAlignment.MiddleLeft;
            btnBuscar.Location = new Point(786, 161);
            btnBuscar.Margin = new Padding(2, 3, 2, 3);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(163, 47);
            btnBuscar.TabIndex = 6;
            btnBuscar.Text = "Buscar";
            btnBuscar.TextAlign = ContentAlignment.TopCenter;
            btnBuscar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnNuevaFactura
            // 
            btnNuevaFactura.BackgroundImageLayout = ImageLayout.None;
            btnNuevaFactura.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnNuevaFactura.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevaFactura.Location = new Point(25, 223);
            btnNuevaFactura.Margin = new Padding(2, 3, 2, 3);
            btnNuevaFactura.Name = "btnNuevaFactura";
            btnNuevaFactura.Size = new Size(163, 39);
            btnNuevaFactura.TabIndex = 7;
            btnNuevaFactura.Text = "Nueva Factura";
            btnNuevaFactura.TextAlign = ContentAlignment.TopCenter;
            btnNuevaFactura.TextImageRelation = TextImageRelation.TextAboveImage;
            btnNuevaFactura.UseVisualStyleBackColor = true;
            btnNuevaFactura.Click += btnNuevaFactura_Click;
            // 
            // btnExportar
            // 
            btnExportar.BackgroundImage = Properties.Resources.icons_exportar_excel_24;
            btnExportar.BackgroundImageLayout = ImageLayout.None;
            btnExportar.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnExportar.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportar.Location = new Point(1321, 236);
            btnExportar.Margin = new Padding(2, 3, 2, 3);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(146, 40);
            btnExportar.TabIndex = 61;
            btnExportar.Text = "Exportar";
            btnExportar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // lblmensaje
            // 
            lblmensaje.AutoSize = true;
            lblmensaje.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblmensaje.ForeColor = SystemColors.Window;
            lblmensaje.Location = new Point(1106, 247);
            lblmensaje.Name = "lblmensaje";
            lblmensaje.Size = new Size(0, 21);
            lblmensaje.TabIndex = 62;
            // 
            // brnLimpiar
            // 
            brnLimpiar.BackgroundImage = Properties.Resources.icons8_escoba_24;
            brnLimpiar.BackgroundImageLayout = ImageLayout.None;
            brnLimpiar.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            brnLimpiar.ImageAlign = ContentAlignment.TopLeft;
            brnLimpiar.Location = new Point(768, 217);
            brnLimpiar.Margin = new Padding(2, 3, 2, 3);
            brnLimpiar.Name = "brnLimpiar";
            brnLimpiar.Size = new Size(182, 42);
            brnLimpiar.TabIndex = 63;
            brnLimpiar.Text = "Limpiar Campos";
            brnLimpiar.TextAlign = ContentAlignment.MiddleRight;
            brnLimpiar.TextImageRelation = TextImageRelation.TextAboveImage;
            brnLimpiar.UseVisualStyleBackColor = true;
            brnLimpiar.Click += btnLimpiar_Click;
            // 
            // FormConsultaFactura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 66, 91);
            ClientSize = new Size(1843, 771);
            Controls.Add(brnLimpiar);
            Controls.Add(lblmensaje);
            Controls.Add(btnExportar);
            Controls.Add(btnNuevaFactura);
            Controls.Add(btnBuscar);
            Controls.Add(dgvConsultaVentas);
            Controls.Add(cBUsuario);
            Controls.Add(dTPFechaFin);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dTPFechaInicio);
            Controls.Add(txtCliente);
            Controls.Add(cBFormaPago);
            Controls.Add(label7);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormConsultaFactura";
            Text = "FormConsultaFactura";
            ((System.ComponentModel.ISupportInitialize)facturacionVentasBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvConsultaVentas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private ComboBox cBFormaPago;
        private TextBox txtCliente;
        private DateTimePicker dTPFechaInicio;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DateTimePicker dTPFechaFin;
        private ComboBox cBUsuario;
        private BindingSource facturacionVentasBindingSource;
        private DataGridView dgvConsultaVentas;
        private Button btnBuscar;
        private Button btnNuevaFactura;
        private Button btnExportar;
        private Label lblmensaje;
        private Button brnLimpiar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn DatosVenta;
        private DataGridViewTextBoxColumn FacturaNum;
        private DataGridViewTextBoxColumn Cliente;
        private DataGridViewTextBoxColumn ValorVenta;
        private DataGridViewTextBoxColumn Descuento;
        private DataGridViewTextBoxColumn Total;
        private DataGridViewTextBoxColumn FormaPago;
        private DataGridViewTextBoxColumn Cambio;
        private DataGridViewTextBoxColumn NombreUsuario;
    }
}