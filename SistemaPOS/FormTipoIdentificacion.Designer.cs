﻿namespace SistemaPOS
{
    partial class FormTipoIdentificacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTipoIdentificacion));
            label1 = new Label();
            label2 = new Label();
            txtId = new TextBox();
            dgvTipoIdentificacion = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nombre = new DataGridViewTextBoxColumn();
            Siglas = new DataGridViewTextBoxColumn();
            Eliminar = new DataGridViewImageColumn();
            tipoIdentificacionBindingSource = new BindingSource(components);
            txtTipo = new TextBox();
            label3 = new Label();
            txtSiglas = new TextBox();
            label8 = new Label();
            btnGuardar = new Button();
            btnExportar = new Button();
            lblmensaje = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvTipoIdentificacion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tipoIdentificacionBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label1.ForeColor = Color.White;
            label1.Location = new Point(14, 77);
            label1.Name = "label1";
            label1.Size = new Size(150, 20);
            label1.TabIndex = 0;
            label1.Text = "Id ";
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label2.ForeColor = Color.White;
            label2.Location = new Point(374, 69);
            label2.Name = "label2";
            label2.Size = new Size(150, 35);
            label2.TabIndex = 1;
            label2.Text = "Tipo Identificación";
            // 
            // txtId
            // 
            txtId.Location = new Point(93, 67);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(250, 27);
            txtId.TabIndex = 3;
            // 
            // dgvTipoIdentificacion
            // 
            dgvTipoIdentificacion.AutoGenerateColumns = false;
            dgvTipoIdentificacion.BackgroundColor = Color.FromArgb(45, 66, 91);
            dgvTipoIdentificacion.BorderStyle = BorderStyle.None;
            dgvTipoIdentificacion.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.HotTrack;
            dataGridViewCellStyle1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvTipoIdentificacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvTipoIdentificacion.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTipoIdentificacion.Columns.AddRange(new DataGridViewColumn[] { Id, Nombre, Siglas, Eliminar });
            dgvTipoIdentificacion.DataSource = tipoIdentificacionBindingSource;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvTipoIdentificacion.DefaultCellStyle = dataGridViewCellStyle2;
            dgvTipoIdentificacion.EnableHeadersVisualStyles = false;
            dgvTipoIdentificacion.GridColor = Color.SteelBlue;
            dgvTipoIdentificacion.Location = new Point(24, 175);
            dgvTipoIdentificacion.Name = "dgvTipoIdentificacion";
            dgvTipoIdentificacion.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvTipoIdentificacion.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvTipoIdentificacion.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(45, 66, 91);
            dataGridViewCellStyle4.Font = new Font("Century Gothic", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dgvTipoIdentificacion.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dgvTipoIdentificacion.Size = new Size(1131, 397);
            dgvTipoIdentificacion.TabIndex = 4;
            dgvTipoIdentificacion.CellClick += dgvTipoIdentificacion_CellClick;
            // 
            // Id
            // 
            Id.DataPropertyName = "IdTipoIdentificacion";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Width = 50;
            // 
            // Nombre
            // 
            Nombre.DataPropertyName = "NombreTipoIdentificacion";
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            Nombre.Width = 280;
            // 
            // Siglas
            // 
            Siglas.DataPropertyName = "Siglas";
            Siglas.HeaderText = "Siglas";
            Siglas.MinimumWidth = 6;
            Siglas.Name = "Siglas";
            Siglas.Width = 125;
            // 
            // Eliminar
            // 
            Eliminar.HeaderText = "Eliminar";
            Eliminar.Image = Properties.Resources.icono_delete;
            Eliminar.MinimumWidth = 6;
            Eliminar.Name = "Eliminar";
            Eliminar.Width = 90;
            // 
            // tipoIdentificacionBindingSource
            // 
            tipoIdentificacionBindingSource.DataSource = typeof(SistemaPos.Entidades.TipoIdentificacion);
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(518, 65);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(250, 27);
            txtTipo.TabIndex = 5;
            // 
            // label3
            // 
            label3.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            label3.ForeColor = Color.White;
            label3.Location = new Point(785, 67);
            label3.Name = "label3";
            label3.Size = new Size(150, 28);
            label3.TabIndex = 6;
            label3.Text = "Siglas";
            // 
            // txtSiglas
            // 
            txtSiglas.Location = new Point(895, 64);
            txtSiglas.Name = "txtSiglas";
            txtSiglas.Size = new Size(250, 27);
            txtSiglas.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.FromArgb(45, 66, 91);
            label8.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.LightGreen;
            label8.Location = new Point(11, 15);
            label8.Name = "label8";
            label8.Size = new Size(324, 23);
            label8.TabIndex = 17;
            label8.Text = "Administración Tipo Identificación";
            // 
            // btnGuardar
            // 
            btnGuardar.BackgroundImage = Properties.Resources.icons_save_24;
            btnGuardar.BackgroundImageLayout = ImageLayout.None;
            btnGuardar.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnGuardar.ForeColor = SystemColors.WindowText;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(193, 108);
            btnGuardar.Margin = new Padding(2, 3, 2, 3);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(150, 40);
            btnGuardar.TabIndex = 19;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextAlign = ContentAlignment.TopCenter;
            btnGuardar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click_1;
            // 
            // btnExportar
            // 
            btnExportar.BackgroundImage = Properties.Resources.icons_exportar_excel_24;
            btnExportar.BackgroundImageLayout = ImageLayout.None;
            btnExportar.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold);
            btnExportar.ImageAlign = ContentAlignment.MiddleLeft;
            btnExportar.Location = new Point(662, 119);
            btnExportar.Margin = new Padding(2, 3, 2, 3);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(157, 39);
            btnExportar.TabIndex = 30;
            btnExportar.Text = "Exportar";
            btnExportar.TextImageRelation = TextImageRelation.TextAboveImage;
            btnExportar.UseVisualStyleBackColor = true;
            btnExportar.Click += btnExportar_Click;
            // 
            // lblmensaje
            // 
            lblmensaje.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblmensaje.ForeColor = Color.White;
            lblmensaje.Location = new Point(374, 128);
            lblmensaje.Name = "lblmensaje";
            lblmensaje.Size = new Size(273, 20);
            lblmensaje.TabIndex = 31;
            // 
            // FormTipoIdentificacion
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 66, 91);
            ClientSize = new Size(1254, 605);
            Controls.Add(lblmensaje);
            Controls.Add(btnExportar);
            Controls.Add(btnGuardar);
            Controls.Add(label8);
            Controls.Add(txtSiglas);
            Controls.Add(label3);
            Controls.Add(txtTipo);
            Controls.Add(dgvTipoIdentificacion);
            Controls.Add(txtId);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormTipoIdentificacion";
            Text = "Administración Tipo Identificación";
            ((System.ComponentModel.ISupportInitialize)dgvTipoIdentificacion).EndInit();
            ((System.ComponentModel.ISupportInitialize)tipoIdentificacionBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button btnGuardar;
        private TextBox txtId;
        private DataGridView dgvTipoIdentificacion;
        private TextBox txtTipo;
        private BindingSource tipoIdentificacionBindingSource;
        private Label label3;
        private TextBox txtSiglas;
        private Label label8;
        private DataGridViewTextBoxColumn idTipoIdentificacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nombreTipoIdentificacionDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn siglasDataGridViewTextBoxColumn;
        private Button btnExportar;
        private Label lblmensaje;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Siglas;
        private DataGridViewImageColumn Eliminar;
        //private Button btnGuardar;
    }
}