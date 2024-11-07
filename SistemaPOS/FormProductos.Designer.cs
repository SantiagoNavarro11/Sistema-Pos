namespace SistemaPOS
{
    partial class FormProductos
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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProductos));
            btnGuardar = new Button();
            dgvProductos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Producto = new DataGridViewTextBoxColumn();
            CodigoBarras = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            CantidadesDisponibles = new DataGridViewTextBoxColumn();
            Iva = new DataGridViewTextBoxColumn();
            PorcentajeGanancia = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewImageColumn();
            productoBindingSource = new BindingSource(components);
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNombreProducto = new TextBox();
            txtCodigoProducto = new TextBox();
            label7 = new Label();
            nUPPrecioProducto = new NumericUpDown();
            nUPCantidadDisponible = new NumericUpDown();
            nUPIvaProducto = new NumericUpDown();
            nUPPorcentajeGanancia = new NumericUpDown();
            btnExportar = new Button();
            lblmensaje = new Label();
            grbMantenimientoProductos = new GroupBox();
            txtId = new TextBox();
            label1 = new Label();
            grbFiltros = new GroupBox();
            txtCodigoBarras = new TextBox();
            label9 = new Label();
            txtNombre = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUPPrecioProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUPCantidadDisponible).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUPIvaProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nUPPorcentajeGanancia).BeginInit();
            grbMantenimientoProductos.SuspendLayout();
            grbFiltros.SuspendLayout();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.White;
            btnGuardar.BackgroundImage = Properties.Resources.icons_save_24;
            btnGuardar.BackgroundImageLayout = ImageLayout.None;
            btnGuardar.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.Location = new Point(1207, 131);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 40);
            btnGuardar.TabIndex = 8;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvProductos
            // 
            dgvProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            dgvProductos.AutoGenerateColumns = false;
            dgvProductos.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgvProductos.BorderStyle = BorderStyle.None;
            dgvProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { Id, Producto, CodigoBarras, Precio, CantidadesDisponibles, Iva, PorcentajeGanancia, Eliminar });
            dgvProductos.DataSource = productoBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProductos.DefaultCellStyle = dataGridViewCellStyle2;
            dgvProductos.EnableHeadersVisualStyles = false;
            dgvProductos.GridColor = Color.SteelBlue;
            dgvProductos.Location = new Point(11, 311);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvProductos.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvProductos.Size = new Size(1781, 470);
            dgvProductos.TabIndex = 10;
            dgvProductos.CellClick += dgvProductos_CellClick;
            dgvProductos.CellContentClick += dgvProductos_CellContentClick;
            dgvProductos.RowPrePaint += dgvProductos_RowPrePaint;
            // 
            // Id
            // 
            Id.DataPropertyName = "IdProducto";
            Id.HeaderText = "Id ";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 66;
            // 
            // Producto
            // 
            Producto.DataPropertyName = "NombreProducto";
            Producto.HeaderText = "Producto";
            Producto.MinimumWidth = 6;
            Producto.Name = "Producto";
            Producto.Width = 450;
            // 
            // CodigoBarras
            // 
            CodigoBarras.DataPropertyName = "CodigoBarrasProducto";
            CodigoBarras.HeaderText = "Codigo de Barras";
            CodigoBarras.MinimumWidth = 6;
            CodigoBarras.Name = "CodigoBarras";
            CodigoBarras.Width = 300;
            // 
            // Precio
            // 
            Precio.DataPropertyName = "PrecioProducto";
            Precio.HeaderText = "Precio ";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.Width = 140;
            // 
            // CantidadesDisponibles
            // 
            CantidadesDisponibles.DataPropertyName = "CantidadDisponibleProducto";
            CantidadesDisponibles.HeaderText = "Cantidad Disponible";
            CantidadesDisponibles.MinimumWidth = 6;
            CantidadesDisponibles.Name = "CantidadesDisponibles";
            CantidadesDisponibles.Width = 210;
            // 
            // Iva
            // 
            Iva.DataPropertyName = "IvaProducto";
            Iva.HeaderText = "Iva ";
            Iva.MinimumWidth = 6;
            Iva.Name = "Iva";
            Iva.Width = 78;
            // 
            // PorcentajeGanancia
            // 
            PorcentajeGanancia.DataPropertyName = "PorcentajeGanancia";
            PorcentajeGanancia.HeaderText = "Ganancia";
            PorcentajeGanancia.MinimumWidth = 6;
            PorcentajeGanancia.Name = "PorcentajeGanancia";
            PorcentajeGanancia.Width = 155;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Image = Properties.Resources.icono_delete;
            Eliminar.MinimumWidth = 6;
            Eliminar.Name = "Eliminar";
            Eliminar.Width = 88;
            // 
            // productoBindingSource
            // 
            productoBindingSource.DataSource = typeof(SistemaPos.Entidades.Producto);
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(900, 46);
            label2.Name = "label2";
            label2.Size = new Size(180, 46);
            label2.TabIndex = 4;
            label2.Text = "Cantidad Disponible";
            // 
            // label3
            // 
            label3.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(529, 95);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 5;
            label3.Text = "Precio ";
            // 
            // label4
            // 
            label4.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(16, 91);
            label4.Name = "label4";
            label4.Size = new Size(159, 21);
            label4.TabIndex = 6;
            label4.Text = "Codigo De Barras";
            // 
            // label5
            // 
            label5.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(529, 45);
            label5.Name = "label5";
            label5.Size = new Size(150, 20);
            label5.TabIndex = 7;
            label5.Text = "Nombre ";
            // 
            // label6
            // 
            label6.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(965, 91);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 8;
            label6.Text = "Iva ";
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.Location = new Point(631, 43);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(250, 27);
            txtNombreProducto.TabIndex = 2;
            // 
            // txtCodigoProducto
            // 
            txtCodigoProducto.Location = new Point(197, 88);
            txtCodigoProducto.Name = "txtCodigoProducto";
            txtCodigoProducto.Size = new Size(250, 27);
            txtCodigoProducto.TabIndex = 3;
            // 
            // label7
            // 
            label7.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(16, 140);
            label7.Name = "label7";
            label7.Size = new Size(230, 29);
            label7.TabIndex = 14;
            label7.Text = "Cantidad Ganancia";
            // 
            // nUPPrecioProducto
            // 
            nUPPrecioProducto.Increment = new decimal(new int[] { 100, 0, 0, 0 });
            nUPPrecioProducto.Location = new Point(631, 88);
            nUPPrecioProducto.Margin = new Padding(2, 4, 2, 4);
            nUPPrecioProducto.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            nUPPrecioProducto.Name = "nUPPrecioProducto";
            nUPPrecioProducto.Size = new Size(250, 27);
            nUPPrecioProducto.TabIndex = 4;
            // 
            // nUPCantidadDisponible
            // 
            nUPCantidadDisponible.Location = new Point(1085, 45);
            nUPCantidadDisponible.Margin = new Padding(2, 4, 2, 4);
            nUPCantidadDisponible.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            nUPCantidadDisponible.Name = "nUPCantidadDisponible";
            nUPCantidadDisponible.Size = new Size(251, 27);
            nUPCantidadDisponible.TabIndex = 5;
            // 
            // nUPIvaProducto
            // 
            nUPIvaProducto.Location = new Point(1085, 91);
            nUPIvaProducto.Margin = new Padding(2, 4, 2, 4);
            nUPIvaProducto.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            nUPIvaProducto.Name = "nUPIvaProducto";
            nUPIvaProducto.Size = new Size(251, 27);
            nUPIvaProducto.TabIndex = 6;
            // 
            // nUPPorcentajeGanancia
            // 
            nUPPorcentajeGanancia.Location = new Point(197, 139);
            nUPPorcentajeGanancia.Margin = new Padding(2, 4, 2, 4);
            nUPPorcentajeGanancia.Maximum = new decimal(new int[] { int.MaxValue, 0, 0, 0 });
            nUPPorcentajeGanancia.Name = "nUPPorcentajeGanancia";
            nUPPorcentajeGanancia.Size = new Size(250, 27);
            nUPPorcentajeGanancia.TabIndex = 7;
            // 
            // btnExportar
            // 
            btnExportar.BackgroundImage = Properties.Resources.icons_exportar_excel_24;
            btnExportar.BackgroundImageLayout = ImageLayout.None;
            btnExportar.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnExportar.ForeColor = Color.Black;
            btnExportar.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportar.Location = new Point(1614, 23);
            btnExportar.Margin = new Padding(2, 3, 2, 3);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(146, 40);
            btnExportar.TabIndex = 9;
            btnExportar.Text = "Exportar";
            btnExportar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // lblmensaje
            // 
            lblmensaje.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblmensaje.ForeColor = Color.White;
            lblmensaje.Location = new Point(1320, 37);
            lblmensaje.Name = "lblmensaje";
            lblmensaje.Size = new Size(240, 20);
            lblmensaje.TabIndex = 17;
            // 
            // grbMantenimientoProductos
            // 
            grbMantenimientoProductos.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grbMantenimientoProductos.Controls.Add(txtId);
            grbMantenimientoProductos.Controls.Add(label1);
            grbMantenimientoProductos.Controls.Add(txtNombreProducto);
            grbMantenimientoProductos.Controls.Add(btnGuardar);
            grbMantenimientoProductos.Controls.Add(nUPPorcentajeGanancia);
            grbMantenimientoProductos.Controls.Add(nUPIvaProducto);
            grbMantenimientoProductos.Controls.Add(label2);
            grbMantenimientoProductos.Controls.Add(nUPCantidadDisponible);
            grbMantenimientoProductos.Controls.Add(label3);
            grbMantenimientoProductos.Controls.Add(nUPPrecioProducto);
            grbMantenimientoProductos.Controls.Add(label4);
            grbMantenimientoProductos.Controls.Add(label7);
            grbMantenimientoProductos.Controls.Add(label5);
            grbMantenimientoProductos.Controls.Add(txtCodigoProducto);
            grbMantenimientoProductos.Controls.Add(label6);
            grbMantenimientoProductos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbMantenimientoProductos.ForeColor = Color.LightGreen;
            grbMantenimientoProductos.Location = new Point(11, 12);
            grbMantenimientoProductos.Name = "grbMantenimientoProductos";
            grbMantenimientoProductos.Size = new Size(1802, 189);
            grbMantenimientoProductos.TabIndex = 64;
            grbMantenimientoProductos.TabStop = false;
            grbMantenimientoProductos.Text = "Mantenimiento Productos";
            // 
            // txtId
            // 
            txtId.Location = new Point(197, 40);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(250, 27);
            txtId.TabIndex = 16;
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 43);
            label1.Name = "label1";
            label1.Size = new Size(150, 20);
            label1.TabIndex = 15;
            label1.Text = "Id";
            // 
            // grbFiltros
            // 
            grbFiltros.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            grbFiltros.Controls.Add(txtCodigoBarras);
            grbFiltros.Controls.Add(label9);
            grbFiltros.Controls.Add(btnExportar);
            grbFiltros.Controls.Add(lblmensaje);
            grbFiltros.Controls.Add(txtNombre);
            grbFiltros.Controls.Add(label8);
            grbFiltros.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grbFiltros.ForeColor = Color.LightGreen;
            grbFiltros.Location = new Point(11, 219);
            grbFiltros.Name = "grbFiltros";
            grbFiltros.Size = new Size(1802, 73);
            grbFiltros.TabIndex = 65;
            grbFiltros.TabStop = false;
            grbFiltros.Text = "Filtros";
            // 
            // txtCodigoBarras
            // 
            txtCodigoBarras.Location = new Point(197, 27);
            txtCodigoBarras.Name = "txtCodigoBarras";
            txtCodigoBarras.Size = new Size(250, 27);
            txtCodigoBarras.TabIndex = 15;
            txtCodigoBarras.TextChanged += txtCodigoBarras_TextChanged;
            // 
            // label9
            // 
            label9.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label9.ForeColor = Color.White;
            label9.Location = new Point(74, 29);
            label9.Name = "label9";
            label9.Size = new Size(101, 20);
            label9.TabIndex = 15;
            label9.Text = "Código";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(683, 23);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 27);
            txtNombre.TabIndex = 15;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // label8
            // 
            label8.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(527, 28);
            label8.Name = "label8";
            label8.Size = new Size(150, 20);
            label8.TabIndex = 8;
            label8.Text = "Nombre ";
            // 
            // FormProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 66, 91);
            ClientSize = new Size(1850, 793);
            Controls.Add(grbFiltros);
            Controls.Add(grbMantenimientoProductos);
            Controls.Add(dgvProductos);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Administración Productos";
            Load += FormProductos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)productoBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUPPrecioProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUPCantidadDisponible).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUPIvaProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)nUPPorcentajeGanancia).EndInit();
            grbMantenimientoProductos.ResumeLayout(false);
            grbMantenimientoProductos.PerformLayout();
            grbFiltros.ResumeLayout(false);
            grbFiltros.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGuardar;
        private DataGridView dgvProductos;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNombreProducto;
        private TextBox txtCodigoProducto;
        private BindingSource productoBindingSource;
        private Label label7;
        private NumericUpDown nUPPrecioProducto;
        private NumericUpDown nUPCantidadDisponible;
        private NumericUpDown nUPIvaProducto;
        private NumericUpDown nUPPorcentajeGanancia;
        private DataGridViewTextBoxColumn CantidadDisponible;
        private DataGridViewTextBoxColumn CantidadGanancia;
        private Button btnExportar;
        private Label lblmensaje;
        private GroupBox grbMantenimientoProductos;
        private GroupBox grbFiltros;
        private Label label9;
        private TextBox txtNombre;
        private Label label8;
        private TextBox txtCodigoBarras;
        private TextBox txtId;
        private Label label1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Producto;
        private DataGridViewTextBoxColumn CodigoBarras;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn CantidadesDisponibles;
        private DataGridViewTextBoxColumn Iva;
        private DataGridViewTextBoxColumn PorcentajeGanancia;
        private DataGridViewImageColumn Eliminar;
    }
}