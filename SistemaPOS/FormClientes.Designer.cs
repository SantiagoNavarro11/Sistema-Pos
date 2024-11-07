namespace SistemaPOS
{
    partial class FormClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            btnGuardar = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtTelefono = new TextBox();
            txtCorreo = new TextBox();
            txtNumeroId = new TextBox();
            txtNombre = new TextBox();
            dgvClientes = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Siglas = new DataGridViewTextBoxColumn();
            NumeroIdentificacion = new DataGridViewTextBoxColumn();
            Correo = new DataGridViewTextBoxColumn();
            Telefono = new DataGridViewTextBoxColumn();
            Usuario = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewImageColumn();
            clienteBindingSource = new BindingSource(components);
            cbTipoId = new ComboBox();
            btnExportar = new Button();
            label9 = new Label();
            lblmensaje = new Label();
            grbAdministracion = new GroupBox();
            txtId = new TextBox();
            label1 = new Label();
            grbFiltros = new GroupBox();
            txtNumeroIden = new TextBox();
            label2 = new Label();
            txtNombreCliente = new TextBox();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvClientes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).BeginInit();
            grbAdministracion.SuspendLayout();
            grbFiltros.SuspendLayout();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = Properties.Resources.icons_save_24;
            btnGuardar.BackgroundImageLayout = ImageLayout.None;
            btnGuardar.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuardar.ForeColor = SystemColors.WindowText;
            btnGuardar.Location = new Point(1302, 130);
            btnGuardar.Margin = new Padding(2, 3, 2, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(134, 37);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 9F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(1017, 95);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 5;
            label3.Text = "Telefono ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 9F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(493, 92);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(152, 20);
            label4.TabIndex = 6;
            label4.Text = "Correo Electronico ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 9F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(1017, 43);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(151, 20);
            label5.TabIndex = 7;
            label5.Text = "Tipo Identificación: ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 9F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(16, 92);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(90, 20);
            label6.TabIndex = 8;
            label6.Text = "Numero Id.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 9F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(493, 39);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(72, 20);
            label7.TabIndex = 9;
            label7.Text = "Nombre ";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(1186, 92);
            txtTelefono.Margin = new Padding(2, 3, 2, 3);
            txtTelefono.MaximumSize = new Size(250, 23);
            txtTelefono.MinimumSize = new Size(4, 23);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(250, 23);
            txtTelefono.TabIndex = 6;
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(664, 92);
            txtCorreo.Margin = new Padding(2, 3, 2, 3);
            txtCorreo.MaximumSize = new Size(250, 23);
            txtCorreo.MinimumSize = new Size(4, 23);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(250, 23);
            txtCorreo.TabIndex = 5;
            // 
            // txtNumeroId
            // 
            txtNumeroId.Location = new Point(146, 89);
            txtNumeroId.Margin = new Padding(2, 3, 2, 3);
            txtNumeroId.MaximumSize = new Size(250, 23);
            txtNumeroId.Name = "txtNumeroId";
            txtNumeroId.Size = new Size(250, 23);
            txtNumeroId.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(664, 33);
            txtNombre.Margin = new Padding(2, 3, 2, 3);
            txtNombre.MaximumSize = new Size(250, 23);
            txtNombre.MinimumSize = new Size(4, 23);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(250, 23);
            txtNombre.TabIndex = 2;
            // 
            // dgvClientes
            // 
            dgvClientes.AutoGenerateColumns = false;
            dgvClientes.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgvClientes.BorderStyle = BorderStyle.None;
            dgvClientes.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClientes.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Siglas, NumeroIdentificacion, Correo, Telefono, Usuario, Eliminar });
            dgvClientes.DataSource = clienteBindingSource;
            dgvClientes.EnableHeadersVisualStyles = false;
            dgvClientes.GridColor = Color.SteelBlue;
            dgvClientes.Location = new Point(20, 353);
            dgvClientes.Margin = new Padding(2, 3, 2, 3);
            dgvClientes.Name = "dgvClientes";
            dgvClientes.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvClientes.RowHeadersWidth = 62;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dgvClientes.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvClientes.Size = new Size(1460, 452);
            dgvClientes.TabIndex = 9;
            dgvClientes.CellClick += dgvClientes_CellClick;
            dgvClientes.CellDoubleClick += dgvClientes_CellDoubleClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "IdCliente";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 8;
            Id.Name = "Id";
            Id.Width = 95;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "NombreCliente";
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 8;
            Nombre.Name = "Nombre";
            Nombre.Width = 250;
            // 
            // Siglas
            // 
            Siglas.DataPropertyName = "Siglas";
            Siglas.HeaderText = "Siglas";
            Siglas.MinimumWidth = 8;
            Siglas.Name = "Siglas";
            Siglas.ReadOnly = true;
            Siglas.Width = 125;
            // 
            // NumeroIdentificacion
            // 
            NumeroIdentificacion.DataPropertyName = "NumeroIdentificacion";
            NumeroIdentificacion.HeaderText = "Numero Ide.";
            NumeroIdentificacion.MinimumWidth = 8;
            NumeroIdentificacion.Name = "NumeroIdentificacion";
            NumeroIdentificacion.Width = 182;
            // 
            // Correo
            // 
            Correo.DataPropertyName = "CorreoElectronico";
            Correo.HeaderText = "Correo";
            Correo.MinimumWidth = 8;
            Correo.Name = "Correo";
            Correo.Width = 250;
            // 
            // Telefono
            // 
            Telefono.DataPropertyName = "TelefonoCliente";
            Telefono.HeaderText = "Telefono";
            Telefono.MinimumWidth = 8;
            Telefono.Name = "Telefono";
            Telefono.Width = 160;
            // 
            // Usuario
            // 
            Usuario.DataPropertyName = "NombreUsuario";
            Usuario.HeaderText = "Usuario";
            Usuario.MinimumWidth = 8;
            Usuario.Name = "Usuario";
            Usuario.ReadOnly = true;
            Usuario.Width = 150;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Image = Properties.Resources.icono_delete;
            Eliminar.MinimumWidth = 8;
            Eliminar.Name = "Eliminar";
            Eliminar.Width = 67;
            // 
            // clienteBindingSource
            // 
            clienteBindingSource.DataSource = typeof(SistemaPos.Entidades.Cliente);
            // 
            // cbTipoId
            // 
            cbTipoId.DropDownStyle = ComboBoxStyle.DropDownList;
            cbTipoId.FormattingEnabled = true;
            cbTipoId.Location = new Point(1186, 35);
            cbTipoId.Margin = new Padding(2, 3, 2, 3);
            cbTipoId.MaximumSize = new Size(250, 0);
            cbTipoId.Name = "cbTipoId";
            cbTipoId.Size = new Size(250, 28);
            cbTipoId.TabIndex = 3;
            // 
            // btnExportar
            // 
            btnExportar.BackgroundImage = Properties.Resources.icons_exportar_excel_24;
            btnExportar.BackgroundImageLayout = ImageLayout.None;
            btnExportar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnExportar.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportar.Location = new Point(1334, 289);
            btnExportar.Margin = new Padding(2, 3, 2, 3);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(146, 40);
            btnExportar.TabIndex = 8;
            btnExportar.Text = "Exportar";
            btnExportar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = Color.FromArgb(45, 66, 91);
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.LightGreen;
            label9.Location = new Point(14, 12);
            label9.Name = "label9";
            label9.Size = new Size(0, 23);
            label9.TabIndex = 31;
            // 
            // lblmensaje
            // 
            lblmensaje.AutoSize = true;
            lblmensaje.Font = new Font("Century Gothic", 9F);
            lblmensaje.ForeColor = Color.White;
            lblmensaje.Location = new Point(1079, 299);
            lblmensaje.Margin = new Padding(2, 0, 2, 0);
            lblmensaje.Name = "lblmensaje";
            lblmensaje.Size = new Size(0, 20);
            lblmensaje.TabIndex = 32;
            // 
            // grbAdministracion
            // 
            grbAdministracion.Controls.Add(txtId);
            grbAdministracion.Controls.Add(label1);
            grbAdministracion.Controls.Add(label3);
            grbAdministracion.Controls.Add(label4);
            grbAdministracion.Controls.Add(cbTipoId);
            grbAdministracion.Controls.Add(btnGuardar);
            grbAdministracion.Controls.Add(label5);
            grbAdministracion.Controls.Add(label6);
            grbAdministracion.Controls.Add(txtNombre);
            grbAdministracion.Controls.Add(label7);
            grbAdministracion.Controls.Add(txtNumeroId);
            grbAdministracion.Controls.Add(txtTelefono);
            grbAdministracion.Controls.Add(txtCorreo);
            grbAdministracion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grbAdministracion.ForeColor = Color.LightGreen;
            grbAdministracion.Location = new Point(21, 16);
            grbAdministracion.Margin = new Padding(3, 4, 3, 4);
            grbAdministracion.Name = "grbAdministracion";
            grbAdministracion.Padding = new Padding(3, 4, 3, 4);
            grbAdministracion.Size = new Size(1459, 174);
            grbAdministracion.TabIndex = 33;
            grbAdministracion.TabStop = false;
            grbAdministracion.Text = "Administración de Clientes";
            // 
            // txtId
            // 
            txtId.Location = new Point(146, 36);
            txtId.Margin = new Padding(2, 3, 2, 3);
            txtId.MaximumSize = new Size(250, 23);
            txtId.MinimumSize = new Size(4, 23);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(250, 23);
            txtId.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 9F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 40);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(24, 20);
            label1.TabIndex = 10;
            label1.Text = "Id";
            // 
            // grbFiltros
            // 
            grbFiltros.Controls.Add(txtNumeroIden);
            grbFiltros.Controls.Add(label2);
            grbFiltros.Controls.Add(txtNombreCliente);
            grbFiltros.Controls.Add(label8);
            grbFiltros.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            grbFiltros.ForeColor = Color.LightGreen;
            grbFiltros.Location = new Point(21, 208);
            grbFiltros.Name = "grbFiltros";
            grbFiltros.Size = new Size(1459, 75);
            grbFiltros.TabIndex = 66;
            grbFiltros.TabStop = false;
            grbFiltros.Text = "Filtros";
            // 
            // txtNumeroIden
            // 
            txtNumeroIden.Location = new Point(125, 26);
            txtNumeroIden.Name = "txtNumeroIden";
            txtNumeroIden.Size = new Size(250, 27);
            txtNumeroIden.TabIndex = 15;
            txtNumeroIden.TextChanged += txtNumeroIden_TextChanged;
            // 
            // label2
            // 
            label2.ForeColor = Color.White;
            label2.Location = new Point(18, 30);
            label2.Name = "label2";
            label2.Size = new Size(101, 20);
            label2.TabIndex = 15;
            label2.Text = "Numero Id";
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Location = new Point(594, 30);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.Size = new Size(250, 27);
            txtNombreCliente.TabIndex = 15;
            txtNombreCliente.TextChanged += txtNombreCliente_TextChanged;
            // 
            // label8
            // 
            label8.ForeColor = Color.White;
            label8.Location = new Point(490, 34);
            label8.Name = "label8";
            label8.Size = new Size(97, 20);
            label8.TabIndex = 8;
            label8.Text = "Nombre ";
            // 
            // FormClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = Color.FromArgb(45, 66, 91);
            ClientSize = new Size(1569, 817);
            Controls.Add(grbFiltros);
            Controls.Add(grbAdministracion);
            Controls.Add(lblmensaje);
            Controls.Add(label9);
            Controls.Add(btnExportar);
            Controls.Add(dgvClientes);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2, 3, 2, 3);
            Name = "FormClientes";
            Text = "Administración Clientes";
            ((System.ComponentModel.ISupportInitialize)dgvClientes).EndInit();
            ((System.ComponentModel.ISupportInitialize)clienteBindingSource).EndInit();
            grbAdministracion.ResumeLayout(false);
            grbAdministracion.PerformLayout();
            grbFiltros.ResumeLayout(false);
            grbFiltros.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnGuardar;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtTelefono;
        private TextBox txtCorreo;
        private TextBox txtNumeroId;
        private TextBox txtNombre;
        private DataGridView dgvClientes;
        private ComboBox cbTipoId;
        private BindingSource clienteBindingSource;
        private Button btnExportar;
        private Label label9;
        private Label lblmensaje;
        private GroupBox grbAdministracion;
        private GroupBox grbFiltros;
        private TextBox txtNumeroIden;
        private Label label2;
        private TextBox txtNombreCliente;
        private Label label8;
        private TextBox txtId;
        private Label label1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Siglas;
        private DataGridViewTextBoxColumn NumeroIdentificacion;
        private DataGridViewTextBoxColumn Correo;
        private DataGridViewTextBoxColumn Telefono;
        private DataGridViewTextBoxColumn Usuario;
        private DataGridViewImageColumn Eliminar;
    }
}