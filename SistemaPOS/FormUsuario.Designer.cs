namespace SistemaPOS
{
    partial class FormUsuario
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
            btnGuardar = new Button();
            dgvUsuario = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Siglas = new DataGridViewTextBoxColumn();
            NumeroIdentificacion = new DataGridViewTextBoxColumn();
            NombreCompleto = new DataGridViewTextBoxColumn();
            CorreoUsuario = new DataGridViewTextBoxColumn();
            NombreCargo = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            contraseña = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            fechaNacimiento = new DataGridViewTextBoxColumn();
            habilitado = new DataGridViewCheckBoxColumn();
            Eliminar = new DataGridViewImageColumn();
            usuarioBindingSource = new BindingSource(components);
            label1 = new Label();
            txtIdUsuario = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtTelefono = new TextBox();
            txtContraseña = new TextBox();
            txtNombreUsuario = new TextBox();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            cBTipoIdentificacion = new ComboBox();
            cBNombreCargo = new ComboBox();
            dtpFechaNacimiento = new DateTimePicker();
            chHabiltado = new CheckBox();
            label10 = new Label();
            label11 = new Label();
            txtCorreo = new TextBox();
            txtNombreyApellido = new TextBox();
            tipoIdentificacionDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            cargoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            nombreCargoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            siglasDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            txtNumeroDocumento = new TextBox();
            label12 = new Label();
            btnExportar = new Button();
            lblmensaje = new Label();
            groupBox1 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).BeginInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = Properties.Resources.icons_save_24;
            btnGuardar.BackgroundImageLayout = ImageLayout.None;
            btnGuardar.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnGuardar.ForeColor = Color.Black;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(1485, 211);
            btnGuardar.Margin = new Padding(2, 3, 2, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 40);
            btnGuardar.TabIndex = 12;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.TopCenter;
            btnGuardar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // dgvUsuario
            // 
            dgvUsuario.AllowUserToDeleteRows = false;
            dgvUsuario.AllowUserToOrderColumns = true;
            dgvUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvUsuario.AutoGenerateColumns = false;
            dgvUsuario.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgvUsuario.BorderStyle = BorderStyle.None;
            dgvUsuario.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvUsuario.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvUsuario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsuario.Columns.AddRange(new DataGridViewColumn[] { Id, Siglas, NumeroIdentificacion, NombreCompleto, CorreoUsuario, NombreCargo, nombre, contraseña, telefono, fechaNacimiento, habilitado, Eliminar });
            dgvUsuario.DataSource = usuarioBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvUsuario.DefaultCellStyle = dataGridViewCellStyle2;
            dgvUsuario.EnableHeadersVisualStyles = false;
            dgvUsuario.Location = new Point(11, 345);
            dgvUsuario.Margin = new Padding(2, 3, 2, 3);
            dgvUsuario.Name = "dgvUsuario";
            dgvUsuario.ReadOnly = true;
            dgvUsuario.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Century", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvUsuario.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvUsuario.RowHeadersWidth = 62;
            dgvUsuario.Size = new Size(1817, 353);
            dgvUsuario.TabIndex = 13;
            dgvUsuario.CellClick += dgvUsuario_CellClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "IdUsuario";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 80;
            // 
            // Siglas
            // 
            Siglas.DataPropertyName = "Siglas";
            Siglas.HeaderText = "Tipo";
            Siglas.MinimumWidth = 6;
            Siglas.Name = "Siglas";
            Siglas.ReadOnly = true;
            Siglas.Width = 80;
            // 
            // NumeroIdentificacion
            // 
            NumeroIdentificacion.DataPropertyName = "NumeroIdentificacion";
            NumeroIdentificacion.HeaderText = "Numero Doc.";
            NumeroIdentificacion.MinimumWidth = 6;
            NumeroIdentificacion.Name = "NumeroIdentificacion";
            NumeroIdentificacion.ReadOnly = true;
            NumeroIdentificacion.Width = 200;
            // 
            // NombreCompleto
            // 
            NombreCompleto.DataPropertyName = "NombreCompleto";
            NombreCompleto.HeaderText = "Nombre";
            NombreCompleto.MinimumWidth = 6;
            NombreCompleto.Name = "NombreCompleto";
            NombreCompleto.ReadOnly = true;
            NombreCompleto.Width = 290;
            // 
            // CorreoUsuario
            // 
            CorreoUsuario.DataPropertyName = "CorreoUsuario";
            CorreoUsuario.HeaderText = "Correo";
            CorreoUsuario.MinimumWidth = 6;
            CorreoUsuario.Name = "CorreoUsuario";
            CorreoUsuario.ReadOnly = true;
            CorreoUsuario.Width = 250;
            // 
            // NombreCargo
            // 
            NombreCargo.DataPropertyName = "NombreCargo";
            NombreCargo.HeaderText = "Cargo";
            NombreCargo.MinimumWidth = 6;
            NombreCargo.Name = "NombreCargo";
            NombreCargo.ReadOnly = true;
            NombreCargo.Width = 180;
            // 
            // nombre
            // 
            nombre.DataPropertyName = "NombreUsuario";
            nombre.HeaderText = "Login";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.ReadOnly = true;
            nombre.Width = 250;
            // 
            // contraseña
            // 
            contraseña.DataPropertyName = "ContraseñaUsuario";
            contraseña.HeaderText = "ContraseñaUsuario";
            contraseña.MinimumWidth = 6;
            contraseña.Name = "contraseña";
            contraseña.ReadOnly = true;
            contraseña.Visible = false;
            contraseña.Width = 197;
            // 
            // telefono
            // 
            telefono.DataPropertyName = "TelefonoUsuario";
            telefono.HeaderText = "Teléfono";
            telefono.MinimumWidth = 6;
            telefono.Name = "telefono";
            telefono.ReadOnly = true;
            telefono.Width = 150;
            // 
            // fechaNacimiento
            // 
            fechaNacimiento.DataPropertyName = "FechaNacimientoUsuario";
            fechaNacimiento.HeaderText = "Fecha Nac.";
            fechaNacimiento.MinimumWidth = 6;
            fechaNacimiento.Name = "fechaNacimiento";
            fechaNacimiento.ReadOnly = true;
            fechaNacimiento.Width = 150;
            // 
            // habilitado
            // 
            habilitado.DataPropertyName = "Habilitado";
            habilitado.HeaderText = "Habilitado";
            habilitado.MinimumWidth = 6;
            habilitado.Name = "habilitado";
            habilitado.ReadOnly = true;
            habilitado.Width = 125;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "";
            Eliminar.Image = Properties.Resources.icono_delete;
            Eliminar.MinimumWidth = 8;
            Eliminar.Name = "Eliminar";
            Eliminar.ReadOnly = true;
            Eliminar.Width = 24;
            // 
            // usuarioBindingSource
            // 
            usuarioBindingSource.DataSource = typeof(SistemaPos.Entidades.Usuario);
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(30, 51);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(150, 20);
            label1.TabIndex = 2;
            label1.Text = "Id ";
            // 
            // txtIdUsuario
            // 
            txtIdUsuario.Location = new Point(184, 47);
            txtIdUsuario.Margin = new Padding(2, 3, 2, 3);
            txtIdUsuario.Name = "txtIdUsuario";
            txtIdUsuario.ReadOnly = true;
            txtIdUsuario.Size = new Size(329, 34);
            txtIdUsuario.TabIndex = 1;
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(568, 149);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(150, 20);
            label2.TabIndex = 4;
            label2.Text = "Contraseña";
            // 
            // label3
            // 
            label3.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(30, 149);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(150, 20);
            label3.TabIndex = 5;
            label3.Text = "Usuario";
            // 
            // label4
            // 
            label4.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(1119, 99);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(150, 33);
            label4.TabIndex = 6;
            label4.Text = "Cargo:";
            // 
            // label5
            // 
            label5.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label5.ForeColor = Color.White;
            label5.Location = new Point(568, 56);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(150, 20);
            label5.TabIndex = 7;
            label5.Text = "Tipo Identificación";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(1273, 140);
            txtTelefono.Margin = new Padding(2, 3, 2, 3);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(342, 34);
            txtTelefono.TabIndex = 9;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(722, 148);
            txtContraseña.Margin = new Padding(2, 3, 2, 3);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(359, 34);
            txtContraseña.TabIndex = 8;
            // 
            // txtNombreUsuario
            // 
            txtNombreUsuario.Location = new Point(184, 141);
            txtNombreUsuario.Margin = new Padding(2, 3, 2, 3);
            txtNombreUsuario.Name = "txtNombreUsuario";
            txtNombreUsuario.Size = new Size(329, 34);
            txtNombreUsuario.TabIndex = 7;
            // 
            // label6
            // 
            label6.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(32, 195);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(150, 20);
            label6.TabIndex = 13;
            label6.Text = "Fecha Nacimiento ";
            // 
            // label7
            // 
            label7.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(1119, 147);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(150, 20);
            label7.TabIndex = 14;
            label7.Text = "Telefono";
            // 
            // label8
            // 
            label8.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label8.ForeColor = Color.White;
            label8.Location = new Point(568, 203);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(150, 20);
            label8.TabIndex = 15;
            label8.Text = "Habilitado";
            // 
            // cBTipoIdentificacion
            // 
            cBTipoIdentificacion.FormattingEnabled = true;
            cBTipoIdentificacion.Location = new Point(722, 52);
            cBTipoIdentificacion.Margin = new Padding(2, 3, 2, 3);
            cBTipoIdentificacion.Name = "cBTipoIdentificacion";
            cBTipoIdentificacion.Size = new Size(359, 36);
            cBTipoIdentificacion.TabIndex = 2;
            // 
            // cBNombreCargo
            // 
            cBNombreCargo.FormattingEnabled = true;
            cBNombreCargo.Location = new Point(1273, 93);
            cBNombreCargo.Margin = new Padding(2, 3, 2, 3);
            cBNombreCargo.Name = "cBNombreCargo";
            cBNombreCargo.Size = new Size(342, 36);
            cBNombreCargo.TabIndex = 6;
            // 
            // dtpFechaNacimiento
            // 
            dtpFechaNacimiento.Format = DateTimePickerFormat.Short;
            dtpFechaNacimiento.Location = new Point(184, 191);
            dtpFechaNacimiento.Margin = new Padding(2, 3, 2, 3);
            dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            dtpFechaNacimiento.Size = new Size(329, 34);
            dtpFechaNacimiento.TabIndex = 10;
            // 
            // chHabiltado
            // 
            chHabiltado.AutoSize = true;
            chHabiltado.Location = new Point(722, 203);
            chHabiltado.Margin = new Padding(2, 3, 2, 3);
            chHabiltado.Name = "chHabiltado";
            chHabiltado.Size = new Size(18, 17);
            chHabiltado.TabIndex = 11;
            chHabiltado.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label10.ForeColor = Color.White;
            label10.Location = new Point(30, 96);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(160, 22);
            label10.TabIndex = 23;
            label10.Text = "Nombre Completo";
            // 
            // label11
            // 
            label11.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label11.ForeColor = Color.White;
            label11.Location = new Point(568, 101);
            label11.Margin = new Padding(2, 0, 2, 0);
            label11.Name = "label11";
            label11.Size = new Size(150, 20);
            label11.TabIndex = 24;
            label11.Text = "Correo Electronico\r\n\r\n";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(722, 100);
            txtCorreo.Margin = new Padding(2, 3, 2, 3);
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(359, 34);
            txtCorreo.TabIndex = 5;
            // 
            // txtNombreyApellido
            // 
            txtNombreyApellido.Location = new Point(184, 93);
            txtNombreyApellido.Margin = new Padding(2, 3, 2, 3);
            txtNombreyApellido.Name = "txtNombreyApellido";
            txtNombreyApellido.Size = new Size(329, 34);
            txtNombreyApellido.TabIndex = 4;
            // 
            // tipoIdentificacionDataGridViewTextBoxColumn
            // 
            tipoIdentificacionDataGridViewTextBoxColumn.DataPropertyName = "TipoIdentificacion";
            tipoIdentificacionDataGridViewTextBoxColumn.HeaderText = "TipoIdentificacion";
            tipoIdentificacionDataGridViewTextBoxColumn.MinimumWidth = 6;
            tipoIdentificacionDataGridViewTextBoxColumn.Name = "tipoIdentificacionDataGridViewTextBoxColumn";
            tipoIdentificacionDataGridViewTextBoxColumn.Width = 155;
            // 
            // cargoDataGridViewTextBoxColumn
            // 
            cargoDataGridViewTextBoxColumn.DataPropertyName = "Cargo";
            cargoDataGridViewTextBoxColumn.HeaderText = "Cargo";
            cargoDataGridViewTextBoxColumn.MinimumWidth = 6;
            cargoDataGridViewTextBoxColumn.Name = "cargoDataGridViewTextBoxColumn";
            cargoDataGridViewTextBoxColumn.Width = 76;
            // 
            // nombreCargoDataGridViewTextBoxColumn
            // 
            nombreCargoDataGridViewTextBoxColumn.DataPropertyName = "NombreCargo";
            nombreCargoDataGridViewTextBoxColumn.HeaderText = "NombreCargo";
            nombreCargoDataGridViewTextBoxColumn.MinimumWidth = 6;
            nombreCargoDataGridViewTextBoxColumn.Name = "nombreCargoDataGridViewTextBoxColumn";
            nombreCargoDataGridViewTextBoxColumn.ReadOnly = true;
            nombreCargoDataGridViewTextBoxColumn.Width = 131;
            // 
            // siglasDataGridViewTextBoxColumn
            // 
            siglasDataGridViewTextBoxColumn.DataPropertyName = "Siglas";
            siglasDataGridViewTextBoxColumn.HeaderText = "Siglas";
            siglasDataGridViewTextBoxColumn.MinimumWidth = 6;
            siglasDataGridViewTextBoxColumn.Name = "siglasDataGridViewTextBoxColumn";
            siglasDataGridViewTextBoxColumn.ReadOnly = true;
            siglasDataGridViewTextBoxColumn.Width = 70;
            // 
            // txtNumeroDocumento
            // 
            txtNumeroDocumento.Location = new Point(1273, 49);
            txtNumeroDocumento.Margin = new Padding(2, 3, 2, 3);
            txtNumeroDocumento.Name = "txtNumeroDocumento";
            txtNumeroDocumento.Size = new Size(342, 34);
            txtNumeroDocumento.TabIndex = 3;
            // 
            // label12
            // 
            label12.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label12.ForeColor = Color.White;
            label12.Location = new Point(1119, 51);
            label12.Margin = new Padding(2, 0, 2, 0);
            label12.Name = "label12";
            label12.Size = new Size(150, 20);
            label12.TabIndex = 28;
            label12.Text = "No. Identificación";
            // 
            // btnExportar
            // 
            btnExportar.BackgroundImage = Properties.Resources.icons_exportar_excel_24;
            btnExportar.BackgroundImageLayout = ImageLayout.None;
            btnExportar.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnExportar.ForeColor = Color.Black;
            btnExportar.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportar.Location = new Point(1621, 267);
            btnExportar.Margin = new Padding(2, 3, 2, 3);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(146, 40);
            btnExportar.TabIndex = 29;
            btnExportar.Text = "Exportar";
            btnExportar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // lblmensaje
            // 
            lblmensaje.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblmensaje.ForeColor = Color.White;
            lblmensaje.Location = new Point(1346, 286);
            lblmensaje.Margin = new Padding(2, 0, 2, 0);
            lblmensaje.Name = "lblmensaje";
            lblmensaje.Size = new Size(269, 21);
            lblmensaje.TabIndex = 30;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btnGuardar);
            groupBox1.Controls.Add(lblmensaje);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(btnExportar);
            groupBox1.Controls.Add(txtIdUsuario);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtNumeroDocumento);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(txtNombreyApellido);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(txtCorreo);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(txtTelefono);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(txtContraseña);
            groupBox1.Controls.Add(chHabiltado);
            groupBox1.Controls.Add(txtNombreUsuario);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(dtpFechaNacimiento);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(cBNombreCargo);
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(cBTipoIdentificacion);
            groupBox1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.LightGreen;
            groupBox1.Location = new Point(11, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1817, 327);
            groupBox1.TabIndex = 31;
            groupBox1.TabStop = false;
            groupBox1.Text = "Administración de Usuarios";
            // 
            // FormUsuario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 66, 91);
            ClientSize = new Size(1861, 709);
            Controls.Add(groupBox1);
            Controls.Add(dgvUsuario);
            Margin = new Padding(2, 3, 2, 3);
            Name = "FormUsuario";
            Text = "Administración de Usuarios";
            ((System.ComponentModel.ISupportInitialize)dgvUsuario).EndInit();
            ((System.ComponentModel.ISupportInitialize)usuarioBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGuardar;
        private DataGridView dgvUsuario;
        private Label label1;
        private TextBox txtIdUsuario;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtTelefono;
        private TextBox txtContraseña;
        private TextBox txtNombreUsuario;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox cBTipoIdentificacion;
        private ComboBox cBNombreCargo;
        private DateTimePicker dtpFechaNacimiento;
        private CheckBox chHabiltado;
        private Label label10;
        private Label label11;
        private TextBox txtCorreo;
        private TextBox txtNombreyApellido;
        private DataGridViewTextBoxColumn tipoIdentificacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreCargoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn siglasDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn siglasDataGridViewTextBoxColumn1;
        private BindingSource usuarioBindingSource;
        private DataGridViewTextBoxColumn tipoIdentificacionDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn siglasDataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn nombreCargoDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn nombreCompletoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn correoUsuarioDataGridViewTextBoxColumn;
        private TextBox txtNumeroDocumento;
        private Label label12;
        private Button btnExportar;
        private Label lblmensaje;
        private GroupBox groupBox1;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Siglas;
        private DataGridViewTextBoxColumn NumeroIdentificacion;
        private DataGridViewTextBoxColumn NombreCompleto;
        private DataGridViewTextBoxColumn CorreoUsuario;
        private DataGridViewTextBoxColumn NombreCargo;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn contraseña;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn fechaNacimiento;
        private DataGridViewCheckBoxColumn habilitado;
        private DataGridViewImageColumn Eliminar;
    }
}